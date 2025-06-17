namespace ControleFinanceiroDesktop.Views.Forms
{
    partial class _FormCategoryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormCategoryDetails));
            panel1 = new Panel();
            rdbVariable = new RadioButton();
            rdbFixed = new RadioButton();
            txtDescription = new TextBox();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelTools = new Panel();
            buttonSave = new Button();
            label1 = new Label();
            panel2 = new Panel();
            txtIdentifiers = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panelHeader.SuspendLayout();
            panelTools.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(rdbVariable);
            panel1.Controls.Add(rdbFixed);
            panel1.Location = new Point(18, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 55);
            panel1.TabIndex = 11;
            // 
            // rdbVariable
            // 
            rdbVariable.AutoSize = true;
            rdbVariable.Location = new Point(253, 13);
            rdbVariable.Name = "rdbVariable";
            rdbVariable.Size = new Size(83, 25);
            rdbVariable.TabIndex = 1;
            rdbVariable.TabStop = true;
            rdbVariable.Text = "Variável";
            rdbVariable.UseVisualStyleBackColor = true;
            // 
            // rdbFixed
            // 
            rdbFixed.AutoSize = true;
            rdbFixed.Location = new Point(51, 13);
            rdbFixed.Name = "rdbFixed";
            rdbFixed.Size = new Size(56, 25);
            rdbFixed.TabIndex = 0;
            rdbFixed.TabStop = true;
            rdbFixed.Text = "Fixo";
            rdbFixed.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Font = new Font("Segoe UI", 14F);
            txtDescription.Location = new Point(18, 199);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(405, 32);
            txtDescription.TabIndex = 10;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackgroundImage = (Image)resources.GetObject("panelHeader.BackgroundImage");
            panelHeader.BackgroundImageLayout = ImageLayout.Stretch;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(-5, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(446, 46);
            panelHeader.TabIndex = 8;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 14F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(24, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(93, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Adicionar";
            // 
            // panelTools
            // 
            panelTools.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTools.BackColor = Color.Gainsboro;
            panelTools.Controls.Add(buttonSave);
            panelTools.Font = new Font("Segoe UI", 12F);
            panelTools.Location = new Point(-2, 45);
            panelTools.Name = "panelTools";
            panelTools.Size = new Size(440, 36);
            panelTools.TabIndex = 9;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 88);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 12;
            label1.Text = "Tipo de lançamento";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Location = new Point(26, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 10);
            panel2.TabIndex = 13;
            // 
            // txtIdentifiers
            // 
            txtIdentifiers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIdentifiers.Font = new Font("Segoe UI", 14F);
            txtIdentifiers.Location = new Point(16, 258);
            txtIdentifiers.Multiline = true;
            txtIdentifiers.Name = "txtIdentifiers";
            txtIdentifiers.Size = new Size(407, 91);
            txtIdentifiers.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 175);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 15;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 234);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 16;
            label3.Text = "Identificadores";
            // 
            // _FormCategoryDetails
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(435, 370);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtIdentifiers);
            Controls.Add(panel1);
            Controls.Add(txtDescription);
            Controls.Add(panelHeader);
            Controls.Add(panelTools);
            Controls.Add(panel2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "_FormCategoryDetails";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += _FormCategoryDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelTools.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtDescription;
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelTools;
        private Button buttonSave;
        private Label label1;
        private Panel panel2;
        private RadioButton rdbVariable;
        private RadioButton rdbFixed;
        private TextBox txtIdentifiers;
        private Label label2;
        private Label label3;
    }
}