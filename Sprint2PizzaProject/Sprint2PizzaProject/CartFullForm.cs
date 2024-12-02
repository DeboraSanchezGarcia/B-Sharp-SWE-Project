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
        /// <summary>
        /// Closes error and continues to check out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void continueToCheckoutButton_Click(object sender, EventArgs e)
        {
            CheckoutPageForm checkout = new CheckoutPageForm();
            checkout.Show();
            MainMenuForm.instance.Hide();
            this.Close();
        }
        /// <summary>
        /// Closes error and returns to cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnToCartButton_Click(object sender, EventArgs e)
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Show();
            MainMenuForm.instance.Hide();
            this.Close();
        }
    }
}
