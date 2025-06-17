using ControleFinanceiroDesktop.Controllers;

namespace ControleFinanceiroDesktop.Views
{
    public partial class _FormAddStatementType : Form
    {
        public int id = 0;

        private readonly MainFormController _controller;
        
        public _FormAddStatementType(MainFormController controller, int? _id = null)
        {
            InitializeComponent();

            _controller = controller;

            if (_id.HasValue)
            {
                id = _id.Value;
            
                this.lblTitle.Text = "Alterar";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string description = this.textBox.Text;

            var result = _controller.SaveStatementType(description, id);

            MessageBox.Show(result.Message);

            if (result.Success)
            {
                id = result.Id ?? 0;
                
                this.DialogResult = DialogResult.OK;
                
                this.Close();
            }
        }
    }
}
