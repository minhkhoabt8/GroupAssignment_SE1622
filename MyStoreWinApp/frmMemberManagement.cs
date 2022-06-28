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
using BusinessObject;
namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source = null;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Add new member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
               
            }
        }//end btn_New_Click

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberID);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete member");
            }
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
                txt_Password.DataBindings.Clear();
                txt_City.DataBindings.Clear();
                txt_Country.DataBindings.Clear();

                txt_MemberID.DataBindings.Add("Text", source, "MemberID");
                txt_MemberName.DataBindings.Add("Text", source, "MemberName");
                txt_Email.DataBindings.Add("Text", source, "Email");
                txt_Password.DataBindings.Add("Text", source, "Password");
                txt_City.DataBindings.Add("Text", source, "City");
                txt_Country.DataBindings.Add("Text", source, "Country");


                dgv_MemberList.DataSource = null;
                dgv_MemberList.DataSource = source;
                
                if (resultList.Count == 0)
                {
                    ClearText();
                    btn_Delete.Enabled = false;
                }
                else btn_Delete.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search");
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
            btn_Delete.Enabled = false;
            dgv_MemberList.CellDoubleClick += Dgv_MemberList_CellDoubleClick;
        }
        private MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject
                {
                    MemberID = int.Parse(txt_MemberID.Text),
                    MemberName = txt_MemberName.Text,
                    Email = txt_Email.Text,
                    Password = txt_Password.Text,
                    City = txt_City.Text,
                    Country = txt_Country.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }
        private void Dgv_MemberList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberDetails = GetMemberObject(),
                MemberRepository = memberRepository

            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }

        }
        public void LoadMemberList()
        {
            var members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

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
                dgv_MemberList.DataSource = source;

                if (members.Count == 0)
                {
                    ClearText();
                    btn_Delete.Enabled = false;
                }
                else btn_Delete.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }

        }
        public void LoadMemberListSortByName()
        {
            var members = memberRepository.GetMembersSortByMemberName(); 
            try
            {
                source = new BindingSource();
                source.DataSource = members;

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
                dgv_MemberList.DataSource = source;

                if (members.Count == 0)
                {
                    ClearText();
                    btn_Delete.Enabled = false;
                }
                else btn_Delete.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search No Result for Member");
            }

        }


        private void btn_FilterByCountry_Click(object sender, EventArgs e)
        {

        }

        private void btn_FilterByCity_Click(object sender, EventArgs e)
        {
            var resultList = memberRepository.Search(txt_FilterByCity.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = resultList;

                txt_MemberID.DataBindings.Clear();
                txt_MemberName.DataBindings.Clear();
                txt_Email.DataBindings.Clear();
                txt_Password.DataBindings.Clear();
                txt_City.DataBindings.Clear();
                txt_Country.DataBindings.Clear();

                txt_MemberID.DataBindings.Add("Text", source, "MemberID");
                txt_MemberName.DataBindings.Add("Text", source, "MemberName");
                txt_Email.DataBindings.Add("Text", source, "Email");
                txt_Password.DataBindings.Add("Text", source, "Password");
                txt_City.DataBindings.Add("Text", source, "City");
                txt_Country.DataBindings.Add("Text", source, "Country");


                dgv_MemberList.DataSource = null;
                dgv_MemberList.DataSource = source;

                if (resultList.Count == 0)
                {
                    ClearText();
                    btn_Delete.Enabled = false;
                }
                else btn_Delete.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Filter by City");
            }
        }

        private void btn_SortByName_Click(object sender, EventArgs e)
        {
            LoadMemberListSortByName();
        }

       
    }
}
