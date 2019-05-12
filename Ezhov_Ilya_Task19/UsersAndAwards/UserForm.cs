using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Entities;
using DAL.Memory;
using BLL.Logic;

namespace UsersAndAwards
{
    public partial class UserForm : Form
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Award> Awards { get; set; }
        public List<string> userAwardCollection = new List<string>();

        public UserForm()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }

        public UserForm(User userInWork)
        {
            InitializeComponent();

            FirstName = userInWork.FirstName;
            LastName = userInWork.LastName;
            BirthDate = userInWork.BirthDate;
            Awards = userInWork.Awards;
            AutoValidate = AutoValidate.Disable;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            tbFirstName.Text = FirstName;
            tbLastName.Text = LastName;
            tbBirthDate.Text = BirthDate.ToShortDateString();
            // creating awards list
            foreach (var award in MainForm.awardsList)
            {
                chbxUserAwardsBox.Items.Add(award.Title);
            }
            // checking awards, that user have already
            if (Awards != null)
            {
                foreach (var award in Awards)
                {
                    for (int i = 0; i < chbxUserAwardsBox.Items.Count; i++)
                    {
                        if (award.Title == chbxUserAwardsBox.Items[i]) // studio swearing at me, but it works :)
                        {
                            chbxUserAwardsBox.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void btnSaveChangesUser_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;

            Awards = new List<Award>();
            foreach (var award in MainForm.awardsList)
            {
                foreach (string awardName in chbxUserAwardsBox.CheckedItems)
                {
                    if (awardName == award.Title)
                    {
                        Awards.Add(award);
                    }
                }
            }
        }


        //Validating
        private void FirstName_Validated(object sender, EventArgs e)
        {
            FirstName = tbFirstName.Text.Trim();
        }
        private void FirstName_Validating(object sender, CancelEventArgs e)
        {
            if (tbFirstName.TextLength == 0 || tbFirstName.TextLength > 50)
            {
                errorProviderUF.SetError(tbFirstName, "Name can't be empty or contains more than 50 symbols.");
                e.Cancel = true;
            }
            else
            {
                errorProviderUF.SetError(tbFirstName, String.Empty);
                e.Cancel = false;
            }
        }

        private void LastName_Validated(object sender, EventArgs e)
        {
            LastName = tbLastName.Text.Trim();
        }
        private void LastName_Validating(object sender, CancelEventArgs e)
        {
            if (tbLastName.TextLength == 0 || tbLastName.TextLength > 50)
            {
                errorProviderUF.SetError(tbLastName, "Last Name can't be empty or contains more than 50 symbols.");
                e.Cancel = true;
            }
            else
            {
                errorProviderUF.SetError(tbLastName, String.Empty);
                e.Cancel = false;
            }
        }

        private void BirthDate_Validated(object sender, EventArgs e)
        {
            BirthDate = DateTime.Parse(tbBirthDate.Text.Trim());
        }
        private void BirthDate_Validating(object sender, CancelEventArgs e)
        {
            if (!DateTime.TryParse(tbBirthDate.Text.Trim(), out DateTime parsedBithDate) || parsedBithDate.Year < DateTime.Now.Year - 150 || parsedBithDate.Year > DateTime.Now.Year)
            {
                errorProviderUF.SetError(tbBirthDate, "Incorrect date input. Age can't be more than 150, and less than 0.");
                e.Cancel = true;
            }
            else
            {
                errorProviderUF.SetError(tbBirthDate, String.Empty);
                e.Cancel = false;
            }
        }

        //Cancel button
        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
