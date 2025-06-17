using ControleFinanceiroDesktop.Controllers;
using ControleFinanceiroDesktop.Models.DTOs;
using ControleFinanceiroDesktop.Responses;
using ControleFinanceiroDesktop.Views.Forms;
using ControleFinanceiroDesktop.Views.ViewHelpers;

namespace ControleFinanceiroDesktop.Views
{
    public partial class _FormCategory : Form
    {
        MainFormController controller;

        List<ListItemDto>? categoryList;

        DialogResult dialogResult = DialogResult.No;

        public _FormCategory(MainFormController _controller)
        {
            controller = _controller;

            InitializeComponent();
            LoadData();

            new DataGridViewHelper(dgv);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenDetailForm(null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();

            if (id.HasValue)
            {
                OpenDetailForm(id.Value);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int? id = GetSelectedId();

            DialogResult resultado = MessageBox.Show("Atenção: excluir registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes && id.HasValue)
            {
                Delete(id);
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void _FormCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = dialogResult;
        }

        #region "subroutines"

        private void OpenDetailForm(int? id)
        {
            _FormCategoryDetails form = new(id, controller);

            if (form.ShowDialog() == DialogResult.OK)
            {
                dialogResult = DialogResult.OK;

                LoadData();
            }

            form.Dispose();
        }

        private void LoadData()
        {
            this.categoryList = controller.GetCategoryList();

            this.dgv.Rows.Clear();

            foreach (var item in categoryList)
            {
                this.dgv.Rows.Add(item.Id, item.Description);
            }
        }

        private int? GetSelectedId()
        {
            if (!int.TryParse(dgv.CurrentRow?.Cells[0]?.Value?.ToString(), out int id))
            {
                MessageBox.Show("Selecione um registro válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return null;
            }

            return id;
        }

        private void Delete(int? id)
        {
            SaveResult saveResult = controller.DeleteCategory(id.Value);

            MessageBox.Show(saveResult.Message);

            if (saveResult.Success)
            {
                dialogResult = DialogResult.OK;

                LoadData();
            }
        }

        #endregion       
    }
}
