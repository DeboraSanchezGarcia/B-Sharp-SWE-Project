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
    public partial class NoCheese : Form
    {
        public NoCheese()
        {
            InitializeComponent();
        }

        private void noCheeseReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}