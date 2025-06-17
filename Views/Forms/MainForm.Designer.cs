namespace ControleFinanceiroDesktop
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelHeader = new Panel();
            flowBtnConteiner = new FlowLayoutPanel();
            btnExtrato = new Button();
            btnModeloCartao = new Button();
            btnAdd = new Button();
            panelSeparator = new Panel();
            btnResumo = new Button();
            panelBody = new Panel();
            panel1 = new Panel();
            btnEdit = new Button();
            btnDelete = new Button();
            panel2 = new Panel();
            labelTitle = new Label();
            buttonRefresh = new Button();
            datePickerEndDate = new DateTimePicker();
            labelEndDate = new Label();
            datePickerStartDate = new DateTimePicker();
            labelStartDate = new Label();
            panelHeader.SuspendLayout();
            flowBtnConteiner.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.Green;
            panelHeader.BackgroundImage = (Image)resources.GetObject("panelHeader.BackgroundImage");
            panelHeader.BackgroundImageLayout = ImageLayout.Stretch;
            panelHeader.Controls.Add(flowBtnConteiner);
            panelHeader.Controls.Add(panelSeparator);
            panelHeader.Controls.Add(btnResumo);
            panelHeader.Location = new Point(-7, -3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1128, 66);
            panelHeader.TabIndex = 0;
            // 
            // flowBtnConteiner
            // 
            flowBtnConteiner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowBtnConteiner.BackColor = Color.Transparent;
            flowBtnConteiner.Controls.Add(btnExtrato);
            flowBtnConteiner.Controls.Add(btnModeloCartao);
            flowBtnConteiner.Controls.Add(btnAdd);
            flowBtnConteiner.Location = new Point(106, 2);
            flowBtnConteiner.Name = "flowBtnConteiner";
            flowBtnConteiner.Size = new Size(1019, 64);
            flowBtnConteiner.TabIndex = 5;
            // 
            // btnExtrato
            // 
            btnExtrato.BackColor = Color.Transparent;
            btnExtrato.Cursor = Cursors.Hand;
            btnExtrato.FlatAppearance.BorderSize = 0;
            btnExtrato.FlatStyle = FlatStyle.Flat;
            btnExtrato.Font = new Font("Segoe UI", 12F);
            btnExtrato.ForeColor = Color.White;
            btnExtrato.Image = (Image)resources.GetObject("btnExtrato.Image");
            btnExtrato.ImageAlign = ContentAlignment.TopCenter;
            btnExtrato.Location = new Point(3, 3);
            btnExtrato.Name = "btnExtrato";
            btnExtrato.Size = new Size(82, 60);
            btnExtrato.TabIndex = 2;
            btnExtrato.Tag = "0";
            btnExtrato.Text = "Extrato";
            btnExtrato.TextAlign = ContentAlignment.BottomCenter;
            btnExtrato.UseVisualStyleBackColor = false;
            // 
            // btnModeloCartao
            // 
            btnModeloCartao.BackColor = Color.Transparent;
            btnModeloCartao.Cursor = Cursors.Hand;
            btnModeloCartao.FlatAppearance.BorderSize = 0;
            btnModeloCartao.FlatStyle = FlatStyle.Flat;
            btnModeloCartao.Font = new Font("Segoe UI", 12F);
            btnModeloCartao.ForeColor = Color.White;
            btnModeloCartao.Image = (Image)resources.GetObject("btnModeloCartao.Image");
            btnModeloCartao.ImageAlign = ContentAlignment.TopCenter;
            btnModeloCartao.Location = new Point(91, 3);
            btnModeloCartao.Name = "btnModeloCartao";
            btnModeloCartao.Size = new Size(130, 60);
            btnModeloCartao.TabIndex = 3;
            btnModeloCartao.Text = "Cartão Modelo";
            btnModeloCartao.TextAlign = ContentAlignment.BottomCenter;
            btnModeloCartao.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(227, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(39, 58);
            btnAdd.TabIndex = 4;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelSeparator
            // 
            panelSeparator.Location = new Point(100, 10);
            panelSeparator.Name = "panelSeparator";
            panelSeparator.Size = new Size(4, 49);
            panelSeparator.TabIndex = 1;
            // 
            // btnResumo
            // 
            btnResumo.BackColor = Color.Transparent;
            btnResumo.Cursor = Cursors.Hand;
            btnResumo.FlatAppearance.BorderSize = 0;
            btnResumo.FlatStyle = FlatStyle.Flat;
            btnResumo.Font = new Font("Segoe UI", 12F);
            btnResumo.ForeColor = Color.White;
            btnResumo.Image = (Image)resources.GetObject("btnResumo.Image");
            btnResumo.ImageAlign = ContentAlignment.TopCenter;
            btnResumo.Location = new Point(13, 4);
            btnResumo.Name = "btnResumo";
            btnResumo.Size = new Size(82, 60);
            btnResumo.TabIndex = 0;
            btnResumo.Tag = "-1";
            btnResumo.Text = "Resumo";
            btnResumo.TextAlign = ContentAlignment.BottomCenter;
            btnResumo.UseVisualStyleBackColor = false;
            // 
            // panelBody
            // 
            panelBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelBody.BackgroundImage = (Image)resources.GetObject("panelBody.BackgroundImage");
            panelBody.BackgroundImageLayout = ImageLayout.Stretch;
            panelBody.Location = new Point(-5, 99);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1126, 475);
            panelBody.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(datePickerEndDate);
            panel1.Controls.Add(labelEndDate);
            panel1.Controls.Add(datePickerStartDate);
            panel1.Controls.Add(labelStartDate);
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(-4, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 39);
            panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.Location = new Point(1041, -4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(38, 49);
            btnEdit.TabIndex = 9;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(1085, -4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(38, 49);
            btnDelete.TabIndex = 8;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Visible = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Location = new Point(523, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(4, 25);
            panel2.TabIndex = 7;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(537, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(72, 21);
            labelTitle.TabIndex = 6;
            labelTitle.Text = "labelTitle";
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.Transparent;
            buttonRefresh.Cursor = Cursors.Hand;
            buttonRefresh.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Image = (Image)resources.GetObject("buttonRefresh.Image");
            buttonRefresh.Location = new Point(482, -4);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(38, 49);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // datePickerEndDate
            // 
            datePickerEndDate.CustomFormat = "";
            datePickerEndDate.Format = DateTimePickerFormat.Short;
            datePickerEndDate.Location = new Point(347, 5);
            datePickerEndDate.Name = "datePickerEndDate";
            datePickerEndDate.Size = new Size(129, 29);
            datePickerEndDate.TabIndex = 3;
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(257, 8);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(79, 21);
            labelEndDate.TabIndex = 2;
            labelEndDate.Text = "Data Final";
            // 
            // datePickerStartDate
            // 
            datePickerStartDate.CustomFormat = "";
            datePickerStartDate.Format = DateTimePickerFormat.Short;
            datePickerStartDate.Location = new Point(113, 5);
            datePickerStartDate.Name = "datePickerStartDate";
            datePickerStartDate.Size = new Size(129, 29);
            datePickerStartDate.TabIndex = 1;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(17, 8);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(86, 21);
            labelStartDate.TabIndex = 0;
            labelStartDate.Text = "Data Inicial";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1118, 570);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Controls.Add(panelBody);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panelHeader.ResumeLayout(false);
            flowBtnConteiner.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
		private Button btnResumo;
		private Panel panelSeparator;
		private Button btnExtrato;
		private Button btnModeloCartao;
		private Button btnAdd;
		private FlowLayoutPanel flowBtnConteiner;
		private Panel panelBody;
        private Panel panel1;
        private Label labelStartDate;
        private Button buttonRefresh;
        private Label labelEndDate;
        private Panel panel2;
        private Label labelTitle;
        private Button btnDelete;
        private Button btnEdit;
        public DateTimePicker datePickerStartDate;
        public DateTimePicker datePickerEndDate;
    }
}
