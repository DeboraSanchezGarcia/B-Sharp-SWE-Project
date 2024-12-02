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
    public partial class CartEmpty : Form
    {
        public CartEmpty()
        {
            InitializeComponent();
        }

        private void cartEmptyReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
