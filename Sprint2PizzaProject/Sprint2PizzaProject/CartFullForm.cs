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
    public partial class CartFullForm : Form
    {
        public CartFullForm()
        {
            InitializeComponent();
        }

        private void continueToCheckoutButton_Click(object sender, EventArgs e)
        {
            CheckoutPageForm checkout = new CheckoutPageForm();
            checkout.Show();
            MainMenuForm.instance.Hide();
            this.Close();
        }

        private void returnToCartButton_Click(object sender, EventArgs e)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Show();
            MainMenuForm.instance.Hide();
            this.Close();
        }

        private void CartFullForm_Load(object sender, EventArgs e)
        {

        }
    }
}
