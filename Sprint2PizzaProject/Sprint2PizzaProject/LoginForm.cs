namespace Sprint2PizzaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loginPanel.Show();
            //mainMenuPanel.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {
            emailLabel.Show();
            emailTextBox.Show();
            emailResponse.Show();
            passwordLabel.Show();
            passwordTextBox.Show();
            passwordResponse.Show();
            loginSubmit.Show();
            loginCancel.Show();
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void emailResponse_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void passwordResponse_Click(object sender, EventArgs e)
        {

        }

        private void loginSubmit_Click(object sender, EventArgs e)
        {
            Account account = Account.ReadAccount(emailTextBox.Text);
            if ((!emailTextBox.Text.Equals(account.PhoneNumber)) && (!emailTextBox.Text.Equals(account.Email)))
            {
                emailResponse.Text = "Account with this email or phone number does not exist";

            }
            else if (!passwordTextBox.Text.Equals(account.Password))
            {
                emailResponse.Text = "";
                passwordResponse.Text = "Password incorrect";
            }
            else
            {
                passwordResponse.Text = "";
                //mainMenuPanel.Show();
                loginPanel.Hide();
            }
        }

        private void loginCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mainMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
