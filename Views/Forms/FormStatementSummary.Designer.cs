namespace ControleFinanceiroDesktop.Views
{
    partial class FormStatementSummary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvSummary = new DataGridView();
            colCredits = new DataGridViewTextBoxColumn();
            colDebits = new DataGridViewTextBoxColumn();
            colBalance = new DataGridViewTextBoxColumn();
            panelBody = new Panel();
            lblBotton = new Label();
            panelDebits = new Panel();
            dgvDebits = new DataGridView();
            colCategoryDebits = new DataGridViewTextBoxColumn();
            colAmountDebits = new DataGridViewTextBoxColumn();
            colPercentageDebits = new DataGridViewTextBoxColumn();
            label3 = new Label();
            panelCredits = new Panel();
            dgvCredits = new DataGridView();
            colCategory = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colPercentage = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            panelBody.SuspendLayout();
            panelDebits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDebits).BeginInit();
            panelCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCredits).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSummary
            // 
            dgvSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSummary.BackgroundColor = Color.White;
            dgvSummary.BorderStyle = BorderStyle.None;
            dgvSummary.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSummary.ColumnHeadersHeight = 30;
            dgvSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSummary.Columns.AddRange(new DataGridViewColumn[] { colCredits, colDebits, colBalance });
            dgvSummary.Location = new Point(-3, 25);
            dgvSummary.Name = "dgvSummary";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSummary.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSummary.RowHeadersVisible = false;
            dgvSummary.RowTemplate.Height = 30;
            dgvSummary.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvSummary.Size = new Size(867, 57);
            dgvSummary.TabIndex = 1;
            // 
            // colCredits
            // 
            colCredits.HeaderText = "Entradas";
            colCredits.Name = "colCredits";
            // 
            // colDebits
            // 
            colDebits.HeaderText = "Saídas";
            colDebits.Name = "colDebits";
            // 
            // colBalance
            // 
            colBalance.HeaderText = "Diferença";
            colBalance.Name = "colBalance";
            // 
            // panelBody
            // 
            panelBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBody.AutoScroll = true;
            panelBody.BackColor = Color.White;
            panelBody.Controls.Add(lblBotton);
            panelBody.Controls.Add(panelDebits);
            panelBody.Controls.Add(panelCredits);
            panelBody.Controls.Add(panel2);
            panelBody.Location = new Point(-1, 0);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(925, 481);
            panelBody.TabIndex = 2;
            // 
            // lblBotton
            // 
            lblBotton.AutoSize = true;
            lblBotton.ForeColor = Color.White;
            lblBotton.Location = new Point(31, 270);
            lblBotton.Name = "lblBotton";
            lblBotton.Size = new Size(19, 21);
            lblBotton.TabIndex = 5;
            lblBotton.Text = "...";
            // 
            // panelDebits
            // 
            panelDebits.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDebits.BackColor = Color.FromArgb(235, 235, 235);
            panelDebits.BorderStyle = BorderStyle.FixedSingle;
            panelDebits.Controls.Add(dgvDebits);
            panelDebits.Controls.Add(label3);
            panelDebits.Location = new Point(28, 195);
            panelDebits.Name = "panelDebits";
            panelDebits.Size = new Size(863, 58);
            panelDebits.TabIndex = 4;
            // 
            // dgvDebits
            // 
            dgvDebits.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDebits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDebits.BackgroundColor = Color.White;
            dgvDebits.BorderStyle = BorderStyle.None;
            dgvDebits.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDebits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDebits.ColumnHeadersHeight = 30;
            dgvDebits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDebits.Columns.AddRange(new DataGridViewColumn[] { colCategoryDebits, colAmountDebits, colPercentageDebits });
            dgvDebits.Location = new Point(-3, 27);
            dgvDebits.Name = "dgvDebits";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDebits.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDebits.RowHeadersVisible = false;
            dgvDebits.RowTemplate.Height = 30;
            dgvDebits.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvDebits.Size = new Size(867, 31);
            dgvDebits.TabIndex = 1;
            // 
            // colCategoryDebits
            // 
            colCategoryDebits.HeaderText = "Categoria";
            colCategoryDebits.Name = "colCategoryDebits";
            // 
            // colAmountDebits
            // 
            colAmountDebits.HeaderText = "Valor";
            colAmountDebits.Name = "colAmountDebits";
            // 
            // colPercentageDebits
            // 
            colPercentageDebits.HeaderText = "%";
            colPercentageDebits.Name = "colPercentageDebits";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(354, 3);
            label3.Name = "label3";
            label3.Size = new Size(147, 21);
            label3.TabIndex = 2;
            label3.Text = "Resumo de Saídas";
            // 
            // panelCredits
            // 
            panelCredits.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCredits.BackColor = Color.FromArgb(235, 235, 235);
            panelCredits.BorderStyle = BorderStyle.FixedSingle;
            panelCredits.Controls.Add(dgvCredits);
            panelCredits.Controls.Add(label2);
            panelCredits.Location = new Point(28, 118);
            panelCredits.Name = "panelCredits";
            panelCredits.Size = new Size(863, 58);
            panelCredits.TabIndex = 3;
            // 
            // dgvCredits
            // 
            dgvCredits.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCredits.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCredits.BackgroundColor = Color.White;
            dgvCredits.BorderStyle = BorderStyle.None;
            dgvCredits.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCredits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCredits.ColumnHeadersHeight = 30;
            dgvCredits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCredits.Columns.AddRange(new DataGridViewColumn[] { colCategory, colAmount, colPercentage });
            dgvCredits.Location = new Point(-3, 27);
            dgvCredits.Name = "dgvCredits";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvCredits.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvCredits.RowHeadersVisible = false;
            dgvCredits.RowTemplate.Height = 30;
            dgvCredits.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvCredits.ScrollBars = ScrollBars.None;
            dgvCredits.Size = new Size(867, 31);
            dgvCredits.TabIndex = 1;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Categoria";
            colCategory.Name = "colCategory";
            // 
            // colAmount
            // 
            colAmount.HeaderText = "Valor";
            colAmount.Name = "colAmount";
            // 
            // colPercentage
            // 
            colPercentage.HeaderText = "%";
            colPercentage.Name = "colPercentage";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(343, 3);
            label2.Name = "label2";
            label2.Size = new Size(164, 21);
            label2.TabIndex = 2;
            label2.Text = "Resumo de Entradas";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(235, 235, 235);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dgvSummary);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(28, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 84);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 2);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 2;
            label1.Text = "Resumo Geral";
            // 
            // FormStatementSummary
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(923, 480);
            Controls.Add(panelBody);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormStatementSummary";
            Load += FormStatementSummary_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            panelDebits.ResumeLayout(false);
            panelDebits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDebits).EndInit();
            panelCredits.ResumeLayout(false);
            panelCredits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCredits).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSummary;
		private Panel panelBody;
		private DataGridViewTextBoxColumn colCredits;
		private DataGridViewTextBoxColumn colDebits;
		private DataGridViewTextBoxColumn colBalance;
		private Panel panel2;
        private Label label1;
        private Panel panelCredits;
        private DataGridView dgvCredits;
        private Label label2;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colPercentage;
        private Panel panelDebits;
        private DataGridView dgvDebits;
        private Label label3;
        private DataGridViewTextBoxColumn colCategoryDebits;
        private DataGridViewTextBoxColumn colAmountDebits;
        private DataGridViewTextBoxColumn colPercentageDebits;
        private Label lblBotton;
    }
}