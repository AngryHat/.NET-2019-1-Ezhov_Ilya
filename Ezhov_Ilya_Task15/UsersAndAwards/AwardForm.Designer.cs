namespace UsersAndAwards
{
    partial class AwardForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.btnSaveChangesUser = new System.Windows.Forms.Button();
            this.errorProviderAF = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAF)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(19, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(99, 16);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(122, 20);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.Validating += new System.ComponentModel.CancelEventHandler(this.Title_Validating);
            this.tbTitle.Validated += new System.EventHandler(this.Title_Validated);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(19, 52);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(22, 77);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(199, 145);
            this.tbDescription.TabIndex = 2;
            this.tbDescription.Validating += new System.ComponentModel.CancelEventHandler(this.Descrition_Validating);
            this.tbDescription.Validated += new System.EventHandler(this.Descrition_Validated);
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelUser.Location = new System.Drawing.Point(141, 247);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Size = new System.Drawing.Size(100, 30);
            this.btnCancelUser.TabIndex = 5;
            this.btnCancelUser.Text = "Cancel";
            this.btnCancelUser.UseVisualStyleBackColor = true;
            // 
            // btnSaveChangesUser
            // 
            this.btnSaveChangesUser.Location = new System.Drawing.Point(22, 247);
            this.btnSaveChangesUser.Name = "btnSaveChangesUser";
            this.btnSaveChangesUser.Size = new System.Drawing.Size(100, 30);
            this.btnSaveChangesUser.TabIndex = 4;
            this.btnSaveChangesUser.Text = "Save";
            this.btnSaveChangesUser.UseVisualStyleBackColor = true;
            this.btnSaveChangesUser.Click += new System.EventHandler(this.btnSaveChangesUser_Click);
            // 
            // errorProviderAF
            // 
            this.errorProviderAF.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderAF.ContainerControl = this;
            // 
            // AwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 289);
            this.Controls.Add(this.btnCancelUser);
            this.Controls.Add(this.btnSaveChangesUser);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AwardForm";
            this.Text = "Add/Edit Award";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnCancelUser;
        private System.Windows.Forms.Button btnSaveChangesUser;
        private System.Windows.Forms.ErrorProvider errorProviderAF;
    }
}