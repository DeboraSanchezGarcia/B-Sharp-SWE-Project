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
            if (!Program.LoggedIn)
            {
                LoginRequestForm loginRequestForm = new LoginRequestForm();
                loginRequestForm.Show();
                this.Close();
            }
            else
            {
                ReceiptForm receiptForm = new ReceiptForm();
                this.Close();
                receiptForm.Show();
            }
        }

        private void DetailsLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddressLabel_Click(object sender, EventArgs e)
        {

    string phoneNumber = LoginForm.AccountLogged;

    if (!string.IsNullOrWhiteSpace(phoneNumber))
    {
        var address = Address.ReadAddress(phoneNumber);

        if (address != null && !string.IsNullOrWhiteSpace(address.StreetAddress))
        {
            AddressLabel.Text = $"Address: {address.StreetAddress}, {address.City}, {address.State} {address.Zip}";
        }
        else
        {
            AddressLabel.Text = "Address not found.";
        }
    }
    else
    {
        AddressLabel.Text = "Invalid phone number.";
    }
}

        private void ContactInformationLabel_Click(object sender, EventArgs e)
        {
            var account = Account.ReadAccount(LoginForm.AccountLogged);

            if (account != null && !string.IsNullOrWhiteSpace(account.PhoneNumber))
            {
                ContactInformationLabel.Text = $"Phone Number: {account.PhoneNumber}";

                AddressLabel.Text = $"Address: {account.LastName}";
            }
            else
            {
                ContactInformationLabel.Text = "Error: Account not found.";
            }
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
            if (string.IsNullOrWhiteSpace(PaymentText.Text))
            {
                PaymentText.Text = "Payment information is required.";
            }
            else
            {
                PaymentText.Text = "Payment information entered.";
            }
        }

        private void TaxLabel_Click(object sender, EventArgs e)
        {
         
            double total = 0;
            foreach (LineItems lineItem in MainMenuForm.itemsOrdered)
            {
                total += Convert.ToDouble((lineItem.Price));
            }
            SubtotalLabel.Text = "$" + total;
            double taxes = total * .06;
            TaxLabel.Text = "$" + taxes;
            double deliveryFee = 4.99;
            DeliveryFeeLabel.Text = "$" + deliveryFee;
            TotalLabel.Text = "$" + (total + taxes + deliveryFee);

        }

        private void DeliveryFeeLabel_Click(object sender, EventArgs e)
        {
            double deliveryFee = order.OrderType == "Delivery" ? 4.99 : 0.00;
            DeliveryFeeLabel.Text = $"Delivery Fee: ${deliveryFee:F2}";
            foreach (LineItems lineItem in MainMenuForm.itemsOrdered) ;
        }
            private void TotalLabel_Click(object sender, EventArgs e)
        {
            if (MainMenuForm.itemsOrdered != null && MainMenuForm.itemsOrdered.Count > 0)
            {
                double total = 0;
                foreach (var item in MainMenuForm.itemsOrdered)
                {
                    total += Convert.ToDouble((LineItems.Price));
                }

                TotalLabel.Text = $"Total: ${total:F2}";
            }
            else
            {
                TotalLabel.Text = "No items in the order.";
            }
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
