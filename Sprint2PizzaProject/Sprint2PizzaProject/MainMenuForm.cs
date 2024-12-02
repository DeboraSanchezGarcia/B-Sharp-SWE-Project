﻿using System.Collections;

namespace Sprint2PizzaProject
{
    public partial class MainMenuForm : Form
    {
        // Use this to go back to main menu when needed (MainMenuForm.Instance.Show();) Don't MainMenuForm.Instance.Close(), Use .Hide()
        public static MainMenuForm instance;
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void toLoginButton_Click(object sender, EventArgs e)
        {
            if (Program.LoggedIn)
            {
                LoggedIn loggedIn = new LoggedIn();
                loggedIn.Show();
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                instance = this;
                loginForm.Show();
                this.Hide();
            }
        }

        private void MainMenuPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cheeseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void veggieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pepperoniComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void meatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int orderID = Orders.nextOrderID;
        private static string text = "";
        public static ArrayList itemsOrdered = new ArrayList();

        private void cheeseAddButton_Click(object sender, EventArgs e)
        {
            if (cheeseComboBox.SelectedIndex == -1)
            {
                NoItem noItem = new NoItem();
                noItem.Show();
            }
            else
            {
                if (itemsOrdered.Count < 10)
                {
                    LineItems lineItems = new LineItems();
                    int item;
                    int option;
                    lineItems.OrderID = orderID;
                    if (cheeseQuantity.SelectedIndex == 0)
                    {
                        lineItems.Quantity = 1;
                    }
                    else if (cheeseQuantity.SelectedIndex == 1)
                    {
                        lineItems.Quantity = 2;
                    }
                    else if (cheeseQuantity.SelectedIndex == 2)
                    {
                        lineItems.Quantity = 3;
                    }
                    else if (cheeseQuantity.SelectedIndex == 3)
                    {
                        lineItems.Quantity = 4;
                    }
                    else if (cheeseQuantity.SelectedIndex == 4)
                    {
                        lineItems.Quantity = 5;
                    }
                    else
                    {
                        lineItems.Quantity = 0;
                    }
                    if (cheeseComboBox.SelectedIndex == 0)
                    {
                        item = 1;
                        option = 1;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 7.49;
                    }
                    else if (cheeseComboBox.SelectedIndex == 1)
                    {
                        item = 1;
                        option = 2;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 9.49;
                    }
                    else if (cheeseComboBox.SelectedIndex == 2)
                    {
                        item = 1;
                        option = 3;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 10.49;
                    }
                    else if (cheeseComboBox.SelectedIndex == 3)
                    {
                        item = 1;
                        option = 4;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 12.49;
                    }
                    if (lineItems.Quantity != 0)
                    {
                        lineItems.Description = lineItems.ToString();
                        lineItems.Price = lineItems.Price * lineItems.Quantity;
                        itemsOrdered.Add(lineItems);
                        LineItems.CreateLineItem(lineItems);
                        text += lineItems.Description + " $" + lineItems.Price + "\n";
                        cartLabel.Text = text;
                    }
                    else
                    {
                        Quantity0 quantity0 = new Quantity0();
                        quantity0.Show();
                    }
                }
                else
                {
                    CartFullForm cartFullForm = new CartFullForm();
                    cartFullForm.Show();
                }
            }
        }

