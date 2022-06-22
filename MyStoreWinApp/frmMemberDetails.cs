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
            var member = new MemberObject
            {
                MemberID = int.Parse(txt_MemberID.Text),
                MemberName = txt_MemberName.Text,
                Email = txt_Email.Text,
                Password = txt_Password.Text,
                City = txt_City.Text,
                Country = txt_Country.Text
            };
            if (InsertOrUpdate == true)
            {
                MemberRepository.UpdateMember(member);
            }
            MessageBox.Show("Update Success!!!");
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
