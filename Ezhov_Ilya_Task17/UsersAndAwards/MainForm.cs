using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Entities;
using DAL.Memory;
using BLL.Logic;

namespace UsersAndAwards
{
    public partial class MainForm : Form
    {
        delegate DateTime DTSortingDelegate(User u);
        delegate string StringSortingDelegate(User u);

        private bool SortDirection = true;
        
        private Logic Logic = new Logic();

        public static List<User> usersList;
        public static List<Award> awardsList;

        public static List<UserViewModel> userModelsList;

        public MainForm()
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();
            
            //userModelsList = Logic.GetAllUserModels(); // MODELS ARE NOT USING YET

            // adding some users
            //Logic.AddUserWithParams("Ivan", "Ruka", DateTime.Parse("1989.11.23"), null);
            //Logic.AddUserWithParams("Roman", "Zhukov", DateTime.Parse("1999.02.11"), null);
            //Logic.AddUserWithParams("Alena", "Apina", DateTime.Parse("1987.03.08"), null);
            //Logic.AddUserWithParams("Vasyliy", "Erohin", DateTime.Parse("1963.08.14"), null);

            //// adding some awards
            //Logic.AddAwardWithParams("Nobel Prize", "This is a great award! You must be proud of yourself for getting it!");
            //Logic.AddAwardWithParams("Oscar", "Wow! You acted awesome in that movie, but of course, you already know it.");


            
            InitializeComponent();
            
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = usersList;
            dgvAwards.AutoGenerateColumns = false;
            dgvAwards.DataSource = awardsList;

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvAwards.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void gdvMain_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SortBy(e.ColumnIndex);
        }

        // Users GDV methods
        public void SortBy(int columIndex)
        {
            if (columIndex == 1) //FIRST NAME
            {
                RefreshUsersGrid();
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
                RefreshUsersGrid();
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
                RefreshUsersGrid();
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
                RefreshUsersGrid();
                if (SortDirection == true)
                {
                    usersList = new List<User>(usersList.OrderBy(user => user.Age).ToList());
                    // SORT SOLUTION
                    dgvUsers.DataSource = null;
                    dgvUsers.DataSource = usersList;
                }
                else
                {
                    usersList = new List<User>(usersList.OrderByDescending(user => user.Age).ToList());
                }
            }
            SortDirection = !SortDirection;
            
        }

        private void RefreshUsersGrid()
        {
            dgvUsers.DataSource = null;
            usersList = Logic.GetAllUsers();
            dgvUsers.DataSource = usersList;
        }

        private void RefreshAwardsGrid()
        {
            dgvAwards.DataSource = null;
            awardsList = Logic.GetAllAwards();
            dgvAwards.DataSource = awardsList;
        }

        // ADD BUTTONS
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();

            if (userForm.ShowDialog(this) == DialogResult.OK)
            {
                Logic.AddUserWithParams(userForm.FirstName, userForm.LastName, userForm.BirthDate, userForm.Awards);
            }
            RefreshUsersGrid();
        }
        private void mmUserAdd_Click(object sender, EventArgs e)
        {
            btnAddUser_Click(sender, e);
        }

        private void btnAddAward_Click(object sender, EventArgs e)
        {
            AwardForm awardForm = new AwardForm();

            if (awardForm.ShowDialog(this) == DialogResult.OK)
            {
                Logic.AddAwardWithParams(awardForm.Title, awardForm.Description);
            }
            RefreshAwardsGrid();
        }
        private void mmAwardAdd_Click(object sender, EventArgs e)
        {
            btnAddAward_Click(sender, e);
        }

        //EDIT BUTTONS
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedCells.Count == 1)
            {
                User user = (User)dgvUsers.SelectedCells[0].OwningRow.DataBoundItem;

                UserForm userForm = new UserForm(user);
                
                if (userForm.ShowDialog(this) == DialogResult.OK)
                {
                    Logic.UpdateUser(user, userForm.FirstName, userForm.LastName, userForm.BirthDate, userForm.Awards);
                }
                RefreshUsersGrid();
            }
        }
        private void mmUserEdit_Click(object sender, EventArgs e)
        {
            btnEditUser_Click(sender, e);
        }

        private void btnEditAward_Click(object sender, EventArgs e)
        {
            if (dgvAwards.SelectedCells.Count == 1)
            {
                Award award = (Award)dgvAwards.SelectedCells[0].OwningRow.DataBoundItem;

                AwardForm awardForm = new AwardForm(award);

                if (awardForm.ShowDialog(this) == DialogResult.OK)
                {
                    Logic.UpdateAward(award, awardForm.Title, awardForm.Description);
                }
                RefreshAwardsGrid();
            }
        }
        private void mmAwardEdit_Click(object sender, EventArgs e)
        {
            btnEditAward_Click(sender, e);
        }

        //REMOVE BUTTONS
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedCells.Count == 1)
            {
                var confirmRemove = MessageBox.Show("You are going to remove selected user. Are you sure?", "Confirm the action:",
                                     MessageBoxButtons.YesNo);
                if (confirmRemove == DialogResult.Yes)
                {
                    User user = (User)dgvUsers.SelectedCells[0].OwningRow.DataBoundItem;
                    Logic.RemoveUser(user);
                }
            }
            RefreshUsersGrid();
        }
        private void mmUserRemove_Click(object sender, EventArgs e)
        {
            btnRemoveUser_Click(sender, e);
        }

        private void btnRemoveAward_Click(object sender, EventArgs e)
        {
            if (dgvAwards.SelectedCells.Count == 1)
            {
                var confirmRemove = MessageBox.Show("You are going to remove selected award. Are you sure?", "Confirm the action:",
                                     MessageBoxButtons.YesNo);
                if (confirmRemove == DialogResult.Yes)
                {
                    Award award = (Award)dgvAwards.SelectedCells[0].OwningRow.DataBoundItem;
                    Logic.RemoveAward(award);
                }
            }
            RefreshUsersGrid();
            RefreshAwardsGrid();
        }
        private void mmAwardRemove_Click(object sender, EventArgs e)
        {
            btnRemoveAward_Click(sender, e);
        }

        //CLOSE BUTTONS
        private void btnCloseProgramUS_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCloseProgramAW_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


