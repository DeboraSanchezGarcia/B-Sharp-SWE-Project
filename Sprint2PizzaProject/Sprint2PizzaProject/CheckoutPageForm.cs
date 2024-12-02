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
        string phoneNumber = "";
        string orderType = "";
        string paymentType = "";
        double subtotal = 0;
        double tax = 0;
        double total = 0;
        string date = "";
        bool isFavorite = false;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            Orders order = new Orders(phoneNumber, orderType, paymentType, subtotal, tax, total, date,isFavorite);
            Orders.CreateOrder(order);
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
            orderType = "Delivery";
        }

        private void CarryOutOptionButton_Click(object sender, EventArgs e)
        {
            orderType = "Take-out";
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
            if (!Program.LoggedIn)
            {
                LoginRequestForm loginRequestForm = new LoginRequestForm();
                loginRequestForm.Show();
                this.Close();
            }

            //Account
            Account account = Account.ReadAccount(LoginForm.AccountLogged);
            ContactInformationLabel.Text = $"Phone Number: {account.PhoneNumber}";
            phoneNumber = account.PhoneNumber;
            Address address = Address.ReadAddress(account.PhoneNumber);
            AddressLabel.Text = $"Address: {address.StreetAddress} \n{address.City} , {address.State} \n{address.Zip}";
            
            //Total
            double total = 0;
            foreach (LineItems lineItem in MainMenuForm.itemsOrdered)
            {
                total += Convert.ToDouble((lineItem.Price));
            }
            subtotal = total;
            string totalString = String.Format("{0,2}", total);
            SubtotalLabel.Text = "Total: $"+ totalString;
            double taxes = total * .06;
            tax = taxes;
            string tax1= String.Format("{0:F2}", taxes);
            TaxLabel.Text = "Tax: $" + tax1;
            double deliveryFee;
            if (orderType.Equals("Delivery"))
            {
                deliveryFee = 4.99;
            }
            else
            {
                deliveryFee = 0;
                DeliveryFeeLabel.Hide();
            }
            deliveryFee = deliveryFee;
            string deliveryString = String.Format("{0:F2}", deliveryFee);
            DeliveryFeeLabel.Text = "DeliveryFee: $" + deliveryString;
            string grandTotal = String.Format("{0:F2}", (total + taxes + deliveryFee));
            TotalLabel.Text = "Total: $" +grandTotal;
            total = (total + taxes + deliveryFee);
            date = (DateOnly.FromDateTime(DateTime.Now)).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                paymentType = "Cash";
                cardLast4Label.Hide();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                paymentType = "Card";
                CreditCard card = CreditCard.ReadCreditCard(phoneNumber);
                cardLast4Label.Text = "********" + card.Last4Digit;
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                paymentType = "Check";
                cardLast4Label.Hide();
            }
            else
            {
                SelectPayment selectPayment = new SelectPayment();
                selectPayment.Show();
            }
        }
    }
}
