namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  //close the login window...
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if(txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtUserName_MouseEnter(object sender, EventArgs e)
        {
                if(txtUserName.Text == "User Name")
            {
                txtUserName.Clear();
            }
        }
    }
}
