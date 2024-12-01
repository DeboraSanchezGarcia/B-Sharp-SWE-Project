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
    public partial class NoItem : Form
    {
        public NoItem()
        {
            InitializeComponent();
        }

        private void notItemReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
