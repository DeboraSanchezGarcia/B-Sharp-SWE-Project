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
    public partial class LoggedIn : Form
    {
        public LoggedIn()
        {
            InitializeComponent();
        }

        private void continueToOrderButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoggedIn_Load(object sender, EventArgs e)
        {

        }
    }
}