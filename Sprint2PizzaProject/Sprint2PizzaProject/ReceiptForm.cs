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

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ItemLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ItemLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ItemLabel4_Click(object sender, EventArgs e)
        {

        }

        private void ItemLabel5_Click(object sender, EventArgs e)
        {

        }

        private void ItemLabel6_Click(object sender, EventArgs e)
        {

        }

        private void ItemLabel7_Click(object sender, EventArgs e)
        {

        }

        private void ItemLabel8_Click(object sender, EventArgs e)
        {

        }

        private void ItemLabel9_Click(object sender, EventArgs e)
        {

        }

        private void ItemLabel10_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel1_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel2_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel3_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel4_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel5_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel6_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel7_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel8_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel9_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel10_Click(object sender, EventArgs e)
        {

        }

        private void CountLabel1_Click(object sender, EventArgs e)
        {

        }

        private void CountLabel2_Click(object sender, EventArgs e)
        {

        }

        private void CountLabel3_Click(object sender, EventArgs e)
        {

        }

        private void CountLabel4_Click(object sender, EventArgs e)
        {

        }

        private void CountLabel5_Click(object sender, EventArgs e)
        {

        }

        private void CountLabel6_Click(object sender, EventArgs e)
        {

        }

        private void CountLabel7_Click(object sender, EventArgs e)
        {

        }

        private void CountLabel8_Click(object sender, EventArgs e)
        {

        }

        private void CountLabel9_Click(object sender, EventArgs e)
        {

        }

        private void CountLabel10_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel2_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel3_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel4_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel5_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel6_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel7_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel8_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel9_Click(object sender, EventArgs e)
        {

        }

        private void PriceLabel10_Click(object sender, EventArgs e)
        {

        }

        private void SubtotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void TaxesLabel_Click(object sender, EventArgs e)
        {

        }

        private void DeliveryFeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void GrandTotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignatureLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReceiptPageLabel_Click(object sender, EventArgs e)
        {

        }

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
            double total = 0;
            foreach (LineItems lineItem in MainMenuForm.itemsOrdered)
            {
                total += Convert.ToDouble((lineItem.Price));
            }
            SubtotalLabel.Text = "$" + total;
            double taxes = total * .06;
            TaxesLabel.Text = "$" + taxes;
            double deliveryFee = 4.99;
            DeliveryFeeLabel.Text = "$" + deliveryFee;
            GrandTotalLabel.Text = "$" + (total + taxes + deliveryFee);

        }
        private void SetItems(int x, ref Label label1, ref Label label2, ref Label label3, ref Label label4, ArrayList itemsOrdered)
        {
            if(MainMenuForm.itemsOrdered.Count > x)
            {
                label2.Text = ((LineItems)itemsOrdered[x]).Description;
                label3.Text = "x" + ((LineItems)itemsOrdered[x]).Quantity.ToString();
                label4.Text = "$" + ((LineItems)itemsOrdered[x]).Price.ToString();
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
