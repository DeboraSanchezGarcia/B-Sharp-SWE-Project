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

        private void confirmRequestButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            LoginForm.FromRequest = true;
            this.Close();
            login.Show();
        }

        private void cancelRequestButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
