namespace ControleFinanceiroDesktop.Views
{
    partial class FormStatementTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatementTransactions));
            dgv = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            transactionDateCol = new DataGridViewTextBoxColumn();
            dueDateCol = new DataGridViewTextBoxColumn();
            descriptionCol = new DataGridViewTextBoxColumn();
            categoryCol = new DataGridViewTextBoxColumn();
            amountCol = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            panel2 = new Panel();
            btnExcel = new Button();
            btnTagCategories = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.Columns.AddRange(new DataGridViewColumn[] { IdCol, transactionDateCol, dueDateCol, descriptionCol, categoryCol, amountCol });
            dgv.Location = new Point(-2, 33);
            dgv.Name = "dgv";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 30;
            dgv.RowTemplate.Resizable = DataGridViewTriState.False;
            dgv.Size = new Size(973, 448);
            dgv.TabIndex = 0;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "ID";
            IdCol.Name = "IdCol";
            IdCol.Visible = false;
            // 
            // transactionDateCol
            // 
            transactionDateCol.HeaderText = "Data Movimento";
            transactionDateCol.Name = "transactionDateCol";
            // 
            // dueDateCol
            // 
            dueDateCol.HeaderText = "Data Vencimento";
            dueDateCol.Name = "dueDateCol";
            // 
            // descriptionCol
            // 
            descriptionCol.HeaderText = "Histórico";
            descriptionCol.Name = "descriptionCol";
            // 
            // categoryCol
            // 
            categoryCol.HeaderText = "Categoria";
            categoryCol.Name = "categoryCol";
            // 
            // amountCol
            // 
            amountCol.HeaderText = "Valor";
            amountCol.Name = "amountCol";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(144, -2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 35);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Editar linha";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(8, -2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 35);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Incluir linha";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(280, -2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 35);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Excluir linha";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Location = new Point(416, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 25);
            panel2.TabIndex = 13;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Transparent;
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Image = (Image)resources.GetObject("btnExcel.Image");
            btnExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcel.Location = new Point(424, -2);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(163, 35);
            btnExcel.TabIndex = 14;
            btnExcel.Text = "Exportar planilha";
            btnExcel.TextAlign = ContentAlignment.MiddleRight;
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnTagCategories
            // 
            btnTagCategories.BackColor = Color.Transparent;
            btnTagCategories.Cursor = Cursors.Hand;
            btnTagCategories.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnTagCategories.FlatAppearance.BorderSize = 0;
            btnTagCategories.FlatStyle = FlatStyle.Flat;
            btnTagCategories.Image = (Image)resources.GetObject("btnTagCategories.Image");
            btnTagCategories.ImageAlign = ContentAlignment.MiddleLeft;
            btnTagCategories.Location = new Point(593, -2);
            btnTagCategories.Name = "btnTagCategories";
            btnTagCategories.Size = new Size(154, 35);
            btnTagCategories.TabIndex = 15;
            btnTagCategories.Text = "Identificar itens";
            btnTagCategories.TextAlign = ContentAlignment.MiddleRight;
            btnTagCategories.UseVisualStyleBackColor = false;
            btnTagCategories.Click += btnTagCategories_Click;
            // 
            // FormStatementTransactions
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(968, 473);
            Controls.Add(btnTagCategories);
            Controls.Add(btnExcel);
            Controls.Add(panel2);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgv);
            Controls.Add(btnEdit);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormStatementTransactions";
            Load += FormStatementTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn transactionDateCol;
        private DataGridViewTextBoxColumn dueDateCol;
        private DataGridViewTextBoxColumn descriptionCol;
        private DataGridViewTextBoxColumn categoryCol;
        private DataGridViewTextBoxColumn amountCol;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDelete;
        private Panel panel2;
        private Button btnExcel;
        private Button btnTagCategories;
    }
}