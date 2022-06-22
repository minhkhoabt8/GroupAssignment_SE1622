namespace MyStoreWinApp
{
    partial class frmMemberDetails
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_MemberName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.lbMemberName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(620, 307);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_Cancel.TabIndex = 36;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(159, 307);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 29);
            this.btn_Save.TabIndex = 35;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(535, 215);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(181, 27);
            this.txt_Country.TabIndex = 34;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(535, 146);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(181, 27);
            this.txt_City.TabIndex = 33;
            // 
            // txt_MemberName
            // 
            this.txt_MemberName.Location = new System.Drawing.Point(535, 75);
            this.txt_MemberName.Name = "txt_MemberName";
            this.txt_MemberName.Size = new System.Drawing.Size(181, 27);
            this.txt_MemberName.TabIndex = 32;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(159, 215);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(181, 27);
            this.txt_Password.TabIndex = 31;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(159, 139);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(181, 27);
            this.txt_Email.TabIndex = 30;
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Location = new System.Drawing.Point(159, 71);
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.Size = new System.Drawing.Size(181, 27);
            this.txt_MemberID.TabIndex = 29;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(450, 222);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(60, 20);
            this.lbCountry.TabIndex = 28;
            this.lbCountry.Text = "Country";
            // 
            // lbMemberName
            // 
            this.lbMemberName.AutoSize = true;
            this.lbMemberName.Location = new System.Drawing.Point(81, 142);
            this.lbMemberName.Name = "lbMemberName";
            this.lbMemberName.Size = new System.Drawing.Size(46, 20);
            this.lbMemberName.TabIndex = 27;
            this.lbMemberName.Text = "Email";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(57, 218);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 26;
            this.lbPassword.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Member Name";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(450, 146);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 20);
            this.lbCity.TabIndex = 24;
            this.lbCity.Text = "City";
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(47, 74);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(84, 20);
            this.lbMemberID.TabIndex = 23;
            this.lbMemberID.Text = "Member ID";
            // 
            // frmMemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_MemberName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_MemberID);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.lbMemberName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbMemberID);
            this.Name = "frmMemberDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Details";
            this.Load += new System.EventHandler(this.frmMemberDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Cancel;
        private Button btn_Save;
        private TextBox txt_Country;
        private TextBox txt_City;
        private TextBox txt_MemberName;
        private TextBox txt_Password;
        private TextBox txt_Email;
        private TextBox txt_MemberID;
        private Label lbCountry;
        private Label lbMemberName;
        private Label lbPassword;
        private Label label4;
        private Label lbCity;
        private Label lbMemberID;
    }
}