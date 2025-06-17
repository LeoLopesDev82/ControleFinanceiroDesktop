using ControleFinanceiroDesktop.Models.DTOs;
using ControleFinanceiroDesktop.Models.ViewModels;
using ControleFinanceiroDesktop.Views.ViewHelpers;

namespace ControleFinanceiroDesktop.Views
{
    public partial class FormStatementTransactions : Form
    {
        MainForm mainForm;

        MainFormModel model;

        public FormStatementTransactions(MainForm _mainForm)
        {
            InitializeComponent();

            mainForm = _mainForm;
            model = _mainForm.model;
        }

        private void FormStatementTransactions_Load(object sender, EventArgs e)
        {
            dgv.Rows.Clear();

            foreach (StatementGridDto item in model.statementDtos)
            {
                dgv.Rows.Add(
                    item.Id,
                    item.TransactionDate?.ToString("dd/MM/yyyy"),
                    item.DueDate?.ToString("dd/MM/yyyy"),
                    item.Description,
                    item.EntryDescription ?? "",
                    item.Amount?.ToString("N2")
                );
            }

            new DataGridViewHelper(dgv);

            ColorAmountColumn();
            HighlightDuplicateRows();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFormStatementTransactionsDetails(null);
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int? id = GetGridId();

            if (id.HasValue) OpenFormStatementTransactionsDetails(id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int? id = GetGridId();

            if (id.HasValue)
            {
                DialogResult result = MessageBox.Show("Atenção: excluir registro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var delete = this.mainForm._controller.DeleteStatement(id.Value);

                    MessageBox.Show(delete.Message);

                    if (delete.Success) mainForm.RefreshApplication();
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "A planilha deve ter o seguinte formato:\n\n" +
                "- Coluna A: Data da Transação\n" +
                "- Coluna B: Data de Vencimento\n" +
                "- Coluna C: Descrição (até 255 caracteres)\n" +
                "- Coluna D: Valor (decimal)\n\n" +
                "⚠ A primeira linha (cabeçalho) será ignorada automaticamente.\n" +
                "📄 Uma planilha modelo está disponível na solução do projeto para referência.\n\n" +
                "Certifique-se de que todas as células estão preenchidas corretamente antes de importar.",
                "Formato da Planilha",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos Excel (*.xlsx)|*.xlsx";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    var result = mainForm._controller.ImportExcel(filePath, mainForm.Id);

                    MessageBox.Show(result.Message);

                    if (result.Success) mainForm.RefreshApplication();
                }
            }
        }

        private void btnTagCategories_Click(object sender, EventArgs e)
        {
            bool success = mainForm._controller.Reidentify(mainForm.datePickerStartDate.Value, mainForm.datePickerEndDate.Value);

            if (success)
            {
                MessageBox.Show("Registros identificados com sucesso!");

                mainForm.RefreshApplication();
            }
            else
            {
                MessageBox.Show("Algo deu errado!");
            }
        }

        #region "subroutines"

        private int? GetGridId()
        {
            if (dgv.CurrentRow != null)
            {
                var cellValue = dgv.CurrentRow.Cells[0].Value;

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                {
                    return id;
                }
                else
                {
                    MessageBox.Show("Selecione um item válido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            return null;
        }

        private void OpenFormStatementTransactionsDetails(int? id)
        {
            _FormStatementTransactionsDetails form = new(id, mainForm.Id, mainForm._controller);

            if (form.ShowDialog() == DialogResult.OK)
            {
                mainForm.RefreshApplication();
            }

            form.Dispose();
        }

        private void ColorAmountColumn()
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                var cell = row.Cells[5];

                if (decimal.TryParse(cell.Value.ToString(), out decimal value))
                {
                    if (value < 0)
                        cell.Style.BackColor = Color.FromArgb(255, 230, 230);
                    else if (value > 0)
                        cell.Style.BackColor = Color.FromArgb(230, 240, 255);
                }
            }
        }

        private void HighlightDuplicateRows()
        {
            var duplicates = new Dictionary<string, List<DataGridViewRow>>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                string transactionDate = row.Cells[1].Value?.ToString() ?? "";
                string description = row.Cells[3].Value?.ToString()?.Trim() ?? "";
                string amount = row.Cells[5].Value?.ToString() ?? "";
                string key = $"{transactionDate}|{description}|{amount}";

                if (!duplicates.ContainsKey(key)) duplicates[key] = new List<DataGridViewRow>();

                duplicates[key].Add(row);
            }

            foreach (var group in duplicates.Values)
            {
                if (group.Count <= 1) continue; 

                foreach (var row in group)
                {
                    row.Cells[1].Style.BackColor = Color.Red;
                    row.Cells[3].Style.BackColor = Color.Red;

                    row.Cells[1].Style.ForeColor = Color.White;
                    row.Cells[3].Style.ForeColor = Color.White;
                }
            }
        }


        #endregion

    }
}
