﻿using System;
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
    public partial class CartEmpty : Form
    {
        public CartEmpty()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Closes error and returns to previous screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cartEmptyReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
