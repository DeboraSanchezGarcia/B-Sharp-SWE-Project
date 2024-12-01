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
    public partial class CustomOrder : Form
    {
        public CustomOrder()
        {
            InitializeComponent();
        }

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
            double price1 = 0;
            double price2 = 0;
            double price3 = 0;
            double price4 = 0;
            double price5 = 0;
            double price6 = 0;
            double price7 = 0;
            double total = 0;
            if (crustComboBox.SelectedIndex == -1)
            {
                NoCrust noCrust = new NoCrust();
                noCrust.Show();
            }
            else if(crustOptionComboBox.SelectedIndex == -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
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
            }

            if(topping1ComboBox.SelectedIndex == -1) 
            {
                NoTopping noTopping = new NoTopping();
                noTopping.Show();

            }
            else if(topping1OptionComboBox.SelectedIndex == -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
                CustomTopping(topping1ComboBox, ref lineItems, ref price2);
            }
            if (topping2OptionComboBox.SelectedIndex == -1 && topping2ComboBox.SelectedIndex != -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
                CustomTopping(topping2ComboBox, ref lineItems, ref price3);

            }
            if (topping3OptionComboBox.SelectedIndex == -1 && topping3ComboBox.SelectedIndex != -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
                CustomTopping(topping3ComboBox, ref lineItems, ref price4);

            }
            if (topping4OptionComboBox.SelectedIndex == -1 && topping4ComboBox.SelectedIndex != -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
                CustomTopping(topping4ComboBox, ref lineItems, ref price5);
            }

            if (cheese1ComboBox.SelectedIndex == -1)
            {
                NoCheese noCheese = new NoCheese();
                noCheese.Show();
            }
            else if(cheese1OptionComboBox.SelectedIndex == -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
                CustomCheese(cheese1ComboBox, ref lineItems, ref price6);
            }
            if(cheese2OptionComboBox.SelectedIndex == -1 && cheese2ComboBox.SelectedIndex != -1)
            {
                CustomCheese(cheese2ComboBox, ref lineItems, ref price7);
            }
            else
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }

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
            else
            {
                lineItems.Quantity = 0;
            }
            if (crustComboBox.SelectedIndex != -1 && topping1ComboBox.SelectedIndex != -1 && cheese1ComboBox.SelectedIndex != -1 && crustOptionComboBox.SelectedIndex != -1 && topping1OptionComboBox.SelectedIndex != -1 && cheese1OptionComboBox.SelectedIndex != -1)
            {
                if (lineItems.Quantity != 0)
                {
                    total *= lineItems.Quantity;
                    lineItems.Price = total;
                    lineItems.OrderID = orderID;
                    lineItems.Description = lineItems.ToString();
                    MainMenuForm.itemsOrdered.Add(lineItems);
                    LineItems.CreateLineItem(lineItems);
                    string money = String.Format("{0:F2}", lineItems.Price);
                    MainMenuForm.instance.Text += lineItems.Description + " $" + money + "\n";
                    MainMenuForm.instance.CartLabel = MainMenuForm.instance.Text;
                    this.Close();
                    MainMenuForm.instance.Show();
                }
                else
                {
                    Quantity0 quantity0 = new Quantity0();
                    quantity0.Show();
                }
            }
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

        private void CustomTopping(ComboBox used, ref LineItems lineItems, ref double price)
        {
            double itemPrice = 0; 
            double optionPrice = 0;
            if (topping1ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID2 = 5;
                itemPrice = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID2 = 6;
                itemPrice = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID2 = 7;
                itemPrice = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID2 = 8;
                itemPrice = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID2 = 9;
                itemPrice = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 5)
            {
                lineItems.ItemID2 = 10;
                itemPrice = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 6)
            {
                lineItems.ItemID2 = 11;
                itemPrice = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 7)
            {
                lineItems.ItemID2 = 12;
                itemPrice = .99;
            }
            else if (topping1ComboBox.SelectedIndex == 8)
            {
                lineItems.ItemID2 = 13;
                itemPrice = .50;
            }
            else if (topping1ComboBox.SelectedIndex == 9)
            {
                lineItems.ItemID2 = 14;
                itemPrice = .50;
            }
            else if (topping1ComboBox.SelectedIndex == 10)
            {
                lineItems.ItemID2 = 15;
                itemPrice = .50;
            }
            else if (topping1ComboBox.SelectedIndex == 11)
            {
                lineItems.ItemID2 = 16;
                itemPrice = .50;
            }
            else if (topping1ComboBox.SelectedIndex == 12)
            {
                lineItems.ItemID2 = 17;
                itemPrice = .50;
            }
            else if (topping1ComboBox.SelectedIndex == 13)
            {
                lineItems.ItemID2 = 18;
                itemPrice = .50;
            }

            if (topping1OptionComboBox.SelectedIndex == 0)
            {
                if ((topping1ComboBox.SelectedIndex != 13 || topping1ComboBox.SelectedIndex != 14 || topping1ComboBox.SelectedIndex != 15 || topping1ComboBox.SelectedIndex != 16 || topping1ComboBox.SelectedIndex != 17 || topping1ComboBox.SelectedIndex != 18))
                {
                    lineItems.OptionID2 = 6;
                }
                else
                {
                    lineItems.OptionID2 = 8;
                }
                optionPrice = 1;
            }
            else if (topping1OptionComboBox.SelectedIndex == 1)
            {
                lineItems.OptionID2 = 5;
                optionPrice = 1;
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
                optionPrice = 2;
            }
            price = itemPrice * optionPrice;
        }

        private void CustomCheese(ComboBox comboBox, ref LineItems lineItems, ref double price)
        {
            double itemPrice = 0;
            double optionPrice = 0;
            if (cheese1ComboBox.SelectedIndex == 0)
            {
                lineItems.ItemID6 = 19;
                itemPrice = .50;
            }
            else if (cheese1ComboBox.SelectedIndex == 1)
            {
                lineItems.ItemID6 = 20;
                itemPrice = .50;
            }
            else if (cheese1ComboBox.SelectedIndex == 2)
            {
                lineItems.ItemID6 = 21;
                itemPrice = .50;
            }
            else if (cheese1ComboBox.SelectedIndex == 3)
            {
                lineItems.ItemID6 = 22;
                itemPrice = .50;
            }
            else if (cheese1ComboBox.SelectedIndex == 4)
            {
                lineItems.ItemID6 = 23;
                itemPrice = .50;
            }

            if (cheese1OptionComboBox.SelectedIndex == 0)
            {
                lineItems.OptionID6 = 8;
                optionPrice = 1;
            }
            else if (cheese1OptionComboBox.SelectedIndex == 1)
            {
                lineItems.OptionID6 = 5;
                optionPrice = 1;
            }
            else if (cheese1OptionComboBox.SelectedIndex == 2)
            {
                lineItems.OptionID6 = 9;
                optionPrice = 2;
            }
            price = itemPrice * optionPrice;
        }
    }
}
