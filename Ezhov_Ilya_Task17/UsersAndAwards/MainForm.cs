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
        private bool SortDirection = true;
        
        private Logic Logic = new Logic();

        public static List<User> usersList;
        public static List<Award> awardsList;

        public static List<UserViewModel> userModelsList;

        public MainForm()
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();
            
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
                if (SortDirection == true)
                {
                    usersList = new List<User>(Logic.GetAllUsers().OrderBy(user => user.FirstName).ToList());
                    RefreshUsersGridSorted();
                }
                else
                {
                    usersList = new List<User>(Logic.GetAllUsers().OrderByDescending(user => user.FirstName).ToList());
                    RefreshUsersGridSorted();
                }
            }
            if (columIndex == 2) //LAST NAME
            {
                if (SortDirection == true)
                {
                    usersList = new List<User>(Logic.GetAllUsers().OrderBy(user => user.LastName).ToList());
                    RefreshUsersGridSorted();
                }
                else
                {
                    usersList = new List<User>(Logic.GetAllUsers().OrderByDescending(user => user.LastName).ToList());
                    RefreshUsersGridSorted();
                }
            }
            if (columIndex == 3) //BD
            {
                if (SortDirection == true)
                {
                    usersList = new List<User>(Logic.GetAllUsers().OrderBy(user => user.BirthDate).ToList());
                    RefreshUsersGridSorted();
                }
                else
                {
                    usersList = new List<User>(Logic.GetAllUsers().OrderByDescending(user => user.BirthDate).ToList());
                    RefreshUsersGridSorted();
                }
            }
            if (columIndex == 4) //AGE
            {
                if (SortDirection == true)
                {
                    usersList = new List<User>(Logic.GetAllUsers().OrderBy(user => user.Age).ToList());
                    RefreshUsersGridSorted();
                }
                else
                {
                    usersList = new List<User>(Logic.GetAllUsers().OrderByDescending(user => user.Age).ToList());
                    RefreshUsersGridSorted();
                }
            }
            SortDirection = !SortDirection;
        }

        private void RefreshUsersGridSorted()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = usersList;
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
                Logic.AddUser(userForm.FirstName, userForm.LastName, userForm.BirthDate, userForm.Awards);
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
                Logic.AddAward(awardForm.Title, awardForm.Description);
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
            }
            RefreshUsersGrid();
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
            }
            RefreshUsersGrid();
            RefreshAwardsGrid();
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


