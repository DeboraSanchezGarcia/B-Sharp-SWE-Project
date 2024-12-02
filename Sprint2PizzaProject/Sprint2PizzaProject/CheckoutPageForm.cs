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
    public partial class CheckoutPageForm : Form
    {
        public CheckoutPageForm()
        {
            InitializeComponent();
        }

        static Orders order = new Orders();
        private static int id = order.OrderID;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            ReceiptForm receiptForm = new ReceiptForm();
            this.Close();
            receiptForm.Show();
        }

        private void DetailsLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void ContactInformationLabel_Click(object sender, EventArgs e)
        {

        }

        private void DeliveryOptionButton_Click(object sender, EventArgs e)
        {
   
            order.OrderType = "Delivery";
        }

        private void CarryOutOptionButton_Click(object sender, EventArgs e)
        {
            order.OrderType = "Take-out";
        }

        private void PaymentLabel_Click(object sender, EventArgs e)
        {

        }

        private void PaymentText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaxLabel_Click(object sender, EventArgs e)
        {

        }

        private void DeliveryFeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChangeOrderButton_Click(object sender, EventArgs e)
        {
            MainMenuForm.instance.Show();
            this.Close();
        }

        private void CheckoutPageForm_Load(object sender, EventArgs e)
        {
            DetailsLabel.Text = MainMenuForm.instance.Text;
        }

        public static int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
