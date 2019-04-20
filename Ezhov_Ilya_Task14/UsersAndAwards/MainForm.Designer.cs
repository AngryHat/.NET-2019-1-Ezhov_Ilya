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
            this.gdvUsers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMainContainer = new System.Windows.Forms.TabControl();
            this.usersTab = new System.Windows.Forms.TabPage();
            this.awardsTab = new System.Windows.Forms.TabPage();
            this.gdvAwards = new System.Windows.Forms.DataGridView();
            this.AwardsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsers)).BeginInit();
            this.tabMainContainer.SuspendLayout();
            this.usersTab.SuspendLayout();
            this.awardsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAwards)).BeginInit();
            this.SuspendLayout();
            // 
            // gdvUsers
            // 
            this.gdvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.LastName,
            this.BirthDate,
            this.Age});
            this.gdvUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.gdvUsers.Location = new System.Drawing.Point(3, 3);
            this.gdvUsers.Name = "gdvUsers";
            this.gdvUsers.Size = new System.Drawing.Size(770, 340);
            this.gdvUsers.TabIndex = 0;
            this.gdvUsers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gdvMain_ColumnHeaderMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
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
            // 
            // tabMainContainer
            // 
            this.tabMainContainer.Controls.Add(this.usersTab);
            this.tabMainContainer.Controls.Add(this.awardsTab);
            this.tabMainContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabMainContainer.Location = new System.Drawing.Point(0, 41);
            this.tabMainContainer.Name = "tabMainContainer";
            this.tabMainContainer.SelectedIndex = 0;
            this.tabMainContainer.Size = new System.Drawing.Size(784, 400);
            this.tabMainContainer.TabIndex = 1;
            // 
            // usersTab
            // 
            this.usersTab.Controls.Add(this.gdvUsers);
            this.usersTab.Location = new System.Drawing.Point(4, 22);
            this.usersTab.Name = "usersTab";
            this.usersTab.Padding = new System.Windows.Forms.Padding(3);
            this.usersTab.Size = new System.Drawing.Size(776, 374);
            this.usersTab.TabIndex = 0;
            this.usersTab.Text = "Users";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // awardsTab
            // 
            this.awardsTab.Controls.Add(this.gdvAwards);
            this.awardsTab.Location = new System.Drawing.Point(4, 22);
            this.awardsTab.Name = "awardsTab";
            this.awardsTab.Padding = new System.Windows.Forms.Padding(3);
            this.awardsTab.Size = new System.Drawing.Size(776, 374);
            this.awardsTab.TabIndex = 1;
            this.awardsTab.Text = "Awards";
            this.awardsTab.UseVisualStyleBackColor = true;
            // 
            // gdvAwards
            // 
            this.gdvAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvAwards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AwardsId,
            this.Title,
            this.Description});
            this.gdvAwards.Dock = System.Windows.Forms.DockStyle.Top;
            this.gdvAwards.Location = new System.Drawing.Point(3, 3);
            this.gdvAwards.Name = "gdvAwards";
            this.gdvAwards.Size = new System.Drawing.Size(770, 340);
            this.gdvAwards.TabIndex = 1;
            // 
            // AwardsId
            // 
            this.AwardsId.DataPropertyName = "Id";
            this.AwardsId.HeaderText = "ID";
            this.AwardsId.Name = "AwardsId";
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tabMainContainer);
            this.Name = "MainForm";
            this.Text = "Users & Rewards";
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsers)).EndInit();
            this.tabMainContainer.ResumeLayout(false);
            this.usersTab.ResumeLayout(false);
            this.awardsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvAwards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.TabControl tabMainContainer;
        private System.Windows.Forms.TabPage usersTab;
        private System.Windows.Forms.TabPage awardsTab;
        private System.Windows.Forms.DataGridView gdvAwards;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwardsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

