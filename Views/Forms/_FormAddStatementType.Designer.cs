namespace ControleFinanceiroDesktop.Views
{
    partial class _FormAddStatementType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_FormAddStatementType));
            panelHeader = new Panel();
            lblTitle = new Label();
            panelTools = new Panel();
            buttonSave = new Button();
            textBox = new TextBox();
            panelHeader.SuspendLayout();
            panelTools.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackgroundImage = (Image)resources.GetObject("panelHeader.BackgroundImage");
            panelHeader.BackgroundImageLayout = ImageLayout.Stretch;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Location = new Point(-6, -2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(456, 46);
            panelHeader.TabIndex = 1;
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
            panelTools.Location = new Point(-3, 43);
            panelTools.Name = "panelTools";
            panelTools.Size = new Size(450, 36);
            panelTools.TabIndex = 2;
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
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Font = new Font("Segoe UI", 14F);
            textBox.Location = new Point(14, 97);
            textBox.Name = "textBox";
            textBox.Size = new Size(417, 32);
            textBox.TabIndex = 3;
            // 
            // _FormAddStatementType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(444, 141);
            Controls.Add(textBox);
            Controls.Add(panelHeader);
            Controls.Add(panelTools);
            Name = "_FormAddStatementType";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelTools.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelTools;
        private Button buttonSave;
        private TextBox textBox;
    }
}