        private void veggieAddButton_Click(object sender, EventArgs e)
        {
            if (veggieComboBox.SelectedIndex == -1)
            {
                NoItem noItem = new NoItem();
                noItem.Show();
            }
            else
            {
                if (itemsOrdered.Count < 10)
                {
                    LineItems lineItems = new LineItems();
                    int item;
                    int option;
                    lineItems.OrderID = orderID;
                    if (veggieQuantity.SelectedIndex == 0)
                    {
                        lineItems.Quantity = 1;
                    }
                    else if (veggieQuantity.SelectedIndex == 1)
                    {
                        lineItems.Quantity = 2;
                    }
                    else if (veggieQuantity.SelectedIndex == 2)
                    {
                        lineItems.Quantity = 3;
                    }
                    else if (veggieQuantity.SelectedIndex == 3)
                    {
                        lineItems.Quantity = 4;
                    }
                    else if (veggieQuantity.SelectedIndex == 4)
                    {
                        lineItems.Quantity = 5;
                    }
                    else
                    {
                        lineItems.Quantity = 0;
                    }
                    if (veggieComboBox.SelectedIndex == 0)
                    {
                        item = 3;
                        option = 1;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 9.99;
                    }
                    else if (veggieComboBox.SelectedIndex == 1)
                    {
                        item = 3;
                        option = 2;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 11.99;
                    }
                    else if (veggieComboBox.SelectedIndex == 2)
                    {
                        item = 3;
                        option = 3;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 12.99;
                    }
                    else if (veggieComboBox.SelectedIndex == 3)
                    {
                        item = 3;
                        option = 4;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 14.99;
                    }
                    if (lineItems.Quantity != 0)
                    {
                        lineItems.Description = lineItems.ToString();
                        lineItems.Price = lineItems.Price * lineItems.Quantity;
                        itemsOrdered.Add(lineItems);
                        LineItems.CreateLineItem(lineItems);
                        text += lineItems.Description + " $" + lineItems.Price + "\n";
                        cartLabel.Text = text;
                    }
                    else
                    {
                        Quantity0 quantity0 = new Quantity0();
                        quantity0.Show();
                    }
                }
                else
                {
                    CartFullForm cartFullForm = new CartFullForm();
                    cartFullForm.Show();
                }
            }
        }
        private void pepperoniAddButton_Click(object sender, EventArgs e)
        {
            if (pepperoniComboBox.SelectedIndex == -1)
            {
                NoItem noItem = new NoItem();
                noItem.Show();
            }
            else
            {
                if (itemsOrdered.Count < 10)
                {
                    LineItems lineItems = new LineItems();
                    int item;
                    int option;
                    lineItems.OrderID = orderID;
                    if (pepperoniQuantity.SelectedIndex == 0)
                    {
                        lineItems.Quantity = 1;
                    }
                    else if (pepperoniQuantity.SelectedIndex == 1)
                    {
                        lineItems.Quantity = 2;
                    }
                    else if (pepperoniQuantity.SelectedIndex == 2)
                    {
                        lineItems.Quantity = 3;
                    }
                    else if (pepperoniQuantity.SelectedIndex == 3)
                    {
                        lineItems.Quantity = 4;
                    }
                    else if (pepperoniQuantity.SelectedIndex == 4)
                    {
                        lineItems.Quantity = 5;
                    }
                    else
                    {
                        lineItems.Quantity = 0;
                    }
                    if (pepperoniComboBox.SelectedIndex == 0)
                    {
                        item = 2;
                        option = 1;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 7.98;
                    }
                    else if (pepperoniComboBox.SelectedIndex == 1)
                    {
                        item = 2;
                        option = 2;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 9.98;
                    }
                    else if (pepperoniComboBox.SelectedIndex == 2)
                    {
                        item = 2;
                        option = 3;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 10.98;
                    }
                    else if (pepperoniComboBox.SelectedIndex == 3)
                    {
                        item = 2;
                        option = 4;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 12.98;
                    }
                    if (lineItems.Quantity != 0)
                    {
                        lineItems.Description = lineItems.ToString();
                        lineItems.Price = lineItems.Price * lineItems.Quantity;
                        itemsOrdered.Add(lineItems);
                        LineItems.CreateLineItem(lineItems);
                        text += lineItems.Description + " $" + lineItems.Price + "\n";
                        cartLabel.Text = text;
                    }
                    else
                    {
                        Quantity0 quantity0 = new Quantity0();
                        quantity0.Show();
                    }
                }
                else
                {
                    CartFullForm cartFullForm = new CartFullForm();
                    cartFullForm.Show();
                }
            }
        }

        private void meatAddButton_Click(object sender, EventArgs e)
        {
            if (meatComboBox.SelectedIndex == -1)
            {
                NoItem noItem = new NoItem();
                noItem.Show();
            }
            else
            {
                if (itemsOrdered.Count < 10)
                {
                    LineItems lineItems = new LineItems();
                    int item;
                    int option;
                    lineItems.OrderID = orderID;
                    if (meatQuantity.SelectedIndex == 0)
                    {
                        lineItems.Quantity = 1;
                    }
                    else if (meatQuantity.SelectedIndex == 1)
                    {
                        lineItems.Quantity = 2;
                    }
                    else if (meatQuantity.SelectedIndex == 2)
                    {
                        lineItems.Quantity = 3;
                    }
                    else if (meatQuantity.SelectedIndex == 3)
                    {
                        lineItems.Quantity = 4;
                    }
                    else if (meatQuantity.SelectedIndex == 4)
                    {
                        lineItems.Quantity = 5;
                    }
                    else
                    {
                        lineItems.Quantity = 0;
                    }
                    if (meatComboBox.SelectedIndex == 0)
                    {
                        item = 4;
                        option = 1;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 10.99;
                    }
                    else if (meatComboBox.SelectedIndex == 1)
                    {
                        item = 4;
                        option = 2;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 12.99;
                    }
                    else if (meatComboBox.SelectedIndex == 2)
                    {
                        item = 4;
                        option = 3;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 13.99;
                    }
                    else if (meatComboBox.SelectedIndex == 3)
                    {
                        item = 4;
                        option = 4;
                        lineItems.ItemID1 = item;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 15.99;
                    }
                    if (lineItems.Quantity != 0)
                    {
                        lineItems.Description = lineItems.ToString();
                        lineItems.Price = lineItems.Price * lineItems.Quantity;
                        itemsOrdered.Add(lineItems);
                        LineItems.CreateLineItem(lineItems);
                        text += lineItems.Description + " $" + lineItems.Price + "\n";
                        cartLabel.Text = text;
                    }
                    else
                    {
                        Quantity0 quantity0 = new Quantity0();
                        quantity0.Show();
                    }
                }
                else
                {
                    CartFullForm cartFullForm = new CartFullForm();
                    cartFullForm.Show();
                }
            }
        }

