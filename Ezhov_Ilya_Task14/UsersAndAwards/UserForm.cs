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
        }

        private void Form_Load(object sender, EventArgs e)
        {
            tbFirstName.Text = FirstName;
            tbLastName.Text = LastName;
            tbBirthdate.Text = BirthDate.ToShortDateString();
            
        }

        private void btnSaveChangesUser_Click(object sender, EventArgs e)
        {
            FirstName = tbFirstName.Text.Trim();
            LastName = tbLastName.Text.Trim();
            BirthDate = DateTime.Parse(tbBirthdate.Text.Trim());
            DialogResult = DialogResult.OK;
        }
    }
}
