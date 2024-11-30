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
    public partial class ShoppingCart : Form
    {
        public ShoppingCart()
        {
            InitializeComponent();
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
            Object[] itemsOrdered = MainMenuForm.itemsOrdered.ToArray();
            LineItems lineItem;
            string[] items = new string[10];
            double[] price = new double[10];
            double priceTotal = 0;
            for (int x = 0; x < itemsOrdered.Length; x++)
            {
                if (itemsOrdered[x] != null)
                {
                    items[x] = itemDescriptions((LineItems)itemsOrdered[x]);
                    price[x] = itemPrices((LineItems)itemsOrdered[x]);
                }
            }
            if (items[0] == null)
            {
                item1Label.Text = "";
                price1Label.Text = "";
                removeItemButton1.Hide();
            }
            else
            {
                item1Label.Text = items[0];
                price1Label.Text = "$" + price[0].ToString();
            }
            if (items[1] == null)
            {
                item2Label.Text = "";
                price2Label.Text = "";
                removeItemButton2.Hide();
            }
            else
            {
                item2Label.Text = items[1];
                price2Label.Text = "$" + price[1].ToString();
            }
            if (items[2] == null)
            {
                item3Label.Text = "";
                price3Label.Text = "";
                removeItemButton3.Hide();
            }
            else
            {
                item3Label.Text = items[2];
                price3Label.Text = "$" + price[2].ToString();
            }
            if (items[3] == null)
            {
                item4Label.Text = "";
                price4Label.Text = "";
                removeItemButton4.Hide();
            }
            else
            {
                item4Label.Text = items[3];
                price4Label.Text = "$" + price[3].ToString();
            }
            if (items[4] == null)
            {
                item5Label.Text = "";
                price5Label.Text = "";
                removeItemButton5.Hide();
            }
            else
            {
                item5Label.Text = items[4];
                price5Label.Text = "$" + price[4].ToString();
            }
            if (items[5] == null)
            {
                item6Label.Text = "";
                price6Label.Text = "";
                removeItemButton6.Hide();
            }
            else
            {
                item6Label.Text = items[5];
                price6Label.Text = "$" + price[5].ToString();
            }
            if (items[6] == null)
            {
                item7Label.Text = "";
                price7Label.Text = "";
                removeItemButton7.Hide();
            }
            else
            {
                item7Label.Text = items[6];
                price7Label.Text = "$" + price[6].ToString();
            }
            if (items[7] == null)
            {
                item8Label.Text = "";
                price8Label.Text = "";
                removeItemButton8.Hide();
            }
            else
            {
                item8Label.Text = items[7];
                price8Label.Text = "$" + price[7].ToString();
            }
            if (items[8] == null)
            {
                item9Label.Text = "";
                price9Label.Text = "";
                removeItemButton9.Hide();
            }
            else
            {
                item9Label.Text = items[8];
                price9Label.Text = "$" + price[8].ToString();
            }
            if (items[9] == null)
            {
                item10Label.Text = "";
                price10Label.Text = "";
                removeItemButton10.Hide();
            }
            else
            {
                item10Label.Text = items[9];
                price10Label.Text = "$" + price[9].ToString();
            }
            for (int x = 0; x < price.Length; x++)
            {
                priceTotal += price[x];
            }
            subtotalLabel.Text = "$" + priceTotal.ToString();
        }

        static string itemDescriptions(LineItems itemOrdered)
        {
            return itemOrdered.Description;
        }

        static double itemPrices(LineItems itemOrdered)
        {
            return itemOrdered.Price;
        }

        private LineItems lineItem;
        private void removeItemButton1_Click(object sender, EventArgs e)
        {
            if (MainMenuForm.itemsOrdered.Count >= 7)
            {
                Object[] itemsOrdered = MainMenuForm.itemsOrdered.ToArray();
                lineItem = (LineItems)itemsOrdered[0];
                LineItems.DeleteLineItem(lineItem.LineItemID);
                MainMenuForm.itemsOrdered.Remove(0);
                ShoppingCart cart = new ShoppingCart();
                this.Close();
                cart.Show();
            }
        }

        private void removeItemButton2_Click(object sender, EventArgs e)
        {
            if (MainMenuForm.itemsOrdered.Count >= 2)
            {
                Object[] itemsOrdered = MainMenuForm.itemsOrdered.ToArray();
                lineItem = (LineItems)itemsOrdered[1];
                LineItems.DeleteLineItem(lineItem.LineItemID);
                MainMenuForm.itemsOrdered.Remove(1);
                ShoppingCart cart = new ShoppingCart();
                this.Close();
                cart.Show();
            }
        }

        private void removeItemButton3_Click(object sender, EventArgs e)
        {
            if (MainMenuForm.itemsOrdered.Count >= 3)
            {
                Object[] itemsOrdered = MainMenuForm.itemsOrdered.ToArray();
                lineItem = (LineItems)itemsOrdered[2];
                LineItems.DeleteLineItem(lineItem.LineItemID);
                MainMenuForm.itemsOrdered.Remove(2);
                ShoppingCart cart = new ShoppingCart();
                this.Close();
                cart.Show();
            }
        }

        private void removeItemButton4_Click(object sender, EventArgs e)
        {
            if (MainMenuForm.itemsOrdered.Count >= 4)
            {
                Object[] itemsOrdered = MainMenuForm.itemsOrdered.ToArray();
                lineItem = (LineItems)itemsOrdered[3];
                LineItems.DeleteLineItem(lineItem.LineItemID);
                MainMenuForm.itemsOrdered.Remove(3);
                ShoppingCart cart = new ShoppingCart();
                this.Close();
                cart.Show();
            }
        }

        private void removeItemButton5_Click(object sender, EventArgs e)
        {
            if (MainMenuForm.itemsOrdered.Count >= 5)
            {
                Object[] itemsOrdered = MainMenuForm.itemsOrdered.ToArray();
                lineItem = (LineItems)itemsOrdered[4];
                LineItems.DeleteLineItem(lineItem.LineItemID);
                MainMenuForm.itemsOrdered.Remove(4);
                ShoppingCart cart = new ShoppingCart();
                this.Close();
                cart.Show();
            }
        }

        private void removeItemButton6_Click(object sender, EventArgs e)
        {
            if (MainMenuForm.itemsOrdered.Count >= 6)
            {
                Object[] itemsOrdered = MainMenuForm.itemsOrdered.ToArray();
                lineItem = (LineItems)itemsOrdered[5];
                LineItems.DeleteLineItem(lineItem.LineItemID);
                MainMenuForm.itemsOrdered.Remove(5);
                ShoppingCart cart = new ShoppingCart();
                this.Close();
                cart.Show();
            }
        }

        private void removeItemButton7_Click(object sender, EventArgs e)
        {
            if (MainMenuForm.itemsOrdered.Count >= 7)
            {
                Object[] itemsOrdered = MainMenuForm.itemsOrdered.ToArray();
                lineItem = (LineItems)itemsOrdered[6];
                LineItems.DeleteLineItem(lineItem.LineItemID);
                MainMenuForm.itemsOrdered.Remove(6);
                ShoppingCart cart = new ShoppingCart();
                this.Close();
                cart.Show();
            }
        }

        private void removeItemButton8_Click(object sender, EventArgs e)
        {
            if(MainMenuForm.itemsOrdered.Count >= 8)
            {
                Object[] itemsOrdered = MainMenuForm.itemsOrdered.ToArray();
                lineItem = (LineItems)itemsOrdered[7];
                LineItems.DeleteLineItem(lineItem.LineItemID);
                MainMenuForm.itemsOrdered.Remove(7);
                ShoppingCart cart = new ShoppingCart();
                this.Close();
                cart.Show();
            }
        }

        private void removeItemButton9_Click(object sender, EventArgs e)
        {
            if (MainMenuForm.itemsOrdered.Count >= 9)
            {
                Object[] itemsOrdered = MainMenuForm.itemsOrdered.ToArray();
                lineItem = (LineItems)itemsOrdered[8];
                LineItems.DeleteLineItem(lineItem.LineItemID);
                MainMenuForm.itemsOrdered.Remove(8);
                ShoppingCart cart = new ShoppingCart();
                this.Close();
                cart.Show();
            }
        }

        private void removeItemButton10_Click(object sender, EventArgs e)
        {
            if (MainMenuForm.itemsOrdered.Count == 10)
            {
                Object[] itemsOrdered = MainMenuForm.itemsOrdered.ToArray();
                lineItem = (LineItems)itemsOrdered[9];
                LineItems.DeleteLineItem(lineItem.LineItemID);
                MainMenuForm.itemsOrdered.Remove(9);
                ShoppingCart cart = new ShoppingCart();
                this.Close();
                cart.Show();
            }
        }
    }
}
