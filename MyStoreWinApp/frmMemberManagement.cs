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

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
