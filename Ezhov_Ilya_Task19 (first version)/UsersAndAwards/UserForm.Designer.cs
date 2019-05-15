namespace UsersAndAwards
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbBirthDate = new System.Windows.Forms.TextBox();
            this.btnSaveChangesUser = new System.Windows.Forms.Button();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.chbxUserAwardsBox = new System.Windows.Forms.CheckedListBox();
            this.errorProviderUF = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUF)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(19, 19);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(19, 52);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(19, 85);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(57, 13);
            this.lblBirthDate.TabIndex = 0;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(99, 16);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(122, 20);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.FirstName_Validating);
            this.tbFirstName.Validated += new System.EventHandler(this.FirstName_Validated);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(99, 49);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(122, 20);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.LastName_Validating);
            this.tbLastName.Validated += new System.EventHandler(this.LastName_Validated);
            // 
            // tbBirthDate
            // 
            this.tbBirthDate.Location = new System.Drawing.Point(99, 82);
            this.tbBirthDate.Name = "tbBirthDate";
            this.tbBirthDate.Size = new System.Drawing.Size(73, 20);
            this.tbBirthDate.TabIndex = 1;
            this.tbBirthDate.Validating += new System.ComponentModel.CancelEventHandler(this.BirthDate_Validating);
            this.tbBirthDate.Validated += new System.EventHandler(this.BirthDate_Validated);
            // 
            // btnSaveChangesUser
            // 
            this.btnSaveChangesUser.Location = new System.Drawing.Point(22, 247);
            this.btnSaveChangesUser.Name = "btnSaveChangesUser";
            this.btnSaveChangesUser.Size = new System.Drawing.Size(100, 30);
            this.btnSaveChangesUser.TabIndex = 2;
            this.btnSaveChangesUser.Text = "Save";
            this.btnSaveChangesUser.UseVisualStyleBackColor = true;
            this.btnSaveChangesUser.Click += new System.EventHandler(this.btnSaveChangesUser_Click);
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelUser.Location = new System.Drawing.Point(141, 247);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(100, 30);
            this.btnCancelUser.TabIndex = 3;
            this.btnCancelUser.Text = "Cancel";
            this.btnCancelUser.UseVisualStyleBackColor = true;
            this.btnCancelUser.Click += new System.EventHandler(this.btnCancelUser_Click);
            // 
            // chbxUserAwardsBox
            // 
            this.chbxUserAwardsBox.FormattingEnabled = true;
            this.chbxUserAwardsBox.Location = new System.Drawing.Point(22, 123);
            this.chbxUserAwardsBox.Name = "chbxUserAwardsBox";
            this.chbxUserAwardsBox.Size = new System.Drawing.Size(199, 94);
            this.chbxUserAwardsBox.TabIndex = 4;
            // 
            // errorProviderUF
            // 
            this.errorProviderUF.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderUF.ContainerControl = this;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 289);
            this.Controls.Add(this.chbxUserAwardsBox);
            this.Controls.Add(this.btnCancelUser);
            this.Controls.Add(this.btnSaveChangesUser);
            this.Controls.Add(this.tbBirthDate);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit User";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbBirthDate;
        private System.Windows.Forms.Button btnSaveChangesUser;
        private System.Windows.Forms.Button btnCancelUser;
        private System.Windows.Forms.CheckedListBox chbxUserAwardsBox;
        private System.Windows.Forms.ErrorProvider errorProviderUF;
    }
}