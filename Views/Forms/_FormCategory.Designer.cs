namespace ControleFinanceiroDesktop.Views
{
    partial class _FormCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormCategory));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblTitle = new Label();
            panel2 = new Panel();
            btnDelete = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            dgv = new DataGridView();
            IdCol = new DataGridViewTextBoxColumn();
            categoryCol = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackgroundImage = (Image)resources.GetObject("panelHeader.BackgroundImage");
            panelHeader.BackgroundImageLayout = ImageLayout.Stretch;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(-4, -1);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(624, 46);
            panelHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 14F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(102, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Categorias";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Location = new Point(424, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 25);
            panel2.TabIndex = 18;
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
            btnDelete.Location = new Point(288, 42);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 35);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Excluir linha";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            btnAdd.Location = new Point(16, 42);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 35);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Incluir linha";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            btnEdit.Location = new Point(152, 42);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(130, 35);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Editar linha";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.Columns.AddRange(new DataGridViewColumn[] { IdCol, categoryCol });
            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.Location = new Point(-2, 77);
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
            dgv.Size = new Size(622, 361);
            dgv.TabIndex = 19;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            // 
            // IdCol
            // 
            IdCol.HeaderText = "ID";
            IdCol.Name = "IdCol";
            IdCol.Visible = false;
            // 
            // categoryCol
            // 
            categoryCol.HeaderText = "Categoria";
            categoryCol.Name = "categoryCol";
            // 
            // _FormCategory
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            ClientSize = new Size(615, 429);
            Controls.Add(dgv);
            Controls.Add(panelHeader);
            Controls.Add(panel2);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "_FormCategory";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += _FormCategory_FormClosing;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panel2;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewTextBoxColumn categoryCol;
    }
}