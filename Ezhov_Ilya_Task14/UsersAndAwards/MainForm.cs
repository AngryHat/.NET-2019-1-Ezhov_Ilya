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
    public partial class MainForm : Form
    {
        delegate DateTime DTSortingDelegate(User u);
        delegate string StringSortingDelegate(User u);

        public bool SortDirection = true;

        List<User> usersList = new List<User>();
        List<Award> awardsList = new List<Award>();

        public MainForm()
        {
            usersList.Add(new User("Ivan", "Ruka", DateTime.Parse("1989.11.23")));
            usersList.Add(new User("Roman", "Zhukov", DateTime.Parse("1999.02.11")));
            usersList.Add(new User("Alena", "Apina", DateTime.Parse("1987.03.08")));
            usersList.Add(new User("Vasyliy", "Erohin", DateTime.Parse("1963.08.14")));

            InitializeComponent();
            gdvMain.DataSource = usersList;
        }

        private void gdvMain_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SortBy(e.ColumnIndex);
        }

        public void SortBy(int columIndex)
        {
            if (columIndex == 1) //FIRST NAME
            {
                if (SortDirection == true)
                {
                    usersList = new List<User>(usersList.OrderBy(user => user.FirstName).ToList());
                }
                else
                {
                    usersList = new List<User>(usersList.OrderByDescending(user => user.FirstName).ToList());
                }
            }
            if (columIndex == 2) //LAST NAME
            {
                if (SortDirection == true)
                {
                    usersList = new List<User>(usersList.OrderBy(user => user.LastName).ToList());
                }
                else
                {
                    usersList = new List<User>(usersList.OrderByDescending(user => user.LastName).ToList());
                }
            }
            if (columIndex == 3) //BD
            {
                if (SortDirection == true)
                {
                    usersList = new List<User>(usersList.OrderBy(user => user.BirthDate).ToList());
                }
                else
                {
                    usersList = new List<User>(usersList.OrderByDescending(user => user.BirthDate).ToList());
                }
            }
            if (columIndex == 4) //AGE
            {
                if (SortDirection == true)
                {
                    usersList = new List<User>(usersList.OrderBy(user => user.Age).ToList());
                }
                else
                {
                    usersList = new List<User>(usersList.OrderByDescending(user => user.Age).ToList());
                }
            }
            SortDirection = !SortDirection;
            gdvMain.DataSource = null;
            gdvMain.DataSource = usersList;
        }
    }
}


