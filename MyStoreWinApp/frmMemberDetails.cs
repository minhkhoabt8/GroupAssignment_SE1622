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
                        Email = txt_Email.Text.Trim(),
                        Password = txt_Password.Text.Trim(),
                        City = txt_City.Text.Trim(),
                        Country = txt_Country.Text.Trim()
                    };
                    if (InsertOrUpdate == false)//If InsertOrUpdate == false => Insert a new member
                    {
                        MemberRepository.InsertMember(member);
                    }
                    else
                    {
                        //Update a member
                        //Code here!
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
        }//end btn_Save_Click

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
