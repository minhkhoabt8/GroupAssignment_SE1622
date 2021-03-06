using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public bool InsertOrUpdate { get; set; }
        public MemberObject MemberDetails { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txt_MemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txt_MemberID.Text = MemberDetails.MemberID.ToString();
                txt_MemberName.Text = MemberDetails.MemberName;
                txt_Email.Text = MemberDetails.Email;
                txt_Password.Text = MemberDetails.Password;
                txt_City.Text = MemberDetails.City;
                txt_Country.Text = MemberDetails.Country;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool validation = true;
            if (txt_MemberID.Text.Trim().Length == 0)
            {
                errorProviderMemberID.SetError(txt_MemberID, "Your member ID must contain at least 1 character!");
                validation = false;
            }
            else
            {
                errorProviderMemberID.SetError(txt_MemberID, "");
            }

            if (txt_MemberName.Text.Trim().Length == 0)
            {
                errorProviderMemberName.SetError(txt_MemberName, "Your member name must contain at least 1 character!");
                validation = false;
            }
            else
            {
                errorProviderMemberName.SetError(txt_MemberName, "");
            }
            if (txt_Email.Text.Trim().Length == 0)
            {
                errorProviderEmail.SetError(txt_Email, "Your email must contain at least 1 character!");
                validation = false;
            }
            else
            {
                if (!txt_Email.Text.Trim().Contains("@gmail.com"))
                {
                    errorProviderEmail.SetError(txt_Email, "Your email is invalid");
                    validation = false;
                }
                /*else
                {
                    if (MemberRepository.CheckDuplicateEmail(txt_Email.Text.Trim().ToLower()))
                    {
                        errorProviderEmail.SetError(txt_Email, "Your email has been existed!");
                        validation = false;
                    }
                    
                }*/
                else
                {
                    errorProviderEmail.SetError(txt_Email, "");
                }
            }
            if (txt_Password.Text.Trim().Length == 0)
            {
                errorProviderPassword.SetError(txt_Password, "Your password must contain at least 1 character!");
                validation = false;
            }
            else
            {
                errorProviderPassword.SetError(txt_Password, "");
            }
            if (txt_City.Text.Trim().Length == 0)
            {
                errorProviderCity.SetError(txt_City, "Your city must contain at least 1 character!");
                validation = false;
            }
            else
            {
                errorProviderCity.SetError(txt_City, "");
            }
            if (txt_Country.Text.Trim().Length == 0)
            {
                errorProviderCountry.SetError(txt_Country, "Your country must contain at least 1 character!");
                validation = false;
            }
            else
            {
                errorProviderCountry.SetError(txt_Country, "");
            }
            try
            {
                if (validation)
                {
                    var member = new MemberObject
                    {
                        MemberID = int.Parse(txt_MemberID.Text),
                        MemberName = txt_MemberName.Text.Trim(),
                        Email = txt_Email.Text.Trim().ToLower(),
                        Password = txt_Password.Text.Trim(),
                        City = txt_City.Text.Trim(),
                        Country = txt_Country.Text.Trim()
                    };
                    if (InsertOrUpdate == false)//If InsertOrUpdate == false => Insert a new member
                    {
                        MemberRepository.InsertMember(member);
                        MessageBox.Show("Insert Success !!!");
                    }
                    else
                    {
                        MemberRepository.UpdateMember(member);
                        MessageBox.Show("Update Success !!!");
                    }
                }
                else
                {
                    //Avoid the Member Details form to close
                    this.DialogResult = DialogResult.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
            }
        }

       


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
