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
    public partial class CustomOrder : Form
    {
        public CustomOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomOrder_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CrustTypePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm.instance.Show();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            LineItems lineItems = new LineItems();
            double price = 0.00;
            if (crustComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID1 = 29;
            }
            else if (crustComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID1 = 30;
            }
            else if (crustComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID1 = 31;
            }
            else if (crustComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID1 = 32;
            }

            if (crustOptionComboBox.SelectedIndex == 0)
            {
                lineItems.OptionID1 = 1;
            }
            else if (crustOptionComboBox.SelectedIndex == 1)
            {
                lineItems.OptionID1 = 2;
            }
            else if (crustOptionComboBox.SelectedIndex == 2)
            {
                lineItems.OptionID1 = 3;
            }
            else if (crustComboBox.SelectedIndex == 3)
            {
                lineItems.OptionID1 = 4;
            }

            if (topping1ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping1ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID2 = 6;
            }
            else if (topping1ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID2 = 7;
            }
            else if (topping1ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID2 = 8;
            }
            else if (topping1ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID2 = 9;
            }
            else if (topping1ComboBox.SelectedIndex == 5)
            {
                lineItems.ItemID2 = 10;
            }
            else if (topping1ComboBox.SelectedIndex == 6)
            {
                lineItems.ItemID2 = 11;
            }
            else if (topping1ComboBox.SelectedIndex == 7)
            {
                lineItems.ItemID2 = 12;
            }
            else if (topping1ComboBox.SelectedIndex == 8)
            {
                lineItems.ItemID2 = 13;
            }
            else if (topping1ComboBox.SelectedIndex == 9)
            {
                lineItems.ItemID2 = 14;
            }
            else if (topping1ComboBox.SelectedIndex == 10)
            {
                lineItems.ItemID2 = 15;
            }
            else if (topping1ComboBox.SelectedIndex == 11)
            {
                lineItems.ItemID2 = 16;
            }
            else if (topping1ComboBox.SelectedIndex == 12)
            {
                lineItems.ItemID2 = 17;
            }
            else if (topping1ComboBox.SelectedIndex == 13)
            {
                lineItems.ItemID2 = 18;
            }

            if(topping1OptionComboBox.SelectedIndex == 0)
            {

            }
            else if(topping1OptionComboBox.SelectedIndex == 1)
            {

            }
            else if(topping1OptionComboBox.SelectedIndex == 2)
            {

            }

            if (topping2ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 5)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 6)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 7)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 8)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 9)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 10)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 11)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 12)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping2ComboBox.SelectedIndex == 13)
            {
                lineItems.ItemID2 = 5;
            }

            if (topping2OptionComboBox.SelectedIndex == 0)
            {
                
            }
            else if (topping2OptionComboBox.SelectedIndex == 1)
            {
                
            }
            else if (topping2OptionComboBox.SelectedIndex == 2)
            {

            }

            if (topping3ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 5)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 6)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 7)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 8)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 9)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 10)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 11)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 12)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping3ComboBox.SelectedIndex == 13)
            {
                lineItems.ItemID2 = 5;
            }

            if (topping3OptionComboBox.SelectedIndex == 0)
            {

            }
            else if (topping3OptionComboBox.SelectedIndex == 1)
            {

            }
            else if (topping3OptionComboBox.SelectedIndex == 2)
            {

            }

            if (topping4ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 5)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 6)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 7)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 8)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 9)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 10)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 11)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 12)
            {
                lineItems.ItemID2 = 5;
            }
            else if (topping4ComboBox.SelectedIndex == 13)
            {
                lineItems.ItemID2 = 5;
            }

            if (topping4OptionComboBox.SelectedIndex == 0)
            {

            }
            else if (topping4OptionComboBox.SelectedIndex == 1)
            {

            }
            else if (topping4OptionComboBox.SelectedIndex == 2)
            {

            }

            if (cheese1ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID2 = 5;
            }
            else if (cheese1ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID2 = 5;
            }
            else if (cheese1ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID2 = 5;
            }
            else if (cheese1ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID2 = 5;
            }
            else if (cheese1ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID2 = 5;
            }

            if (cheese1OptionComboBox.SelectedIndex == 0)
            {

            }
            else if (cheese1OptionComboBox.SelectedIndex == 1)
            {

            }
            else if (cheese1OptionComboBox.SelectedIndex == 2)
            {

            }

            if (cheese2ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID2 = 5;
            }
            else if (cheese2ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID2 = 5;
            }
            else if (cheese2ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID2 = 5;
            }
            else if (cheese2ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID2 = 5;
            }
            else if (cheese2ComboBox.SelectedIndex == 4)
            {

            }

            if (cheese2OptionComboBox.SelectedIndex == 0)
            {

            }
            else if (cheese2OptionComboBox.SelectedIndex == 1)
            {

            }
            else if (cheese2OptionComboBox.SelectedIndex == 2)
            {

            }

            if (quantityComboBox.SelectedIndex == 0)
            {
                lineItems.Quantity = 1;
            }
            else if(quantityComboBox.SelectedIndex == 1)
            {
                lineItems.Quantity = 2;
            }
            else if (quantityComboBox.SelectedIndex == 2)
            {
                lineItems.Quantity = 3;
            }
            else if (quantityComboBox.SelectedIndex == 3)
            {
                lineItems.Quantity = 4;
            }
            else if(quantityComboBox.SelectedIndex == 4)
            {
                lineItems.Quantity = 5;
            }
            this.Close();
            MainMenuForm.instance.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void topping1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void topping2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void topping3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void topping4ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cheese1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cheese2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crustOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void topping1OptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void topping2OptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void topping3OptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void topping4OptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cheese1OptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cheese2OptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void quantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
