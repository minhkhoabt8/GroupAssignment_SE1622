using DataAccess.Repository;

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
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Code Function for Exit
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}