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
    public partial class MainMenuForm : Form
    {
        public static MainMenuForm instance;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void toLoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            instance = this;
            loginForm.Show();
            this.Hide();
        }

        private void MainMenuPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cheeseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void veggieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pepperoniComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void meatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cheeseAddButton_Click(object sender, EventArgs e)
        {

        }

        private void veggieAddButton_Click(object sender, EventArgs e)
        {

        }

        private void pepperoniAddButton_Click(object sender, EventArgs e)
        {

        }

        private void meatAddButton_Click(object sender, EventArgs e)
        {

        }

        private void drinkTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drinkOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createOwnButton_Click(object sender, EventArgs e)
        {
            CustomOrder customOrderForm = new CustomOrder();
            customOrderForm.Show();
            this.Hide();
        }

        private void toCartButton_Click(object sender, EventArgs e)
        {
            ShoppingCart cartForm = new ShoppingCart();
            cartForm.Show();
            this.Hide();
        }

        private void toCheckOutButton_Click(object sender, EventArgs e)
        {
            CheckoutPageForm checkOutForm = new CheckoutPageForm();
            checkOutForm.Show();
            this.Hide();
        }
    }
}
