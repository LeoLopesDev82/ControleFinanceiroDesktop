using ControleFinanceiroDesktop.Views.ViewHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiroDesktop.Views
{
	public partial class FormStatementSummary : Form
	{
		MainForm mainForm;

        int defaultDifference;

		public FormStatementSummary(MainForm _mainForm)
		{
			InitializeComponent();

            this.defaultDifference = this.panelCredits.Height - this.dgvCredits.Height;
			this.mainForm = _mainForm;
		}

		private void FormStatementSummary_Load(object sender, EventArgs e)
        {
            FillDgvSummary();
            FillDgvCredits();
            FillDgvDebits();
        }

        #region "subroutines"

        private void FillDgvSummary()
        {
            dgvSummary.Rows.Add(mainForm.model.SummaryDto.Credits, mainForm.model.SummaryDto.Debits, mainForm.model.SummaryDto.Balance);

            new DataGridViewHelper(dgvSummary);
        }

        private void FillDgvCredits()
        {
            foreach (var item in mainForm.model.CreditSummaries)
            {
                dgvCredits.Rows.Add(item.Category, item.Amount, item.Percentage + "%");
            }

            new DataGridViewHelper(dgvCredits);

            ResizeDataGridView(dgvCredits);

            panelCredits.Height = this.dgvCredits.Height + this.defaultDifference;
            panelDebits.Top = this.panelCredits.Top + this.panelCredits.Height + 20;
        }


        private void FillDgvDebits()
        {
            foreach (var item in mainForm.model.DebitSummaries)
            {
                dgvDebits.Rows.Add(item.Category, item.Amount, item.Percentage + "%");
            }

            new DataGridViewHelper(dgvDebits);

            ResizeDataGridView(dgvDebits);

            panelDebits.Height = this.dgvDebits.Height + this.defaultDifference;
            lblBotton.Top = this.panelDebits.Top + panelDebits.Height + 20;
        }


        private void ResizeDataGridView(DataGridView dgv) 
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Visible)
                {
                    dgv.Height += row.Height;
                }
            }
        }

        #endregion

    }
}
