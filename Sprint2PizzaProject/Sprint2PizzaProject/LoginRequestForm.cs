using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint2PizzaProject
{
    public partial class LoginRequestForm : Form
    {
        public LoginRequestForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sends user to login screen. Closes error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirmRequestButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Close();
            login.Show();
        }
        /// <summary>
        /// Returns user to previous page. Closes error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelRequestButton_Click(object sender, EventArgs e)
        {
            MainMenuForm.instance.Show();
            this.Close();
        }
    }
}
