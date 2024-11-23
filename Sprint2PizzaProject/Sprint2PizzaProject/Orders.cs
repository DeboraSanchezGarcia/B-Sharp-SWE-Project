using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2PizzaProject
{
    internal class Orders
    {
        private int orderID;
        private string phoneNumber, orderType, paymentType, date;
        private double subtotal, tax, deliveryFee, total;
        private bool isFavorite;
        private static int nextOrderID = 10001;
    }
}
