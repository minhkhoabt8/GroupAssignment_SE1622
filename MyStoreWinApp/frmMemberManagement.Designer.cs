namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_SearchValue = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_MemberName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_MemberName = new System.Windows.Forms.Label();
            this.lb_City = new System.Windows.Forms.Label();
            this.lb_Country = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_MemberID = new System.Windows.Forms.Label();
            this.btn_FilterByCountry = new System.Windows.Forms.Button();
            this.btn_FilterByCity = new System.Windows.Forms.Button();
            this.btn_SortByName = new System.Windows.Forms.Button();
            this.dgv_MemberList = new System.Windows.Forms.DataGridView();
            this.txt_FilterByCity = new System.Windows.Forms.TextBox();
            this.txt_FIlterByCountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(896, 46);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(130, 29);
            this.btn_Search.TabIndex = 49;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_SearchValue
            // 
            this.txt_SearchValue.Location = new System.Drawing.Point(450, 46);
            this.txt_SearchValue.Name = "txt_SearchValue";
            this.txt_SearchValue.Size = new System.Drawing.Size(427, 27);
            this.txt_SearchValue.TabIndex = 48;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(21, 459);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(363, 477);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 29);
            this.btn_Delete.TabIndex = 44;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(363, 442);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(94, 29);
            this.btn_New.TabIndex = 43;
            this.btn_New.Text = "Add New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(363, 407);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(94, 29);
            this.btn_Load.TabIndex = 42;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(147, 128);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(211, 27);
            this.txt_Email.TabIndex = 41;
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(147, 309);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(211, 27);
            this.txt_Country.TabIndex = 40;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(147, 373);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(211, 27);
            this.txt_City.TabIndex = 39;
            // 
            // txt_MemberName
            // 
            this.txt_MemberName.Location = new System.Drawing.Point(147, 247);
            this.txt_MemberName.Name = "txt_MemberName";
            this.txt_MemberName.Size = new System.Drawing.Size(211, 27);
            this.txt_MemberName.TabIndex = 38;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(147, 193);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(211, 27);
            this.txt_Password.TabIndex = 37;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Location = new System.Drawing.Point(147, 67);
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.ReadOnly = true;
            this.txt_MemberID.Size = new System.Drawing.Size(205, 27);
            this.txt_MemberID.TabIndex = 36;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Location = new System.Drawing.Point(10, 135);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(46, 20);
            this.lb_Email.TabIndex = 35;
            this.lb_Email.Text = "Email";
            // 
            // lb_MemberName
            // 
            this.lb_MemberName.AutoSize = true;
            this.lb_MemberName.Location = new System.Drawing.Point(10, 251);
            this.lb_MemberName.Name = "lb_MemberName";
            this.lb_MemberName.Size = new System.Drawing.Size(105, 20);
            this.lb_MemberName.TabIndex = 34;
            this.lb_MemberName.Text = "MemberName";
            // 
            // lb_City
            // 
            this.lb_City.AutoSize = true;
            this.lb_City.Location = new System.Drawing.Point(10, 369);
            this.lb_City.Name = "lb_City";
            this.lb_City.Size = new System.Drawing.Size(34, 20);
            this.lb_City.TabIndex = 33;
            this.lb_City.Text = "City";
            // 
            // lb_Country
            // 
            this.lb_Country.AutoSize = true;
            this.lb_Country.Location = new System.Drawing.Point(10, 311);
            this.lb_Country.Name = "lb_Country";
            this.lb_Country.Size = new System.Drawing.Size(60, 20);
            this.lb_Country.TabIndex = 32;
            this.lb_Country.Text = "Country";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(10, 200);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(70, 20);
            this.lb_Password.TabIndex = 31;
            this.lb_Password.Text = "Password";
            // 
            // lb_MemberID
            // 
            this.lb_MemberID.AutoSize = true;
            this.lb_MemberID.Location = new System.Drawing.Point(10, 73);
            this.lb_MemberID.Name = "lb_MemberID";
            this.lb_MemberID.Size = new System.Drawing.Size(80, 20);
            this.lb_MemberID.TabIndex = 30;
            this.lb_MemberID.Text = "MemberID";
            // 
            // btn_FilterByCountry
            // 
            this.btn_FilterByCountry.Location = new System.Drawing.Point(665, 441);
            this.btn_FilterByCountry.Name = "btn_FilterByCountry";
            this.btn_FilterByCountry.Size = new System.Drawing.Size(135, 29);
            this.btn_FilterByCountry.TabIndex = 50;
            this.btn_FilterByCountry.Text = "Filter By Country";
            this.btn_FilterByCountry.UseVisualStyleBackColor = true;
            this.btn_FilterByCountry.Click += new System.EventHandler(this.btn_FilterByCountry_Click);
            // 
            // btn_FilterByCity
            // 
            this.btn_FilterByCity.Location = new System.Drawing.Point(665, 406);
            this.btn_FilterByCity.Name = "btn_FilterByCity";
            this.btn_FilterByCity.Size = new System.Drawing.Size(135, 29);
            this.btn_FilterByCity.TabIndex = 51;
            this.btn_FilterByCity.Text = "Filter By City";
            this.btn_FilterByCity.UseVisualStyleBackColor = true;
            this.btn_FilterByCity.Click += new System.EventHandler(this.btn_FilterByCity_Click);
            // 
            // btn_SortByName
            // 
            this.btn_SortByName.Location = new System.Drawing.Point(665, 476);
            this.btn_SortByName.Name = "btn_SortByName";
            this.btn_SortByName.Size = new System.Drawing.Size(135, 29);
            this.btn_SortByName.TabIndex = 52;
            this.btn_SortByName.Text = "Sort By Name";
            this.btn_SortByName.UseVisualStyleBackColor = true;
            this.btn_SortByName.Click += new System.EventHandler(this.btn_SortByName_Click);
            // 
            // dgv_MemberList
            // 
            this.dgv_MemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MemberList.Location = new System.Drawing.Point(364, 88);
            this.dgv_MemberList.Name = "dgv_MemberList";
            this.dgv_MemberList.ReadOnly = true;
            this.dgv_MemberList.RowHeadersWidth = 51;
            this.dgv_MemberList.RowTemplate.Height = 29;
            this.dgv_MemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MemberList.Size = new System.Drawing.Size(662, 312);
            this.dgv_MemberList.TabIndex = 45;
            this.dgv_MemberList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_MemberList_CellDoubleClick);
            //this.dgv_MemberList.BindingContextChanged += new System.EventHandler(this.btn_Load_Click);
            // 
            // txt_FilterByCity
            // 
            this.txt_FilterByCity.Location = new System.Drawing.Point(806, 409);
            this.txt_FilterByCity.Name = "txt_FilterByCity";
            this.txt_FilterByCity.Size = new System.Drawing.Size(220, 27);
            this.txt_FilterByCity.TabIndex = 53;
            // 
            // txt_FIlterByCountry
            // 
            this.txt_FIlterByCountry.Location = new System.Drawing.Point(806, 444);
            this.txt_FIlterByCountry.Name = "txt_FIlterByCountry";
            this.txt_FIlterByCountry.Size = new System.Drawing.Size(220, 27);
            this.txt_FIlterByCountry.TabIndex = 54;
            // 
            // frmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 539);
            this.Controls.Add(this.txt_FIlterByCountry);
            this.Controls.Add(this.txt_FilterByCity);
            this.Controls.Add(this.dgv_MemberList);
            this.Controls.Add(this.btn_SortByName);
            this.Controls.Add(this.btn_FilterByCity);
            this.Controls.Add(this.btn_FilterByCountry);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_SearchValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_MemberName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_MemberID);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_MemberName);
            this.Controls.Add(this.lb_City);
            this.Controls.Add(this.lb_Country);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_MemberID);
            this.Name = "frmMemberManagement";
            this.Text = "frmMemberManagement";
            this.Load += new System.EventHandler(this.frmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Search;
        private TextBox txt_SearchValue;
        private Button btnClose;
        private Button btn_Delete;
        private Button btn_New;
        private Button btn_Load;
        private TextBox txt_Email;
        private TextBox txt_Country;
        private TextBox txt_City;
        private TextBox txt_MemberName;
        private TextBox txt_Password;
        private TextBox txt_MemberID;
        private Label lb_Email;
        private Label lb_MemberName;
        private Label lb_City;
        private Label lb_Country;
        private Label lb_Password;
        private Label lb_MemberID;
        private Button btn_FilterByCountry;
        private Button btn_FilterByCity;
        private Button btn_SortByName;
        private DataGridView dgv_MemberList;
        private TextBox txt_FilterByCity;
        private TextBox txt_FIlterByCountry;
    }
}