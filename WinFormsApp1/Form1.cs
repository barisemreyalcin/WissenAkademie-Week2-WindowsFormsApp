namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string message = $"Username: {username}\n" +
                $"Password: {password}";
            MessageBox.Show(message, "User information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation );
        }
    }
}
