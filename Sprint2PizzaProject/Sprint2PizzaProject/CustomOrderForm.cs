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

        private double currentPrice = 0.00;
        private int orderID = Orders.nextOrderID;

        private void CustomOrder_Load(object sender, EventArgs e)
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
            double itemPrice1 = 0;
            double optionPrice1 = 0;
            double price1;
            double itemPrice2 = 0;
            double optionPrice2 = 0;
            double price2;
            double itemPrice3 = 0;
            double optionPrice3 = 0;
            double price3;
            double itemPrice4 = 0;
            double optionPrice4 = 0;
            double price4;
            double itemPrice5 = 0;
            double optionPrice5 = 0;
            double price5;
            double itemPrice6 = 0;
            double optionPrice6 = 0;
            double price6;
            double itemPrice7 = 0;
            double optionPrice7 = 0;
            double price7;
            double total;
            if (crustComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID1 = 29;
                itemPrice1 = .50;
            }
            else if (crustComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID1 = 30;
                itemPrice1 = .50;
            }
            else if (crustComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID1 = 31;
                itemPrice1 = 1.00;
            }
            else if (crustComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID1 = 32;
                itemPrice1 = 1.50;
            }

            if (crustOptionComboBox.SelectedIndex == 0)
            {
                lineItems.OptionID1 = 1;
                optionPrice1 = 6.99;
            }
            else if (crustOptionComboBox.SelectedIndex == 1)
            {
                lineItems.OptionID1 = 2;
                optionPrice1 = 8.99;
            }
            else if (crustOptionComboBox.SelectedIndex == 2)
            {
                lineItems.OptionID1 = 3;
                optionPrice1 = 9.99;
            }
            else if (crustComboBox.SelectedIndex == 3)
            {
                lineItems.OptionID1 = 4;
                optionPrice1 = 11.99;
            }
            price1 = itemPrice1 + optionPrice1;

            if (topping1ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID2 = 5;
                itemPrice2 = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID2 = 6;
                itemPrice2 = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID2 = 7;
                itemPrice2 = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID2 = 8;
                itemPrice2 = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID2 = 9;
                itemPrice2 = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 5)
            {
                lineItems.ItemID2 = 10;
                itemPrice2 = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 6)
            {
                lineItems.ItemID2 = 11;
                itemPrice2 = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 7)
            {
                lineItems.ItemID2 = 12;
                itemPrice2 = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 8)
            {
                lineItems.ItemID2 = 13;
                itemPrice2 = .50;
            }
            else if (topping1ComboBox.SelectedIndex == 9)
            {
                lineItems.ItemID2 = 14;
                itemPrice2 = .50;
            }
            else if (topping1ComboBox.SelectedIndex == 10)
            {
                lineItems.ItemID2 = 15;
                itemPrice2 = .50;
            }
            else if (topping1ComboBox.SelectedIndex == 11)
            {
                lineItems.ItemID2 = 16;
                itemPrice2 = .50;
            }
            else if (topping1ComboBox.SelectedIndex == 12)
            {
                lineItems.ItemID2 = 17;
                itemPrice2 = .50;
            }
            else if (topping1ComboBox.SelectedIndex == 13)
            {
                lineItems.ItemID2 = 18;
                itemPrice2 = .50;
            }

            if(topping1OptionComboBox.SelectedIndex == 0)
            {
                if ((topping1ComboBox.SelectedIndex != 13 || topping1ComboBox.SelectedIndex != 14 || topping1ComboBox.SelectedIndex != 15 || topping1ComboBox.SelectedIndex != 16 || topping1ComboBox.SelectedIndex != 17 || topping1ComboBox.SelectedIndex != 18))
                {
                    lineItems.OptionID2 = 6;
                }
                else
                {
                    lineItems.OptionID2 = 8;
                }
                optionPrice2 = 1;
            }
            else if(topping1OptionComboBox.SelectedIndex == 1)
            {
                lineItems.OptionID2 = 5;
                optionPrice2 = 1;
            }
            else if (topping1OptionComboBox.SelectedIndex == 2)
            {
                if ((topping1ComboBox.SelectedIndex != 13 || topping1ComboBox.SelectedIndex != 14 || topping1ComboBox.SelectedIndex != 15 || topping1ComboBox.SelectedIndex != 16 || topping1ComboBox.SelectedIndex != 17 || topping1ComboBox.SelectedIndex != 18))
                {
                    lineItems.OptionID2 = 7;
                }
                else
                {
                    lineItems.OptionID2 = 9;
                }
                optionPrice2 = 2;
            }
            price2 = itemPrice2 * optionPrice2;

            if (topping2ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID3 = 5;
                itemPrice3 = .99;
            }
            else if (topping2ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID3 = 6;
                itemPrice3 = .99;
            }
            else if (topping2ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID3 = 7;
                itemPrice3 = .99;

            }
            else if (topping2ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID3 = 8;
                itemPrice3 = .99;

            }
            else if (topping2ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID3 = 9;
                itemPrice3 = .99;

            }
            else if (topping2ComboBox.SelectedIndex == 5)
            {
                lineItems.ItemID3 = 10;
                itemPrice3 = .99;

            }
            else if (topping2ComboBox.SelectedIndex == 6)
            {
                lineItems.ItemID3 = 11;
                itemPrice3 = .99;

            }
            else if (topping2ComboBox.SelectedIndex == 7)
            {
                lineItems.ItemID3 = 12;
                itemPrice3 = .99;

            }
            else if (topping2ComboBox.SelectedIndex == 8)
            {
                lineItems.ItemID3 = 13;
                itemPrice3 = .50;
            }
            else if (topping2ComboBox.SelectedIndex == 9)
            {
                lineItems.ItemID3 = 14;
                itemPrice3 = .50;
            }
            else if (topping2ComboBox.SelectedIndex == 10)
            {
                lineItems.ItemID3 = 15;
                itemPrice3 = .50;
            }
            else if (topping2ComboBox.SelectedIndex == 11)
            {
                lineItems.ItemID3 = 16;
                itemPrice3 = .50;
            }
            else if (topping2ComboBox.SelectedIndex == 12)
            {
                lineItems.ItemID3 = 17;
                itemPrice3 = .50;
            }
            else if (topping2ComboBox.SelectedIndex == 13)
            {
                lineItems.ItemID3 = 18;
                itemPrice3 = .50;
            }
            else
            {
                lineItems.ItemID3 = 0;
            }

            if (topping2OptionComboBox.SelectedIndex == 0)
            {
                if ((topping1ComboBox.SelectedIndex != 13 || topping1ComboBox.SelectedIndex != 14 || topping1ComboBox.SelectedIndex != 15 || topping1ComboBox.SelectedIndex != 16 || topping1ComboBox.SelectedIndex != 17 || topping1ComboBox.SelectedIndex != 18))
                {
                    lineItems.OptionID3 = 6;
                }
                else
                {
                    lineItems.OptionID3 = 8;
                }
                optionPrice3 = 1;
            }
            else if (topping2OptionComboBox.SelectedIndex == 1)
            {
                lineItems.OptionID3 = 5;
                optionPrice3 = 1;
            }
            else if (topping2OptionComboBox.SelectedIndex == 2)
            {
                if ((topping1ComboBox.SelectedIndex != 13 || topping1ComboBox.SelectedIndex != 14 || topping1ComboBox.SelectedIndex != 15 || topping1ComboBox.SelectedIndex != 16 || topping1ComboBox.SelectedIndex != 17 || topping1ComboBox.SelectedIndex != 18))
                {
                    lineItems.OptionID3 = 7;
                }
                else
                {
                    lineItems.OptionID3 = 9;
                }
                optionPrice3 = 2;
            }
            price3 = itemPrice3 * optionPrice3;

            if (topping3ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID4 = 5;
                itemPrice4 = .99;

            }
            else if (topping3ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID4 = 6;
                itemPrice4 = .99;

            }
            else if (topping3ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID4 = 7;
                itemPrice4 = .99;

            }
            else if (topping3ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID4 = 8;
                itemPrice4 = .99;

            }
            else if (topping3ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID4 = 9;
                itemPrice4 = .99;

            }
            else if (topping3ComboBox.SelectedIndex == 5)
            {
                lineItems.ItemID4 = 10;
                itemPrice4 = .99;

            }
            else if (topping3ComboBox.SelectedIndex == 6)
            {
                lineItems.ItemID4 = 11;
                itemPrice4 = .99;

            }
            else if (topping3ComboBox.SelectedIndex == 7)
            {
                lineItems.ItemID4 = 12;
                itemPrice4 = .99;

            }
            else if (topping3ComboBox.SelectedIndex == 8)
            {
                lineItems.ItemID4 = 13;
                itemPrice4 = .50;
            }
            else if (topping3ComboBox.SelectedIndex == 9)
            {
                lineItems.ItemID4 = 14;
                itemPrice4 = .50;
            }
            else if (topping3ComboBox.SelectedIndex == 10)
            {
                lineItems.ItemID4 = 15;
                itemPrice4 = .50;
            }
            else if (topping3ComboBox.SelectedIndex == 11)
            {
                lineItems.ItemID4 = 16;
                itemPrice4 = .50;
            }
            else if (topping3ComboBox.SelectedIndex == 12)
            {
                lineItems.ItemID4 = 17;
                itemPrice4 = .50;
            }
            else if (topping3ComboBox.SelectedIndex == 13)
            {
                lineItems.ItemID4 = 18;
                itemPrice4 = .50;
            }
            else
            {
                lineItems.ItemID4 = 0;
            }

            if (topping3OptionComboBox.SelectedIndex == 0)
            {
                if ((topping1ComboBox.SelectedIndex != 13 || topping1ComboBox.SelectedIndex != 14 || topping1ComboBox.SelectedIndex != 15 || topping1ComboBox.SelectedIndex != 16 || topping1ComboBox.SelectedIndex != 17 || topping1ComboBox.SelectedIndex != 18))
                {
                    lineItems.OptionID4 = 6;
                }
                else
                {
                    lineItems.OptionID4 = 8;
                }
                optionPrice4 = 1;
            }
            else if (topping3OptionComboBox.SelectedIndex == 1)
            {
                lineItems.OptionID4 = 5;
                optionPrice4 = 1;
            }
            else if (topping3OptionComboBox.SelectedIndex == 2)
            {
                if ((topping1ComboBox.SelectedIndex != 13 || topping1ComboBox.SelectedIndex != 14 || topping1ComboBox.SelectedIndex != 15 || topping1ComboBox.SelectedIndex != 16 || topping1ComboBox.SelectedIndex != 17 || topping1ComboBox.SelectedIndex != 18))
                {
                    lineItems.OptionID4 = 7;
                }
                else
                {
                    lineItems.OptionID4 = 9;
                }
                optionPrice4 = 2;
            }
            price4 = itemPrice4 * optionPrice4;

            if (topping4ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID5 = 5;
                itemPrice5 = .99;

            }
            else if (topping4ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID5 = 6;
                itemPrice5 = .99;

            }
            else if (topping4ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID5 = 7;
                itemPrice5 = .99;

            }
            else if (topping4ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID5 = 8;
                itemPrice5 = .99;

            }
            else if (topping4ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID5 = 9;
                itemPrice5 = .99;

            }
            else if (topping4ComboBox.SelectedIndex == 5)
            {
                lineItems.ItemID5 = 10;
                itemPrice5 = .99;

            }
            else if (topping4ComboBox.SelectedIndex == 6)
            {
                lineItems.ItemID5 = 11;
                itemPrice5 = .99;

            }
            else if (topping4ComboBox.SelectedIndex == 7)
            {
                lineItems.ItemID5 = 12;
                itemPrice5 = .99;

            }
            else if (topping4ComboBox.SelectedIndex == 8)
            {
                lineItems.ItemID5 = 13;
                itemPrice5 = .50;
            }
            else if (topping4ComboBox.SelectedIndex == 9)
            {
                lineItems.ItemID5 = 14;
                itemPrice5 = .50;
            }
            else if (topping4ComboBox.SelectedIndex == 10)
            {
                lineItems.ItemID5 = 15;
                itemPrice5 = .50;
            }
            else if (topping4ComboBox.SelectedIndex == 11)
            {
                lineItems.ItemID5 = 16;
                itemPrice5 = .50;
            }
            else if (topping4ComboBox.SelectedIndex == 12)
            {
                lineItems.ItemID5 = 17;
                itemPrice5 = .50;
            }
            else if (topping4ComboBox.SelectedIndex == 13)
            {
                lineItems.ItemID5 = 18;
                itemPrice5 = .50;
            }
            else
            {
                lineItems.ItemID5 = 0;
            }

            if (topping4OptionComboBox.SelectedIndex == 0)
            {
                if ((topping1ComboBox.SelectedIndex != 13 || topping1ComboBox.SelectedIndex != 14 || topping1ComboBox.SelectedIndex != 15 || topping1ComboBox.SelectedIndex != 16 || topping1ComboBox.SelectedIndex != 17 || topping1ComboBox.SelectedIndex != 18))
                {
                    lineItems.OptionID5 = 6;
                }
                else
                {
                    lineItems.OptionID5 = 8;
                }
                optionPrice5 = 1;
            }
            else if (topping4OptionComboBox.SelectedIndex == 1)
            {
                lineItems.OptionID5 = 5;
                optionPrice5 = 1;
            }
            else if (topping4OptionComboBox.SelectedIndex == 2)
            {
                if ((topping1ComboBox.SelectedIndex != 13 || topping1ComboBox.SelectedIndex != 14 || topping1ComboBox.SelectedIndex != 15 || topping1ComboBox.SelectedIndex != 16 || topping1ComboBox.SelectedIndex != 17 || topping1ComboBox.SelectedIndex != 18))
                {
                    lineItems.OptionID5 = 7;
                }
                else
                {
                    lineItems.OptionID5 = 9;
                }
                optionPrice5 = 2;
            }
            price5 = itemPrice5 * optionPrice5;

            if (cheese1ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID6 = 19;
                itemPrice6 = .50;
            }
            else if (cheese1ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID6 = 20;
                itemPrice6 = .50;
            }
            else if (cheese1ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID6 = 21;
                itemPrice6 = .50;
            }
            else if (cheese1ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID6 = 22;
                itemPrice6 = .50;
            }
            else if (cheese1ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID6 = 23;
                itemPrice6 = .50;
            }

            if (cheese1OptionComboBox.SelectedIndex == 0)
            {
                lineItems.OptionID6 = 8;
                optionPrice6 = 1;
            }
            else if (cheese1OptionComboBox.SelectedIndex == 1)
            {
                lineItems.OptionID6 = 5;
                optionPrice6 = 1;
            }
            else if (cheese1OptionComboBox.SelectedIndex == 2)
            {
                lineItems.OptionID6 = 9;
                optionPrice6 = 2;
            }
            price6 = itemPrice6 * optionPrice6;

            if (cheese2ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID7 = 19;
                itemPrice7 = .50;
            }
            else if (cheese2ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID7 = 20;
                itemPrice7 = .50;
            }
            else if (cheese2ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID7 = 21;
                itemPrice7 = .50;
            }
            else if (cheese2ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID7 = 22;
                itemPrice7 = .50;
            }
            else if (cheese2ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID7 = 23;
                itemPrice7 = .50;
            }
            else
            {
                lineItems.ItemID7 = 0;
            }
            
            if (cheese2OptionComboBox.SelectedIndex == 0)
            {
                lineItems.OptionID7 = 8;
                optionPrice7 = 1;
            }
            else if (cheese2OptionComboBox.SelectedIndex == 1)
            {
                lineItems.OptionID7 = 5;
                optionPrice7 = 1;
            }
            else if (cheese2OptionComboBox.SelectedIndex == 2)
            {
                lineItems.OptionID7 = 9;
                optionPrice7 = 2;
            }
            price7 = itemPrice7 * optionPrice7;
            total = price1 + price2 + price3 + price4 + price5 + price6 + price7;
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
            total *= lineItems.Quantity;
            lineItems.Price = total;
            lineItems.OrderID = orderID;
            lineItems.Description = lineItems.ToString();
            MainMenuForm.itemsOrdered.Add(lineItems);
            LineItems.CreateLineItem(lineItems);
            MainMenuForm.text += lineItems.Description + " $" + lineItems.Price + "\n";
            MainMenuForm.instance.CartLabel = MainMenuForm.text;
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
