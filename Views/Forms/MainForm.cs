using ControleFinanceiroDesktop.Controllers;
using ControleFinanceiroDesktop.Models.Domain;
using ControleFinanceiroDesktop.Models.ViewModels;
using ControleFinanceiroDesktop.Views;

namespace ControleFinanceiroDesktop
{
    public partial class MainForm : Form
    {
        public readonly MainFormController _controller;

        public int Id { get; set; } = 0;

        Font? atmCardFont;
        Image? atmCardImg;        

        public MainFormModel model = new MainFormModel();

        public MainForm(MainFormController controller)
        {
            InitializeComponent();

            _controller = controller;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            atmCardImg = btnModeloCartao.Image;            
            atmCardFont = btnModeloCartao.Font;

            flowBtnConteiner.Controls.Remove(btnModeloCartao);

            datePickerStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            datePickerEndDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            AddClickHandlerToButton(btnResumo);
            AddClickHandlerToButton(btnExtrato);
            RefreshApplication();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFormAddStatementType(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenFormAddStatementType(false);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshApplication();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Tem certeza de que deseja excluir o extrato selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                var deleteResult = _controller.DeleteStatementType(this.Id);

                MessageBox.Show(deleteResult.Message, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (deleteResult.Success)
                {
                    this.Id = 0;

                    RefreshApplication();
                }
            }
        }

        public void RefreshApplication()
        {
            model = _controller.GetMainFormModel(datePickerStartDate.Value, datePickerEndDate.Value, Id);

            RefreshButtons();
            HighlightSelectedButton();
            OpenFormInPanel();
        }

        #region "subroutines"

        private void HighlightSelectedButton()
        {
            var allButtons = panelHeader.Controls.OfType<Button>().Concat(flowBtnConteiner.Controls.OfType<Button>());

            foreach (var btn in allButtons)
            {
                for (int i = btn.Controls.Count - 1; i >= 0; i--)
                {
                    if (btn.Controls[i] is Panel panel && panel.Tag?.ToString() == "SelectionMarker")
                    {
                        btn.Controls.RemoveAt(i);
                    }
                }

                if (int.TryParse(btn.Tag?.ToString(), out int btnId) && btnId == Id)
                {
                    Panel selectionPanel = new Panel
                    {
                        Height = 4,
                        Dock = DockStyle.Bottom,
                        BackColor = Color.White,
                        Tag = "SelectionMarker"
                    };

                    btn.Controls.Add(selectionPanel);
                    btn.Controls.SetChildIndex(selectionPanel, 0);

                    labelTitle.Text = btn.Text;
                }
            }
        }

        private void RefreshButtons()
        {
            bool btnVisible = this.Id > 0;

            this.btnDelete.Visible = btnVisible;
            this.btnEdit.Visible = btnVisible;

            flowBtnConteiner.SuspendLayout();

            var currentButtons = GetCurrentFlowButtons();
            var desiredButtonsInfo = model.ButtonsInfo.ToDictionary(b => b.Id);

            RemoveObsoleteButtons(currentButtons, desiredButtonsInfo.Keys.ToHashSet());
            UpdateExistingButtons(currentButtons, desiredButtonsInfo);
            AddMissingButtons(currentButtons, desiredButtonsInfo);

            flowBtnConteiner.ResumeLayout();
        }

        private void RemoveObsoleteButtons(List<Button> currentButtons, HashSet<int> desiredIds)
        {
            foreach (var btn in currentButtons)
            {
                if (!int.TryParse(btn.Tag?.ToString(), out int existingId)) continue;

                if (!desiredIds.Contains(existingId))
                {
                    flowBtnConteiner.Controls.Remove(btn);

                    btn.Dispose();
                }
            }
        }

        private void UpdateExistingButtons(List<Button> currentButtons, Dictionary<int, ButtonInfoModel> desiredButtonsInfo)
        {
            foreach (var btn in currentButtons)
            {
                if (!int.TryParse(btn.Tag?.ToString(), out int btnId)) continue;

                if (desiredButtonsInfo.TryGetValue(btnId, out var buttonInfo))
                {
                    if (btn.Text != buttonInfo.Description)
                    {
                        btn.Text = buttonInfo.Description;
                    }
                }
            }
        }

        private void AddMissingButtons(List<Button> currentButtons, Dictionary<int, ButtonInfoModel> desiredButtonsInfo)
        {
            foreach (var buttonInfo in desiredButtonsInfo.Values)
            {
                bool exists = currentButtons.Any(b =>
                    int.TryParse(b.Tag?.ToString(), out int id) &&
                    id == buttonInfo.Id);

                if (exists) continue;

                var btn = CreateButtonFromInfo(buttonInfo);

                flowBtnConteiner.Controls.Add(btn);

                int count = flowBtnConteiner.Controls.Count;

                if (count > 1)
                {
                    flowBtnConteiner.Controls.SetChildIndex(btn, count - 2);
                }

                AddClickHandlerToButton(btn);
            }
        }

        private List<Button> GetCurrentFlowButtons()
        {
            return flowBtnConteiner.Controls
                .OfType<Button>()
                .Where(b =>
                    b.Tag != null &&
                    int.TryParse(b.Tag.ToString(), out int tagValue) &&
                    tagValue > 0)
                .ToList();
        }
         
        private Button CreateButtonFromInfo(ButtonInfoModel buttonInfo)
        {
            return new Button
            {
                Text = buttonInfo.Description,
                Tag = buttonInfo.Id,
                Image = atmCardImg,                
                FlatAppearance = { BorderSize = 0 },
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                ImageAlign = ContentAlignment.TopCenter,
                TextAlign = ContentAlignment.BottomCenter,
                Font = atmCardFont,
                Cursor = Cursors.Hand,
                Size = new Size(TextRenderer.MeasureText(buttonInfo.Description, atmCardFont).Width + 20, 60),
            };
        }

        private void AddClickHandlerToButton(Button btn)
        {
            btn.Click += (sender, e) =>
            {
                Id = int.TryParse(btn.Tag?.ToString(), out int parsedId) ? parsedId : 0;

                RefreshApplication();
            };
        }

        private void OpenFormInPanel()
        {
            panelBody.Controls.Clear();

            Form formToLoad = (this.Id == -1) ? new FormStatementSummary(this) : new FormStatementTransactions(this);

            formToLoad.TopLevel = false;
            formToLoad.FormBorderStyle = FormBorderStyle.None;
            formToLoad.Dock = DockStyle.Fill;

            panelBody.Controls.Add(formToLoad);

            formToLoad.Show();
        }

        private void OpenFormAddStatementType(bool isNew)
        {
            _FormAddStatementType form = isNew ? new _FormAddStatementType(_controller) : new _FormAddStatementType(_controller, this.Id);

            if (form.ShowDialog() == DialogResult.OK)
            {
                this.Id = form.id;

                RefreshApplication();
            }

            form.Dispose();
        }


        #endregion
    }
}
