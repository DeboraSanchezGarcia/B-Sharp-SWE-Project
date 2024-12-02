using System;
using System.Collections;
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
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Sets all of the text on the reciept upon load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            SetItems(0, ref ItemLabel1, ref DescriptionLabel1, ref CountLabel1, ref PriceLabel1, MainMenuForm.itemsOrdered);
            SetItems(1, ref ItemLabel2, ref DescriptionLabel2, ref CountLabel2, ref PriceLabel2, MainMenuForm.itemsOrdered);
            SetItems(2, ref ItemLabel3, ref DescriptionLabel3, ref CountLabel3, ref PriceLabel3, MainMenuForm.itemsOrdered);
            SetItems(3, ref ItemLabel4, ref DescriptionLabel4, ref CountLabel4, ref PriceLabel4, MainMenuForm.itemsOrdered);
            SetItems(4, ref ItemLabel5, ref DescriptionLabel5, ref CountLabel5, ref PriceLabel5, MainMenuForm.itemsOrdered);
            SetItems(5, ref ItemLabel6, ref DescriptionLabel6, ref CountLabel6, ref PriceLabel6, MainMenuForm.itemsOrdered);
            SetItems(6, ref ItemLabel7, ref DescriptionLabel7, ref CountLabel7, ref PriceLabel7, MainMenuForm.itemsOrdered);
            SetItems(7, ref ItemLabel8, ref DescriptionLabel8, ref CountLabel8, ref PriceLabel8, MainMenuForm.itemsOrdered);
            SetItems(8, ref ItemLabel9, ref DescriptionLabel9, ref CountLabel9, ref PriceLabel9, MainMenuForm.itemsOrdered);
            SetItems(9, ref ItemLabel10, ref DescriptionLabel10, ref CountLabel10, ref PriceLabel10, MainMenuForm.itemsOrdered);
            Orders order = Orders.ReadOrder(Orders.NextOrderID - 1);
            double deliveryFee = 0.00;
            if (order.OrderType.Equals("Delivery"))
            {
                deliveryFee = 4.99;
            }
            double total = 0.00;
            foreach (LineItems lineItem in MainMenuForm.itemsOrdered)
            {
                total += Convert.ToDouble((lineItem.Price));
            }
            string subtotal = String.Format("{0:F2}", total);
            SubtotalLabel.Text = "Subtotal: $" + subtotal;
            double taxes = total * .06;
            string tax = String.Format("{0:F2}", taxes);
            TaxesLabel.Text = "Tax: $" + tax;
            string deliveryFeeString = String.Format("{0:F2}", deliveryFee);
            DeliveryFeeLabel.Text = "Delivery Fee: $" + deliveryFeeString;
            string grandTotal = String.Format("{0:F2}", (total + taxes + deliveryFee));
            GrandTotalLabel.Text = "Total: $" + grandTotal;
            paymentTypeLabel.Text = order.PaymentType;
            if (order.PaymentType.Equals("Card"))
            {
                CreditCard card = CreditCard.ReadCreditCard(order.PhoneNumber);
                cardLast4Label.Text = "********" + card.Last4Digit;
            }
            else
            {
                cardLast4Label.Hide();
            }
        }
        /// <summary>
        /// Method to set item text if that number item is ordered and hide the labels if not
        /// </summary>
        /// <param name="x"></param>
        /// <param name="label1"></param>
        /// <param name="label2"></param>
        /// <param name="label3"></param>
        /// <param name="label4"></param>
        /// <param name="itemsOrdered"></param>
        private void SetItems(int x, ref Label label1, ref Label label2, ref Label label3, ref Label label4, ArrayList itemsOrdered)
        {
            if (MainMenuForm.itemsOrdered.Count > x)
            {
                label2.Text = ((LineItems)itemsOrdered[x]).Description;
                label3.Text = "x" + ((LineItems)itemsOrdered[x]).Quantity.ToString();
                string price = String.Format("{0:2}", (((LineItems)itemsOrdered[x]).Price));
                label4.Text = "$" + price;
            }
            else
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
            }
        }
    }
}
