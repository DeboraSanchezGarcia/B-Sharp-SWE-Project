using System.Xml.Schema;

namespace Sprint2PizzaProject
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Holds phone number or email for the account logged in
        /// </summary>
        private static string accountLogged = "";
        /// <summary>
        /// Holds a value to say if the loggin came from the request error
        /// </summary>
        private static bool fromRequest = false;
        /// <summary>
        /// Submits login. Checks if account exist and if password is correct.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginSubmit_Click(object sender, EventArgs e)
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
        /// <summary>
        /// Cancels login closes the screen and returns to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm.instance.Show();
            this.Close();
        }
        /// <summary>
        /// Getter and setter for accountLogged
        /// </summary>
        public static string AccountLogged
        {
            get { return accountLogged; }
            set { accountLogged = value; }
        }
        /// <summary>
        /// Getter and setter for fromRequest
        /// </summary>
        public static bool FromRequest
        {
            get { return fromRequest; }
            set { fromRequest = value; }
        }
    }
}
