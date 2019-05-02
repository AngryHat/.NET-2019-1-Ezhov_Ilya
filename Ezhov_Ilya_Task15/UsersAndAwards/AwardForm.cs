using System;
using System.ComponentModel;
using System.Windows.Forms;
using Entities;

namespace UsersAndAwards
{
    public partial class AwardForm : Form
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public AwardForm()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }

        public AwardForm(Award awardInWork)
        {
            InitializeComponent();
            Title = awardInWork.Title;
            Description = awardInWork.Description;
            AutoValidate = AutoValidate.Disable;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            tbTitle.Text = Title;
            tbDescription.Text = Description;
        }

        private void btnSaveChangesUser_Click(object sender, EventArgs e)
        {
            Title = tbTitle.Text.Trim();
            Description = tbDescription.Text.Trim();
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
        }

        // validating
        private void Title_Validated(object sender, EventArgs e)
        {
            Title = tbTitle.Text.Trim();
        }

        private void Title_Validating(object sender, CancelEventArgs e)
        {
            if (tbTitle.Text.Trim().Length == 0 || tbTitle.Text.Trim().Length > 50)
            {
                errorProviderAF.SetError(tbTitle, "Title can't be empty or contains more than 50 symbols.");
                e.Cancel = true;
            }
            else
            {
                errorProviderAF.SetError(tbTitle, String.Empty);
                e.Cancel = false;
            }
        }

        private void Descrition_Validated(object sender, EventArgs e)
        {
            Description = tbDescription.Text.Trim();
        }

        private void Descrition_Validating(object sender, CancelEventArgs e)
        {
            if (tbDescription.Text.Trim().Length == 0 || tbDescription.Text.Trim().Length > 250)
            {
                errorProviderAF.SetError(tbDescription, "Description can't be empty or contains more than 250 symbols.");
                e.Cancel = true;
            }
            else
            {
                errorProviderAF.SetError(tbDescription, String.Empty);
                e.Cancel = false;
            }
        }
    }
}
