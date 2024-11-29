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
    public partial class ShoppingCart : Form
    {
        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void ShoppingCartLabel_Click(object sender, EventArgs e)
        {

        }

        private void SubtotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Orders.DeleteOrder(Orders.nextOrderID);
            this.Close();
            MainMenuForm.instance.Show();
        }

        private void KeepShoppingButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm.instance.Show();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            CheckoutPageForm checkout = new CheckoutPageForm();
            this.Close();
            checkout.Show();
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {

        }

        private void item8Label_Click(object sender, EventArgs e)
        {

        }
    }
}
