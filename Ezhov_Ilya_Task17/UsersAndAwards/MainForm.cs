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
        public static List<AwardViewModel> awardModelsList;

        public MainForm()
        {
            awardsList = Logic.GetAllAwards();
            usersList = Logic.GetAllUsers();

            awardModelsList = Logic.GetAllAwardsViewModels(awardsList);
            userModelsList = Logic.GetAllUsersViewModels(usersList);

            InitializeComponent();
            
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = userModelsList;
            dgvAwards.AutoGenerateColumns = false;
            dgvAwards.DataSource = awardModelsList;

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
            if (columIndex == 0) //id
            {
                if (SortDirection == true)
                {
                    usersList = Logic.GetAllUsers();
                    userModelsList = Logic.GetAllUsersViewModels(usersList).OrderBy(UserViewModel => UserViewModel.id).ToList();
                    RefreshSortedUsersGrid();
                }
                else
                {
                    usersList = Logic.GetAllUsers();
                    userModelsList = Logic.GetAllUsersViewModels(usersList).OrderByDescending(UserViewModel => UserViewModel.id).ToList();
                    RefreshSortedUsersGrid();
                }
            }
            if (columIndex == 1) //FIRST NAME
            {
                if (SortDirection == true)
                {
                    usersList = Logic.GetAllUsers();
                    userModelsList = Logic.GetAllUsersViewModels(usersList).OrderBy(UserViewModel => UserViewModel.FirstName).ToList();
                    RefreshSortedUsersGrid();
                }
                else
                {
                    usersList = Logic.GetAllUsers();
                    userModelsList = Logic.GetAllUsersViewModels(usersList).OrderByDescending(UserViewModel => UserViewModel.FirstName).ToList();
                    RefreshSortedUsersGrid();
                }
            }
            if (columIndex == 2) //LAST NAME
            {
                if (SortDirection == true)
                {
                    usersList = Logic.GetAllUsers();
                    userModelsList = Logic.GetAllUsersViewModels(usersList).OrderBy(UserViewModel => UserViewModel.LastName).ToList();
                    RefreshSortedUsersGrid();
                }
                else
                {
                    usersList = Logic.GetAllUsers();
                    userModelsList = Logic.GetAllUsersViewModels(usersList).OrderByDescending(UserViewModel => UserViewModel.LastName).ToList();
                    RefreshSortedUsersGrid();
                }
            }
            if (columIndex == 3) //BD
            {
                if (SortDirection == true)
                {
                    usersList = Logic.GetAllUsers();
                    userModelsList = Logic.GetAllUsersViewModels(usersList).OrderBy(UserViewModel => UserViewModel.BirthDate).ToList();
                    RefreshSortedUsersGrid();
                }
                else
                {
                    usersList = Logic.GetAllUsers();
                    userModelsList = Logic.GetAllUsersViewModels(usersList).OrderByDescending(UserViewModel => UserViewModel.BirthDate).ToList();
                    RefreshSortedUsersGrid();
                }
            }
            if (columIndex == 4) //AGE
            {
                if (SortDirection == true)
                {
                    usersList = Logic.GetAllUsers();
                    userModelsList = Logic.GetAllUsersViewModels(usersList).OrderBy(UserViewModel => UserViewModel.Age).ToList();
                    RefreshSortedUsersGrid();
                }
                else
                {
                    usersList = Logic.GetAllUsers();
                    userModelsList = Logic.GetAllUsersViewModels(usersList).OrderByDescending(UserViewModel => UserViewModel.Age).ToList();
                    RefreshSortedUsersGrid();
                }
            }
            SortDirection = !SortDirection;
        }

        private void RefreshSortedUsersGrid()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = userModelsList;
        }

        private void RefreshUsersGrid()
        {
            usersList = Logic.GetAllUsers();
            userModelsList = Logic.GetAllUsersViewModels(usersList);
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = userModelsList;
        }

        private void RefreshAwardsGrid()
        {
            awardsList = Logic.GetAllAwards();
            awardModelsList = Logic.GetAllAwardsViewModels(awardsList);
            dgvAwards.DataSource = null;
            dgvAwards.DataSource = awardModelsList;
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
                UserViewModel userViewModel = (UserViewModel)dgvUsers.SelectedCells[0].OwningRow.DataBoundItem;
                User user = Logic.GetUserById(userViewModel.id);

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
                AwardViewModel awardViewModel = (AwardViewModel)dgvAwards.SelectedCells[0].OwningRow.DataBoundItem;
                Award award = Logic.GetAwardById(awardViewModel.id);

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
                    UserViewModel userViewModel = (UserViewModel)dgvUsers.SelectedCells[0].OwningRow.DataBoundItem;
                    User user = Logic.GetUserById(userViewModel.id);
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
                    AwardViewModel awardViewModel = (AwardViewModel)dgvAwards.SelectedCells[0].OwningRow.DataBoundItem;
                    Award award = Logic.GetAwardById(awardViewModel.id);
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


