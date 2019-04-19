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
    public partial class MainForm : Form
    {
        enum SortOrder
        {
            Asc,
            Desc
        };

        SortOrder lastNameSort = SortOrder.Asc;

        private List<User> list = new List<User>();
        public MainForm()
        {
            InitializeComponent();
            list.Add(new User("sdf", "fgh"));
            list.Add(new User("dfgd", "dfhdfh"));
            list.Add(new User("dfhdf", "hdfhdf"));
            list.Add(new User("sdhsdfh", "fdfhdgh"));
            list.Add(new User("sdhfgdhf", "fghdhdh"));
            ctlGrid.DataSource = list; // THIS IS WHAT I LOOKED FOR
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            list.Add(new User("newone", "newonovich"));
        }

        private void btnExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ctlGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (lastNameSort == SortOrder.Asc)
            {
                lastNameSort = SortOrder.Desc;
                list = new List<User>(list.OrderByDescending(u => u.LastName).ToList());
            } else
            {
                list = new List<User>(list.OrderBy(u => u.LastName).ToList());
                lastNameSort = SortOrder.Asc;
            }
            ctlGrid.DataSource = list;

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var form = new UserForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                list.Add(new User(form.LastName, form.FirstName));
            }
        }

        private void ctlGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
