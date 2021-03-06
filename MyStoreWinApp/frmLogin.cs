using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private readonly IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
            //Code Function for Login
            if(lb_Email.Text.Length == 0 || lb_Password.Text.Length == 0)
            {
                MessageBox.Show("Username Or Password is not valid");
                return;
            }
            try
            {
                base.OnLoad(e);
                var systemAccount = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("DefaultEmail").Get<Account>();
                
                var memberDetails = memberRepository.Login(txt_Email.Text, txt_Password.Text);
               
                if(txt_Email.Text.Equals(systemAccount.Email) && txt_Password.Text.Equals(systemAccount.Password))
                {

                    //direct to admin page
                    frmMemberManagement frmMemberManagement = new frmMemberManagement();
                    if (frmMemberManagement.ShowDialog() == DialogResult.Cancel)
                    {
                        MessageBox.Show("Goodbye! See you again!");
                    }
                }
                else if(memberDetails != null)
                {
                    
                    //direct to user page
                    frmMemberDetails frmMemberDetails = new frmMemberDetails
                    {
                        Text = "User Info",
                        InsertOrUpdate = true,
                        MemberDetails = memberDetails,
                        MemberRepository = memberRepository
                    };
                    if (frmMemberDetails.ShowDialog() == DialogResult.Cancel)
                    {
                        MessageBox.Show("Goodbye! See you again!");
                    }

                }
                else
                {
                    MessageBox.Show("Username Or Password not Found!!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Fail!!!");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Code Function for Exit
            Close();
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public class Account
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}