using ControleFinanceiroDesktop.Controllers;
using ControleFinanceiroDesktop.Models.DTOs;
using ControleFinanceiroDesktop.Responses;
using ControleFinanceiroDesktop.Views.ViewHelpers;

namespace ControleFinanceiroDesktop.Views
{
    public partial class _FormStatementTransactionsDetails : Form
    {
        MainFormController controller;

        List<ListItemDto>? categoryList;

        int? id;

        int? statementTypeId;

        public _FormStatementTransactionsDetails(int? _id, int _statementTypeId, MainFormController _controller)
        {
            InitializeComponent();

            this.id = _id;
            this.statementTypeId = _statementTypeId;
            this.controller = _controller;
            this.lblTitle.Text = _id.HasValue ? "Editar linha" : "Adicionar linha";
        }

        private void _FormStatementTransactionsDetails_Load(object sender, EventArgs e)
        {
            FillComboBox();

            if (id.HasValue) LoadData(id.Value);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            _FormCategory formCategory = new _FormCategory(controller);

            if (formCategory.ShowDialog() == DialogResult.OK)
            {
                FillComboBox();
            }

            formCategory.Dispose();
        }

        #region "subroutines"

        private void FillComboBox()
        {
            comboCategory.Items.Clear();

            categoryList = controller.GetCategoryList();

            if (categoryList != null && categoryList.Count > 0)
            {
                comboCategory.Items.AddRange(categoryList.Select(c => c.Description).ToArray());
            }
        }

        private void LoadData(int id) 
        {
            StatementDto? statementDto = controller.GetStatement(id);

            if (statementDto == null) return;

            this.datePickerTransaction.Value = statementDto.TransactionDate ?? DateTime.Today;
            this.datePickerDue.Value = statementDto.DueDate ?? DateTime.Today;
            this.numAmount.Value = statementDto.Amount ?? 0;
            this.txtDescription.Text = statementDto.Description ?? "";
            this.comboCategory.Text = ComboBoxHelper.GetDescription(categoryList ?? new(), statementDto.EntryId ?? 0);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StatementDto statementDto = new StatementDto();

            statementDto.Id = this.id;
            statementDto.TransactionDate = datePickerTransaction.Value == DateTime.MinValue ? null : datePickerTransaction.Value;
            statementDto.DueDate = datePickerDue.Value == DateTime.MinValue ? null : datePickerDue.Value;
			statementDto.Amount = numAmount.Value;
			statementDto.Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text;
            statementDto.EntryId = ComboBoxHelper.GetId(categoryList ?? new(), comboCategory.Text);
            statementDto.StatementTypeId = this.statementTypeId;

            SaveResult saveResult = controller.SaveStatement(statementDto);

            MessageBox.Show(saveResult.Message);

            if (saveResult.Success) 
            { 
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

        #endregion
    }
}
