using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinForms
{
    public partial class UserForm : Form
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public UserForm()
        {
            InitializeComponent();
        }

        private void bnOk_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            LastName = txtLastName.Text;
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            string lastName = txtLastName.Text;
            bool valid = !string.IsNullOrWhiteSpace(lastName);
            if (valid)
            {
                ctlErrorProvider.SetError(txtLastName, string.Empty);
                e.Cancel = false;
            }
            else
            {
                ctlErrorProvider.SetError(txtLastName, "Ойойой");
                e.Cancel = true;
            }
        }
    }
}
