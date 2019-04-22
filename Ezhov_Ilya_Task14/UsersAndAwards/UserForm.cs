using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        public UserForm(User userInWork)
        {
            InitializeComponent();

            FirstName = userInWork.FirstName;
            LastName = userInWork.LastName;
            BirthDate = userInWork.BirthDate;
            Awards = userInWork.Awards;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            tbFirstName.Text = FirstName;
            tbLastName.Text = LastName;
            tbBirthdate.Text = BirthDate.ToShortDateString();
            // creating awards list
            foreach (var award in AwardStorage.awardsList)
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
            FirstName = tbFirstName.Text.Trim();
            LastName = tbLastName.Text.Trim();
            BirthDate = DateTime.Parse(tbBirthdate.Text.Trim());
            DialogResult = DialogResult.OK;

            //adding awards to user by checkbox
            Awards = new List<Award>();
            foreach (var award in AwardStorage.awardsList)
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

    }
}
