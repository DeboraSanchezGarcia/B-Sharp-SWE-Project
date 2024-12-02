using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        /// <summary>
        /// Clears current cart and sets the text for the cart view in main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Orders.DeleteOrder(Orders.NextOrderID);
            MainMenuForm.itemsOrdered.Clear();
            MainMenuForm.text = "";
            (MainMenuForm.instance).CartLabel = MainMenuForm.text;
            this.Close();
            MainMenuForm.instance.Show();
        }
        /// <summary>
        /// Returns to main menu to continue shopping
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeepShoppingButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm.instance.Show();
        }
        /// <summary>
        /// Checks if logged in and that cart has items in it then goes to checkout if both are true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            if (!Program.LoggedIn)
            {
                LoginRequestForm loginRequestForm = new LoginRequestForm();
                loginRequestForm.Show();
                this.Close();
            }
            else {
                if (MainMenuForm.itemsOrdered.Count != 0) {
                        CheckoutPageForm checkout = new CheckoutPageForm();
                        this.Hide();
                        checkout.Show();
                }
                else
                {
                    CartEmpty cartEmpty = new CartEmpty();
                    cartEmpty.Show();
                }
            }
        }
        /// <summary>
        /// Sets all the text values in the cart screen upon loading of the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    items[x] = ItemDescriptions((LineItems)itemsOrdered[x]);
                    price[x] = ItemPrices((LineItems)itemsOrdered[x]);
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
            subtotalLabel.Text = "Subtotal: ";
            subtotalLabel.Text += "$" + priceTotal.ToString();
        }
        /// <summary>
        /// Gets the line items description
        /// </summary>
        /// <param name="itemOrdered"></param>
        /// <returns></returns>
        static string ItemDescriptions(LineItems itemOrdered)
        {
            return itemOrdered.Description;
        }
        /// <summary>
        /// Gets the line items price
        /// </summary>
        /// <param name="itemOrdered"></param>
        /// <returns></returns>
        static double ItemPrices(LineItems itemOrdered)
        {
            return itemOrdered.Price;
        }
        /// <summary>
        /// Removes the 1st item from the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeItemButton1_Click(object sender, EventArgs e)
        {
            RemoveItem(0);
            ShoppingCart_Load(this, e);
        }
        /// <summary>
        /// Removes the 2st item from the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeItemButton2_Click(object sender, EventArgs e)
        {
            RemoveItem(1);
            ShoppingCart_Load(this, e);
        }
        /// <summary>
        /// Removes the 3nd item from the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeItemButton3_Click(object sender, EventArgs e)
        {
            RemoveItem(2);
            ShoppingCart_Load(this, e);
        }
        /// <summary>
        /// Removes the 4rd item from the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeItemButton4_Click(object sender, EventArgs e)
        {
            RemoveItem(3);
            ShoppingCart_Load(this, e);
        }
        /// <summary>
        /// Removes the 5th item from the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeItemButton5_Click(object sender, EventArgs e)
        {
            RemoveItem(4);
            ShoppingCart_Load(this, e);
        }
        /// <summary>
        /// Removes the 6th item from the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeItemButton6_Click(object sender, EventArgs e)
        {
            RemoveItem(5);
            ShoppingCart_Load(this, e);
        }
        /// <summary>
        /// Removes the 7th item from the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeItemButton7_Click(object sender, EventArgs e)
        {
            RemoveItem(6);
            ShoppingCart_Load(this, e);
        }
        /// <summary>
        /// Removes the 8th item from the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeItemButton8_Click(object sender, EventArgs e)
        {
            RemoveItem(7);
            ShoppingCart_Load(this, e);
        }
        /// <summary>
        /// Removes the 9th item from the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeItemButton9_Click(object sender, EventArgs e)
        {
            RemoveItem(8);
            ShoppingCart_Load(this, e);
        }
        /// <summary>
        /// Removes the 10th item from the cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeItemButton10_Click(object sender, EventArgs e)
        {
            RemoveItem(9);
            ShoppingCart_Load(this, e);
        }
        /// <summary>
        /// Method to change the carts text
        /// </summary>
        /// <param name="x"></param>
        public static void ChangeCartText(int x)
        {
            string[] text = MainMenuForm.text.Split("\n");
            text[x] = "";
            ArrayList text1 = new ArrayList();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == "")
                {
                    continue;
                }
                else
                {
                    text1.Add(text[i]);
                }
            }
            string newText = "";
            foreach (string lines in text1)
            {
                newText += lines + "\n";
            }
            MainMenuForm.text = newText;
            (MainMenuForm.instance).CartLabel = MainMenuForm.text;
        }
        /// <summary>
        /// Method for removing items from the array that holds the items ordered
        /// </summary>
        /// <param name="x"></param>
        public static void RemoveItem(int x)
        {
            LineItems lineItem;
            Object[] itemsOrdered = MainMenuForm.itemsOrdered.ToArray();
            lineItem = (LineItems)itemsOrdered[x];
            LineItems.DeleteLineItem(lineItem.LineItemID);
            MainMenuForm.itemsOrdered.RemoveAt(x);
            ChangeCartText(x);
        }
    }
}

