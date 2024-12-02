using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Sprint2PizzaProject
{
    public partial class CustomOrder : Form
    {
        public CustomOrder()
        {
            InitializeComponent();
        }

        private int orderID = Orders.NextOrderID;

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
            string[] item = new string[3];

            if (crustComboBox.SelectedIndex == -1)
            {
                NoCrust noCrust = new NoCrust();
                noCrust.Show();
            }
            else if (crustOptionComboBox.SelectedIndex == -1)
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

            if (topping1ComboBox.SelectedIndex == -1 && topping2ComboBox.SelectedIndex == -1 && topping3ComboBox.SelectedIndex == -1 && topping4ComboBox.SelectedIndex == -1)
            {
                NoTopping noTopping = new NoTopping();
                noTopping.Show();

            }
            else if (topping1OptionComboBox.SelectedIndex == -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
                item = CustomTopping(topping1ComboBox, topping1OptionComboBox);
                lineItems.ItemID2 = Convert.ToInt32(item[0]);
                lineItems.OptionID2 = Convert.ToInt32(item[1]);
                price2 = Convert.ToDouble(item[2]);
            }
            if (topping2OptionComboBox.SelectedIndex == -1 && topping2ComboBox.SelectedIndex != -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
                item = CustomTopping(topping2ComboBox, topping2OptionComboBox);
                lineItems.ItemID3 = Convert.ToInt32(item[0]);
                lineItems.OptionID3 = Convert.ToInt32(item[1]);
                price3 = Convert.ToDouble(item[2]);

            }
            if (topping3OptionComboBox.SelectedIndex == -1 && topping3ComboBox.SelectedIndex != -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
                item = CustomTopping(topping3ComboBox, topping3OptionComboBox);
                lineItems.ItemID4 = Convert.ToInt32(item[0]);
                lineItems.OptionID4 = Convert.ToInt32(item[1]);
                price4 = Convert.ToDouble(item[2]);
            }
            if (topping4OptionComboBox.SelectedIndex == -1 && topping4ComboBox.SelectedIndex != -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
                item = CustomTopping(topping4ComboBox, topping4OptionComboBox);
                lineItems.ItemID5 = Convert.ToInt32(item[0]);
                lineItems.OptionID5 = Convert.ToInt32(item[1]);
                price5 = Convert.ToDouble(item[2]);
            }

            if (cheese1ComboBox.SelectedIndex == -1 && cheese2ComboBox.SelectedIndex == -1)
            {
                NoCheese noCheese = new NoCheese();
                noCheese.Show();
            }
            else if (cheese1OptionComboBox.SelectedIndex == -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
                item = CustomCheese(cheese1ComboBox, cheese1OptionComboBox);
                lineItems.ItemID6 = Convert.ToInt32(item[0]);
                lineItems.OptionID6 = Convert.ToInt32(item[1]);
                price6 = Convert.ToDouble(item[2]);
            }
            if (cheese2OptionComboBox.SelectedIndex == -1 && cheese2ComboBox.SelectedIndex != -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
                item = CustomCheese(cheese2ComboBox, cheese2ComboBox);
                lineItems.ItemID7 = Convert.ToInt32(item[0]);
                lineItems.OptionID7 = Convert.ToInt32(item[1]);
                price7 = Convert.ToDouble(item[2]);
            }

            total = price1 + price2 + price3 + price4 + price5 + price6 + price7;

            if (quantityComboBox.SelectedIndex == 0)
            {
                lineItems.Quantity = 1;
            }
            else if (quantityComboBox.SelectedIndex == 1)
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
            else if (quantityComboBox.SelectedIndex == 4)
            {
                lineItems.Quantity = 5;
            }
            else
            {
                lineItems.Quantity = 0;
            }
            if ((crustComboBox.SelectedIndex != -1 && topping1ComboBox.SelectedIndex != -1 && cheese1ComboBox.SelectedIndex != -1 && crustOptionComboBox.SelectedIndex != -1 && topping1OptionComboBox.SelectedIndex != -1 && cheese1OptionComboBox.SelectedIndex != -1)
                || (crustComboBox.SelectedIndex != -1 && topping1ComboBox.SelectedIndex != -1 && cheese2ComboBox.SelectedIndex != -1 && crustOptionComboBox.SelectedIndex != -1 && topping1OptionComboBox.SelectedIndex != -1 && cheese2OptionComboBox.SelectedIndex != -1)
                || (crustComboBox.SelectedIndex != -1 && topping2ComboBox.SelectedIndex != -1 && cheese1ComboBox.SelectedIndex != -1 && crustOptionComboBox.SelectedIndex != -1 && topping2OptionComboBox.SelectedIndex != -1 && cheese1OptionComboBox.SelectedIndex != -1)
                || (crustComboBox.SelectedIndex != -1 && topping2ComboBox.SelectedIndex != -1 && cheese2ComboBox.SelectedIndex != -1 && crustOptionComboBox.SelectedIndex != -1 && topping2OptionComboBox.SelectedIndex != -1 && cheese2OptionComboBox.SelectedIndex != -1)
                || (crustComboBox.SelectedIndex != -1 && topping3ComboBox.SelectedIndex != -1 && cheese1ComboBox.SelectedIndex != -1 && crustOptionComboBox.SelectedIndex != -1 && topping3OptionComboBox.SelectedIndex != -1 && cheese1OptionComboBox.SelectedIndex != -1)
                || (crustComboBox.SelectedIndex != -1 && topping3ComboBox.SelectedIndex != -1 && cheese2ComboBox.SelectedIndex != -1 && crustOptionComboBox.SelectedIndex != -1 && topping3OptionComboBox.SelectedIndex != -1 && cheese2OptionComboBox.SelectedIndex != -1)
                || (crustComboBox.SelectedIndex != -1 && topping4ComboBox.SelectedIndex != -1 && cheese1ComboBox.SelectedIndex != -1 && crustOptionComboBox.SelectedIndex != -1 && topping4OptionComboBox.SelectedIndex != -1 && cheese1OptionComboBox.SelectedIndex != -1)
                || (crustComboBox.SelectedIndex != -1 && topping4ComboBox.SelectedIndex != -1 && cheese2ComboBox.SelectedIndex != -1 && crustOptionComboBox.SelectedIndex != -1 && topping4OptionComboBox.SelectedIndex != -1 && cheese2OptionComboBox.SelectedIndex != -1))
            {
                if (lineItems.Quantity != 0)
                {
                    total *= lineItems.Quantity;
                    lineItems.Price = total;
                    lineItems.OrderID = orderID;
                    lineItems.Description = lineItems.ToString();
                    MainMenuForm.itemsOrdered.Add(lineItems);
                    LineItems.CreateLineItem(lineItems);
                    string priceTotal = String.Format("{0:F2}", lineItems.Price);
                    if (MainMenuForm.text.Equals(""))
                    {
                        MainMenuForm.text = lineItems.Description + " $" + priceTotal + "\n";
                    }
                    else
                    {
                        MainMenuForm.text += lineItems.Description + " $" + priceTotal + "\n";
                    }
                    (MainMenuForm.instance).CartLabel = MainMenuForm.text;
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

        private string[] CustomTopping(ComboBox used, ComboBox used2)
        {
            double itemPrice = 0;
            double optionPrice = 0;
            int id1 = 0;
            int id2 = 0;
            if (used.SelectedIndex == 0)
            {
                id1 = 5;
                itemPrice = .99;
            }
            else if (used.SelectedIndex == 1)
            {
                id1 = 6;
                itemPrice = .99;
            }
            else if (used.SelectedIndex == 2)
            {
                id1 = 7;
                itemPrice = .99;
            }
            else if (used.SelectedIndex == 3)
            {
                id1 = 8;
                itemPrice = .99;
            }
            else if (used.SelectedIndex == 4)
            {
                id1 = 9;
                itemPrice = .99;
            }
            else if (used.SelectedIndex == 5)
            {
                id1 = 10;
                itemPrice = .99;
            }
            else if (used.SelectedIndex == 6)
            {
                id1 = 11;
                itemPrice = .99;
            }
            else if (used.SelectedIndex == 7)
            {
                id1 = 12;
                itemPrice = .99;
            }
            else if (used.SelectedIndex == 8)
            {
                id1 = 13;
                itemPrice = .50;
            }
            else if (used.SelectedIndex == 9)
            {
                id1 = 14;
                itemPrice = .50;
            }
            else if (used.SelectedIndex == 10)
            {
                id1 = 15;
                itemPrice = .50;
            }
            else if (used.SelectedIndex == 11)
            {
                id1 = 16;
                itemPrice = .50;
            }
            else if (used.SelectedIndex == 12)
            {
                id1 = 17;
                itemPrice = .50;
            }
            else if (used.SelectedIndex == 13)
            {
                id1 = 18;
                itemPrice = .50;
            }

            if (used2.SelectedIndex == 0)
            {
                if ((topping1ComboBox.SelectedIndex != 13 || topping1ComboBox.SelectedIndex != 14 || topping1ComboBox.SelectedIndex != 15 || topping1ComboBox.SelectedIndex != 16 || topping1ComboBox.SelectedIndex != 17 || topping1ComboBox.SelectedIndex != 18))
                {
                    id2 = 6;
                }
                else
                {
                    id2 = 8;
                }
                optionPrice = 1;
            }
            else if (used2.SelectedIndex == 1)
            {
                id2 = 5;
                optionPrice = 1;
            }
            else if (used2.SelectedIndex == 2)
            {
                if ((topping1ComboBox.SelectedIndex != 13 || topping1ComboBox.SelectedIndex != 14 || topping1ComboBox.SelectedIndex != 15 || topping1ComboBox.SelectedIndex != 16 || topping1ComboBox.SelectedIndex != 17 || topping1ComboBox.SelectedIndex != 18))
                {
                    id2 = 7;
                }
                else
                {
                    id2 = 9;
                }
                optionPrice = 2;
            }
            double price = itemPrice * optionPrice;
            String[] itemInfo = new string[3];
            itemInfo[0] = id1.ToString();
            itemInfo[1] = id2.ToString();
            itemInfo[2] = price.ToString();
            return itemInfo;
        }

        private string[] CustomCheese(ComboBox comboBox1, ComboBox comboBox2)
        {
            double itemPrice = 0;
            double optionPrice = 0;
            int id1 = 0;
            int id2 = 0;
            double price = 0;
            if (comboBox1.SelectedIndex == 0)
            {
                id1 = 19;
                itemPrice = .50;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                id1 = 20;
                itemPrice = .50;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                id1 = 21;
                itemPrice = .50;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                id1 = 22;
                itemPrice = .50;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                id1 = 23;
                itemPrice = .50;
            }

            if (comboBox2.SelectedIndex == 0)
            {
                id2 = 8;
                optionPrice = 1;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                id2 = 5;
                optionPrice = 1;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                id2 = 9;
                optionPrice = 2;
            }
            price = itemPrice * optionPrice;
            string[] itemInfo = new string[3];
            itemInfo[0] = id1.ToString();
            itemInfo[1] = id2.ToString();
            itemInfo[2] = price.ToString();
            return itemInfo;
        }

    }
}
