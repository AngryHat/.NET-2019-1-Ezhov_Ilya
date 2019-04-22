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
    public partial class AwardForm : Form
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public AwardForm()
        {
            InitializeComponent();
        }

        public AwardForm(Award awardInWork)
        {
            InitializeComponent();
            Title = awardInWork.Title;
            Description = awardInWork.Description;
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
            DialogResult = DialogResult.OK;
        }
    }
}
