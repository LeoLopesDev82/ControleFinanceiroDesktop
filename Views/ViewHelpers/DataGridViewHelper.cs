using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiroDesktop.Views.ViewHelpers
{
    public class DataGridViewHelper
    {
        public DataGridViewHelper(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 235, 235);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 255, 220);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.DarkGray;

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(180, 240, 180);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            DrawHeaderBottomLine(dgv);
        }

        private static void DrawHeaderBottomLine(DataGridView dgv)
        {
            Panel bottomLinePanel = new Panel();

            bottomLinePanel.BackColor = Color.DarkGray;
            bottomLinePanel.Height = 1;
            bottomLinePanel.Width = 5000;

            bottomLinePanel.Location = new Point(-10, dgv.ColumnHeadersHeight);

            dgv.Controls.Add(bottomLinePanel);
        }
    }
}
