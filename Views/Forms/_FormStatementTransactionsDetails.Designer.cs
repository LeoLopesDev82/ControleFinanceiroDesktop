namespace ControleFinanceiroDesktop.Views
{
    partial class _FormStatementTransactionsDetails
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormStatementTransactionsDetails));
			panelHeader = new Panel();
			lblTitle = new Label();
			label1 = new Label();
			datePickerTransaction = new DateTimePicker();
			panelTools = new Panel();
			buttonSave = new Button();
			datePickerDue = new DateTimePicker();
			label2 = new Label();
			txtDescription = new TextBox();
			label3 = new Label();
			comboCategory = new ComboBox();
			label4 = new Label();
			numAmount = new NumericUpDown();
			label5 = new Label();
			btnAddCategory = new Button();
			panelHeader.SuspendLayout();
			panelTools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
			SuspendLayout();
			// 
			// panelHeader
			// 
			panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			panelHeader.BackgroundImage = (Image)resources.GetObject("panelHeader.BackgroundImage");
			panelHeader.BackgroundImageLayout = ImageLayout.Stretch;
			panelHeader.Controls.Add(lblTitle);
			panelHeader.Location = new Point(-3, -1);
			panelHeader.Name = "panelHeader";
			panelHeader.Size = new Size(1133, 46);
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
			lblTitle.Size = new Size(69, 25);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "lblTitle";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 94);
			label1.Name = "label1";
			label1.Size = new Size(126, 21);
			label1.TabIndex = 3;
			label1.Text = "Data Movimento";
			// 
			// datePickerTransaction
			// 
			datePickerTransaction.CustomFormat = "";
			datePickerTransaction.Format = DateTimePickerFormat.Short;
			datePickerTransaction.Location = new Point(16, 118);
			datePickerTransaction.Name = "datePickerTransaction";
			datePickerTransaction.Size = new Size(137, 29);
			datePickerTransaction.TabIndex = 4;
			// 
			// panelTools
			// 
			panelTools.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			panelTools.BackColor = Color.Gainsboro;
			panelTools.Controls.Add(buttonSave);
			panelTools.Font = new Font("Segoe UI", 12F);
			panelTools.Location = new Point(-4, 44);
			panelTools.Name = "panelTools";
			panelTools.Size = new Size(1131, 36);
			panelTools.TabIndex = 5;
			// 
			// buttonSave
			// 
			buttonSave.BackColor = Color.Transparent;
			buttonSave.FlatAppearance.BorderSize = 0;
			buttonSave.FlatStyle = FlatStyle.Flat;
			buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
			buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
			buttonSave.Location = new Point(8, 0);
			buttonSave.Name = "buttonSave";
			buttonSave.Size = new Size(93, 36);
			buttonSave.TabIndex = 0;
			buttonSave.Text = "Salvar";
			buttonSave.TextAlign = ContentAlignment.MiddleRight;
			buttonSave.UseVisualStyleBackColor = false;
			buttonSave.Click += buttonSave_Click;
			// 
			// datePickerDue
			// 
			datePickerDue.CustomFormat = "";
			datePickerDue.Format = DateTimePickerFormat.Short;
			datePickerDue.Location = new Point(159, 118);
			datePickerDue.Name = "datePickerDue";
			datePickerDue.Size = new Size(137, 29);
			datePickerDue.TabIndex = 7;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(159, 94);
			label2.Name = "label2";
			label2.Size = new Size(128, 21);
			label2.TabIndex = 6;
			label2.Text = "Data Vencimento";
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(302, 118);
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(328, 29);
			txtDescription.TabIndex = 8;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(302, 94);
			label3.Name = "label3";
			label3.Size = new Size(72, 21);
			label3.TabIndex = 9;
			label3.Text = "Histórico";
			// 
			// comboCategory
			// 
			comboCategory.FormattingEnabled = true;
			comboCategory.Location = new Point(636, 118);
			comboCategory.Name = "comboCategory";
			comboCategory.Size = new Size(308, 29);
			comboCategory.TabIndex = 10;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(636, 94);
			label4.Name = "label4";
			label4.Size = new Size(77, 21);
			label4.TabIndex = 11;
			label4.Text = "Categoria";
			// 
			// numAmount
			// 
			numAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			numAmount.Location = new Point(970, 118);
			numAmount.Maximum = new decimal(new int[] { 3000000, 0, 0, 0 });
			numAmount.Minimum = new decimal(new int[] { 3000000, 0, 0, int.MinValue });
			numAmount.Name = "numAmount";
			numAmount.Size = new Size(137, 29);
			numAmount.TabIndex = 12;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(970, 94);
			label5.Name = "label5";
			label5.Size = new Size(46, 21);
			label5.TabIndex = 13;
			label5.Text = "Valor";
			// 
			// btnAddCategory
			// 
			btnAddCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAddCategory.BackColor = Color.Transparent;
			btnAddCategory.Cursor = Cursors.Hand;
			btnAddCategory.FlatAppearance.BorderColor = Color.DarkOliveGreen;
			btnAddCategory.FlatAppearance.BorderSize = 0;
			btnAddCategory.FlatStyle = FlatStyle.Flat;
			btnAddCategory.Image = (Image)resources.GetObject("btnAddCategory.Image");
			btnAddCategory.Location = new Point(938, 118);
			btnAddCategory.Name = "btnAddCategory";
			btnAddCategory.Size = new Size(38, 29);
			btnAddCategory.TabIndex = 14;
			btnAddCategory.UseVisualStyleBackColor = false;
			btnAddCategory.Click += btnAddCategory_Click;
			// 
			// _FormStatementTransactionsDetails
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1122, 165);
			Controls.Add(label5);
			Controls.Add(numAmount);
			Controls.Add(label4);
			Controls.Add(comboCategory);
			Controls.Add(label3);
			Controls.Add(txtDescription);
			Controls.Add(datePickerDue);
			Controls.Add(label2);
			Controls.Add(datePickerTransaction);
			Controls.Add(label1);
			Controls.Add(panelHeader);
			Controls.Add(panelTools);
			Controls.Add(btnAddCategory);
			Font = new Font("Segoe UI", 12F);
			Margin = new Padding(4);
			Name = "_FormStatementTransactionsDetails";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Load += _FormStatementTransactionsDetails_Load;
			panelHeader.ResumeLayout(false);
			panelHeader.PerformLayout();
			panelTools.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panelHeader;
        private Label lblTitle;
        private Label label1;
        private DateTimePicker datePickerTransaction;
        private Panel panelTools;
        private Button buttonSave;
        private DateTimePicker datePickerDue;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private ComboBox comboCategory;
        private Label label4;
        private NumericUpDown numAmount;
        private Label label5;
        private Button btnAddCategory;
    }
}