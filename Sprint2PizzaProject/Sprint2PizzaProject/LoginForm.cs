namespace Sprint2PizzaProject
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private static string accountLogged = "";
        private static bool fromRequest = false;
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {
            
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
            if (fromRequest)
            {
                Account account = Account.ReadAccount(emailTextBox.Text);
                string phoneEmail = emailTextBox.Text;
                string password = passwordTextBox.Text;
                if ((!phoneEmail.Equals(account.PhoneNumber)) && (!phoneEmail.Equals(account.Email)))
                {
                    emailResponse.Text = "Account with this email or phone number does not exist";

                }
                else if (!password.Equals(account.Password))
                {
                    emailResponse.Text = "";
                    passwordResponse.Text = "Password incorrect";
                }
                else
                {
                    accountLogged = phoneEmail;
                    Program.LoggedIn = true;
                    CheckoutPageForm checkoutPageForm = new CheckoutPageForm();
                    checkoutPageForm.Show();
                    this.Close();
                }
            }
            else
            {
                Account account = Account.ReadAccount(emailTextBox.Text);
                string phoneEmail = emailTextBox.Text;
                string password = passwordTextBox.Text;
                if ((!phoneEmail.Equals(account.PhoneNumber)) && (!phoneEmail.Equals(account.Email)))
                {
                    emailResponse.Text = "Account with this email or phone number does not exist";

                }
                else if (!password.Equals(account.Password))
                {
                    emailResponse.Text = "";
                    passwordResponse.Text = "Password incorrect";
                }
                else
                {
                    accountLogged = phoneEmail;
                    Program.LoggedIn = true;
                    MainMenuForm.instance.Show();
                    this.Close();
                }
            }
        }

        private void loginCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm.instance.Show();
            this.Close();
        }

        public static string AccountLogged
        {
            get { return accountLogged; }
            set { accountLogged = value; }
        }
        public static bool FromRequest
        {
            get { return fromRequest; }
            set { fromRequest = value; }
        }
    }
}
