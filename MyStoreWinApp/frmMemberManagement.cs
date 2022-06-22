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
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {

        }

        private void btn_New_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var resultList = memberRepository.Search(txt_SearchValue.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = resultList;

                txt_MemberID.DataBindings.Clear();
                txt_MemberName.DataBindings.Clear();
                txt_Email.DataBindings.Clear();
                txt_City.DataBindings.Clear();
                txt_Password.DataBindings.Clear();
                txt_Country.DataBindings.Clear();

                txt_MemberID.DataBindings.Add("Text", source, "MemberID");
                txt_MemberName.DataBindings.Add("Text", source, "MemberName");
                txt_Email.DataBindings.Add("Text", source, "Email");
                txt_Password.DataBindings.Add("Text", source, "Password");
                txt_City.DataBindings.Add("Text", source, "City");
                txt_Country.DataBindings.Add("Text", source, "Country");

                dgv_MemberList.DataSource = null;
                dgv_MemberList.DataSource = resultList;
                if (resultList.Count == 0)
                {
                    ClearText();
                    btn_Delete.Enabled = false;
                }
                else btn_Delete.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Search Noresult for Member");
            }

        }

        private void ClearText()
        {
            txt_MemberID.Text = string.Empty;
            txt_MemberName.Text = string.Empty;
            txt_Email.Text = string.Empty;
            txt_Password.Text = string.Empty;
            txt_City.Text = string.Empty;
            txt_Country.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {

        }

        private void btn_FilterByCountry_Click(object sender, EventArgs e)
        {

        }

        private void btn_FilterByCity_Click(object sender, EventArgs e)
        {

        }

        private void btn_SortByName_Click(object sender, EventArgs e)
        {

        }
    }
}