        private void drinkTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drinkOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void drinkAddButton_Click(object sender, EventArgs e)
        {
            if (drinkTypeComboBox.SelectedIndex == -1)
            {
                NoItem noItem = new NoItem();
                noItem.Show();
            }
            else if (drinkOptionComboBox.SelectedIndex == -1)
            {
                NoOption noOption = new NoOption();
                noOption.Show();
            }
            else
            {
                if (itemsOrdered.Count < 10)
                {
                    LineItems lineItems = new LineItems();
                    int item;
                    int option;
                    lineItems.OrderID = orderID;
                    if (drinkQuantity.SelectedIndex == 0)
                    {
                        lineItems.Quantity = 1;
                    }
                    else if (drinkQuantity.SelectedIndex == 1)
                    {
                        lineItems.Quantity = 2;
                    }
                    else if (drinkQuantity.SelectedIndex == 2)
                    {
                        lineItems.Quantity = 3;
                    }
                    else if (drinkQuantity.SelectedIndex == 3)
                    {
                        lineItems.Quantity = 4;
                    }
                    else if (drinkQuantity.SelectedIndex == 4)
                    {
                        lineItems.Quantity = 5;
                    }
                    else
                    {
                        lineItems.Quantity = 0;
                    }
                    if (drinkTypeComboBox.SelectedIndex == 0)
                    {
                        item = 24;
                        lineItems.ItemID1 = item;
                    }
                    else if (drinkTypeComboBox.SelectedIndex == 1)
                    {
                        item = 25;
                        lineItems.ItemID1 = item;
                    }
                    else if (drinkTypeComboBox.SelectedIndex == 2)
                    {
                        item = 26;
                        lineItems.ItemID1 = item;
                    }
                    else if (drinkTypeComboBox.SelectedIndex == 3)
                    {
                        item = 27;
                        lineItems.ItemID1 = item;
                    }
                    else if (drinkTypeComboBox.SelectedIndex == 4)
                    {
                        item = 28;
                        lineItems.ItemID1 = item;
                    }
                    if (drinkOptionComboBox.SelectedIndex == 0)
                    {
                        option = 10;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 1.50;
                    }
                    else if (drinkOptionComboBox.SelectedIndex == 1)
                    {
                        option = 11;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 2.00;
                    }
                    else if (drinkOptionComboBox.SelectedIndex == 2)
                    {
                        option = 12;
                        lineItems.OptionID1 = option;
                        lineItems.Price = 3.00;
                    }
                    if (lineItems.Quantity != 0)
                    {
                        lineItems.Description = lineItems.ToString();
                        lineItems.Price = lineItems.Price * lineItems.Quantity;
                        itemsOrdered.Add(lineItems);
                        LineItems.CreateLineItem(lineItems);
                        text += lineItems.Description + " $" + lineItems.Price + "\n";
                        cartLabel.Text = text;
                    }
                    else
                    {
                        Quantity0 quantity0 = new Quantity0();
                        quantity0.Show();
                    }
                }
                else
                {
                    CartFullForm cartFullForm = new CartFullForm();
                    cartFullForm.Show();
                }
            }
        }

        private void cartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createOwnButton_Click(object sender, EventArgs e)
        {
            if (itemsOrdered.Count < 10)
            {
                CustomOrder customOrderForm = new CustomOrder();
                customOrderForm.Show();
                instance = this;
                this.Hide();
            }
            else
            {
                CartFullForm cartFull = new CartFullForm();
                cartFull.Show();
            }
        }

        private void toCartButton_Click(object sender, EventArgs e)
        {
            ShoppingCart cartForm = new ShoppingCart();
            cartForm.Show();
            instance = this;
            this.Hide();
        }

        private void toCheckOutButton_Click(object sender, EventArgs e)
        {
            CheckoutPageForm checkOutForm = new CheckoutPageForm();
            checkOutForm.Show();
            instance = this;
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void cheeseQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void veggieQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pepperoniQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void meatQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drinkQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        public string CartLabel
        {
            get { return this.cartLabel.ToString(); }
            set { this.cartLabel.Text = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
