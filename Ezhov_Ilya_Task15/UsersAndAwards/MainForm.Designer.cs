namespace UsersAndAwards
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Awards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMainContainer = new System.Windows.Forms.TabControl();
            this.usersTab = new System.Windows.Forms.TabPage();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnCloseProgramUS = new System.Windows.Forms.Button();
            this.awardsTab = new System.Windows.Forms.TabPage();
            this.btnCloseProgramAW = new System.Windows.Forms.Button();
            this.btnRemoveAward = new System.Windows.Forms.Button();
            this.btnAddAward = new System.Windows.Forms.Button();
            this.btnEditAward = new System.Windows.Forms.Button();
            this.dgvAwards = new System.Windows.Forms.DataGridView();
            this.AwardsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmUserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mmUserAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mmUserEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmUserRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAwardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAwardAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAwardEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mmAwardRemove = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabMainContainer.SuspendLayout();
            this.usersTab.SuspendLayout();
            this.awardsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwards)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.BirthDate,
            this.Age,
            this.Awards});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUsers.Location = new System.Drawing.Point(3, 3);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsers.Size = new System.Drawing.Size(729, 332);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gdvMain_ColumnHeaderMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 140;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.Width = 140;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "Birth Date";
            this.BirthDate.Name = "BirthDate";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.Width = 50;
            // 
            // Awards
            // 
            this.Awards.DataPropertyName = "AwardsToString";
            this.Awards.HeaderText = "Awards";
            this.Awards.Name = "Awards";
            this.Awards.Width = 265;
            // 
            // tabMainContainer
            // 
            this.tabMainContainer.Controls.Add(this.usersTab);
            this.tabMainContainer.Controls.Add(this.awardsTab);
            this.tabMainContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabMainContainer.Location = new System.Drawing.Point(0, 25);
            this.tabMainContainer.Name = "tabMainContainer";
            this.tabMainContainer.SelectedIndex = 0;
            this.tabMainContainer.Size = new System.Drawing.Size(743, 400);
            this.tabMainContainer.TabIndex = 1;
            // 
            // usersTab
            // 
            this.usersTab.Controls.Add(this.dgvUsers);
            this.usersTab.Controls.Add(this.btnRemoveUser);
            this.usersTab.Controls.Add(this.btnAddUser);
            this.usersTab.Controls.Add(this.btnEditUser);
            this.usersTab.Controls.Add(this.btnCloseProgramUS);
            this.usersTab.Location = new System.Drawing.Point(4, 22);
            this.usersTab.Name = "usersTab";
            this.usersTab.Padding = new System.Windows.Forms.Padding(3);
            this.usersTab.Size = new System.Drawing.Size(735, 374);
            this.usersTab.TabIndex = 0;
            this.usersTab.Text = "Users";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(215, 341);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveUser.TabIndex = 1;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(3, 341);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 30);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(109, 341);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(100, 30);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnCloseProgramUS
            // 
            this.btnCloseProgramUS.Location = new System.Drawing.Point(632, 341);
            this.btnCloseProgramUS.Name = "btnCloseProgramUS";
            this.btnCloseProgramUS.Size = new System.Drawing.Size(100, 30);
            this.btnCloseProgramUS.TabIndex = 1;
            this.btnCloseProgramUS.Text = "Close";
            this.btnCloseProgramUS.UseVisualStyleBackColor = true;
            this.btnCloseProgramUS.Click += new System.EventHandler(this.btnCloseProgramUS_Click);
            // 
            // awardsTab
            // 
            this.awardsTab.Controls.Add(this.btnCloseProgramAW);
            this.awardsTab.Controls.Add(this.btnRemoveAward);
            this.awardsTab.Controls.Add(this.btnAddAward);
            this.awardsTab.Controls.Add(this.btnEditAward);
            this.awardsTab.Controls.Add(this.dgvAwards);
            this.awardsTab.Location = new System.Drawing.Point(4, 22);
            this.awardsTab.Name = "awardsTab";
            this.awardsTab.Padding = new System.Windows.Forms.Padding(3);
            this.awardsTab.Size = new System.Drawing.Size(735, 374);
            this.awardsTab.TabIndex = 1;
            this.awardsTab.Text = "Awards";
            this.awardsTab.UseVisualStyleBackColor = true;
            // 
            // btnCloseProgramAW
            // 
            this.btnCloseProgramAW.Location = new System.Drawing.Point(632, 341);
            this.btnCloseProgramAW.Name = "btnCloseProgramAW";
            this.btnCloseProgramAW.Size = new System.Drawing.Size(100, 30);
            this.btnCloseProgramAW.TabIndex = 5;
            this.btnCloseProgramAW.Text = "Close";
            this.btnCloseProgramAW.UseVisualStyleBackColor = true;
            this.btnCloseProgramAW.Click += new System.EventHandler(this.btnCloseProgramAW_Click);
            // 
            // btnRemoveAward
            // 
            this.btnRemoveAward.Location = new System.Drawing.Point(215, 341);
            this.btnRemoveAward.Name = "btnRemoveAward";
            this.btnRemoveAward.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveAward.TabIndex = 2;
            this.btnRemoveAward.Text = "Remove Award";
            this.btnRemoveAward.UseVisualStyleBackColor = true;
            this.btnRemoveAward.Click += new System.EventHandler(this.btnRemoveAward_Click);
            // 
            // btnAddAward
            // 
            this.btnAddAward.Location = new System.Drawing.Point(3, 341);
            this.btnAddAward.Name = "btnAddAward";
            this.btnAddAward.Size = new System.Drawing.Size(100, 30);
            this.btnAddAward.TabIndex = 3;
            this.btnAddAward.Text = "Add Award";
            this.btnAddAward.UseVisualStyleBackColor = true;
            this.btnAddAward.Click += new System.EventHandler(this.btnAddAward_Click);
            // 
            // btnEditAward
            // 
            this.btnEditAward.Location = new System.Drawing.Point(109, 341);
            this.btnEditAward.Name = "btnEditAward";
            this.btnEditAward.Size = new System.Drawing.Size(100, 30);
            this.btnEditAward.TabIndex = 4;
            this.btnEditAward.Text = "Edit Award";
            this.btnEditAward.UseVisualStyleBackColor = true;
            this.btnEditAward.Click += new System.EventHandler(this.btnEditAward_Click);
            // 
            // dgvAwards
            // 
            this.dgvAwards.AllowUserToResizeColumns = false;
            this.dgvAwards.AllowUserToResizeRows = false;
            this.dgvAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAwards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AwardsId,
            this.Title,
            this.Description});
            this.dgvAwards.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAwards.Location = new System.Drawing.Point(3, 3);
            this.dgvAwards.Name = "dgvAwards";
            this.dgvAwards.RowHeadersVisible = false;
            this.dgvAwards.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAwards.Size = new System.Drawing.Size(729, 332);
            this.dgvAwards.TabIndex = 1;
            // 
            // AwardsId
            // 
            this.AwardsId.DataPropertyName = "Id";
            this.AwardsId.HeaderText = "ID";
            this.AwardsId.Name = "AwardsId";
            this.AwardsId.Width = 30;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 150;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 545;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.mmUserMenu,
            this.mmAwardMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(743, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "Main Menu";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // mmUserMenu
            // 
            this.mmUserMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmUserAdd,
            this.mmUserEdit,
            this.mmUserRemove});
            this.mmUserMenu.Name = "mmUserMenu";
            this.mmUserMenu.Size = new System.Drawing.Size(42, 20);
            this.mmUserMenu.Text = "User";
            // 
            // mmUserAdd
            // 
            this.mmUserAdd.Name = "mmUserAdd";
            this.mmUserAdd.Size = new System.Drawing.Size(117, 22);
            this.mmUserAdd.Text = "Add";
            this.mmUserAdd.Click += new System.EventHandler(this.mmUserAdd_Click);
            // 
            // mmUserEdit
            // 
            this.mmUserEdit.Name = "mmUserEdit";
            this.mmUserEdit.Size = new System.Drawing.Size(117, 22);
            this.mmUserEdit.Text = "Edit";
            this.mmUserEdit.Click += new System.EventHandler(this.mmUserEdit_Click);
            // 
            // mmUserRemove
            // 
            this.mmUserRemove.Name = "mmUserRemove";
            this.mmUserRemove.Size = new System.Drawing.Size(117, 22);
            this.mmUserRemove.Text = "Remove";
            this.mmUserRemove.Click += new System.EventHandler(this.mmUserRemove_Click);
            // 
            // mmAwardMenu
            // 
            this.mmAwardMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmAwardAdd,
            this.mmAwardEdit,
            this.mmAwardRemove});
            this.mmAwardMenu.Name = "mmAwardMenu";
            this.mmAwardMenu.Size = new System.Drawing.Size(58, 20);
            this.mmAwardMenu.Text = "Awards";
            // 
            // mmAwardAdd
            // 
            this.mmAwardAdd.Name = "mmAwardAdd";
            this.mmAwardAdd.Size = new System.Drawing.Size(117, 22);
            this.mmAwardAdd.Text = "Add";
            this.mmAwardAdd.Click += new System.EventHandler(this.mmAwardAdd_Click);
            // 
            // mmAwardEdit
            // 
            this.mmAwardEdit.Name = "mmAwardEdit";
            this.mmAwardEdit.Size = new System.Drawing.Size(117, 22);
            this.mmAwardEdit.Text = "Edit";
            this.mmAwardEdit.Click += new System.EventHandler(this.mmAwardEdit_Click);
            // 
            // mmAwardRemove
            // 
            this.mmAwardRemove.Name = "mmAwardRemove";
            this.mmAwardRemove.Size = new System.Drawing.Size(117, 22);
            this.mmAwardRemove.Text = "Remove";
            this.mmAwardRemove.Click += new System.EventHandler(this.mmAwardRemove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 425);
            this.Controls.Add(this.tabMainContainer);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Users & Awards";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabMainContainer.ResumeLayout(false);
            this.usersTab.ResumeLayout(false);
            this.awardsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAwards)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TabControl tabMainContainer;
        private System.Windows.Forms.TabPage usersTab;
        private System.Windows.Forms.TabPage awardsTab;
        private System.Windows.Forms.DataGridView dgvAwards;
        private System.Windows.Forms.Button btnCloseProgramUS;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnCloseProgramAW;
        private System.Windows.Forms.Button btnRemoveAward;
        private System.Windows.Forms.Button btnAddAward;
        private System.Windows.Forms.Button btnEditAward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Awards;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwardsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mmUserMenu;
        private System.Windows.Forms.ToolStripMenuItem mmUserAdd;
        private System.Windows.Forms.ToolStripMenuItem mmUserEdit;
        private System.Windows.Forms.ToolStripMenuItem mmUserRemove;
        private System.Windows.Forms.ToolStripMenuItem mmAwardMenu;
        private System.Windows.Forms.ToolStripMenuItem mmAwardAdd;
        private System.Windows.Forms.ToolStripMenuItem mmAwardEdit;
        private System.Windows.Forms.ToolStripMenuItem mmAwardRemove;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

