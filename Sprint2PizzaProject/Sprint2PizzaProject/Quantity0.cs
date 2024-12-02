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
    public partial class Quantity0 : Form
    {
        public Quantity0()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Returns to the menu that caused this error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
