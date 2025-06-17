using ControleFinanceiroDesktop.Controllers;
using ControleFinanceiroDesktop.Models.DTOs;
using ControleFinanceiroDesktop.Responses;

namespace ControleFinanceiroDesktop.Views.Forms
{
    public partial class _FormCategoryDetails : Form
    {
        int? id;

        MainFormController controller;

        public _FormCategoryDetails(int? _id, MainFormController _controller)
        {
            InitializeComponent();

            id = _id;
            controller = _controller;            
        }

        private void _FormCategoryDetails_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                LoadData(id.Value);
            }
        }

        private void LoadData(int id)
        {
            CategoryDto? dto = controller.GetCategory(id);

            if (dto != null) 
            {
                this.txtDescription.Text = dto.Description;
                this.txtIdentifiers.Text = dto.Identifiers;

                if (!string.IsNullOrWhiteSpace(dto.RadioName))
                {
                    var foundControls = this.Controls.Find(dto.RadioName, true);

                    if (foundControls.Length > 0 && foundControls[0] is RadioButton radio)
                    {
                        radio.Checked = true;
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string? selectedRadio = rdbFixed.Checked ? rdbFixed.Name : (rdbVariable.Checked ? rdbVariable.Name : null);
            string? description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text;
            string? identifiers = string.IsNullOrWhiteSpace(txtIdentifiers.Text) ? null : txtIdentifiers.Text;

            SaveResult result = controller.SaveCategoryDetails(id, description, selectedRadio, identifiers);

            MessageBox.Show(result.Message);

            if (result.Success) 
            {
                this.DialogResult = DialogResult.OK;

                this.Close();
            }               
        }

    }
}
