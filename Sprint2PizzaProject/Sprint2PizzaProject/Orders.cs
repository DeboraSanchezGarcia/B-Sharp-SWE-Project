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
        
        public Orders()
        {
            orderID = nextOrderID++;
            phoneNumber = "";
            orderType = "";
            paymentType = "";
            subtotal = 0.0;
            tax = 0.0;
            deliveryFee = 0.0;
            total = 0.0;
            date = DateTime.Now.ToString("MM/dd/yyyy");
            isFavorite = false;
        }
        
        public Orders(string phoneNumber, string orderType, string paymentType, double subtotal, double tax, double deliveryFee, double total, string date, bool isFavorite)
        {
            this.orderID = nextOrderID++;
            this.phoneNumber = phoneNumber;
            this.orderType = orderType;
            this.paymentType = paymentType;
            this.subtotal = subtotal;
            this.tax = tax;
            this.deliveryFee = deliveryFee;
            this.total = total;
            this.date = date;
            this.isFavorite = isFavorite;
        }
        // getters and setters
        public int OrderID
        {
            get { return orderID; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string OrderType
        {
            get { return orderType; }
            set { orderType = value; }
        }
        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }
        public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }
        public double DeliveryFee
        {
            get { return deliveryFee; }
            set { deliveryFee = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public bool IsFavorite
        {
            get { return isFavorite; }
            set { isFavorite = value; }
        }
        // method to create a new order
        public void CreateOrder(Orders order)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Orders.txt", append: true))
                {
                    // Serialize to CSV format
                    string orderData = $"{order.OrderID}, {order.PhoneNumber}, {order.OrderType}, {order.PaymentType}, {order.Subtotal}, {order.Tax}, {order.DeliveryFee}, {order.Total}, {order.Date}, {order.IsFavorite}";
                    sw.WriteLine(orderData);
                }
                Console.WriteLine("Order created successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }
        // method to read an order by id
        public static Orders ReadOrder(int orderID)
        {
            Orders order = new Orders();
            try
            {
                using (StreamReader sr = new StreamReader("Orders.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] orderData = line.Split(',');
                        if (Convert.ToInt32(orderData[0].Trim()) == orderID)
                        {
                            order.orderID = Convert.ToInt32(orderData[0].Trim());
                            order.phoneNumber = orderData[1].Trim();
                            order.orderType = orderData[2].Trim();
                            order.paymentType = orderData[3].Trim();
                            order.subtotal = Convert.ToDouble(orderData[4].Trim());
                            order.tax = Convert.ToDouble(orderData[5].Trim());
                            order.deliveryFee = Convert.ToDouble(orderData[6].Trim());
                            order.total = Convert.ToDouble(orderData[7].Trim());
                            order.date = orderData[8].Trim();
                            order.isFavorite = Convert.ToBoolean(orderData[9].Trim());
                            return order;
                        }
                    }
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Error reading file: " + ioex.Message);
            }
            return order; // returns default object if not found
        }
        // method to update existing order
        public void UpdateOrder(Orders updatedOrder)
        {
            try
            {
                string[] lines = File.ReadAllLines("Orders.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] orderData = lines[i].Split(',');
                    if (Convert.ToInt32(orderData[0].Trim()) == updatedOrder.OrderID)
                    {
                        // update the line with new data
                        lines[i] = $"{updatedOrder.OrderID}, {updatedOrder.PhoneNumber}, {updatedOrder.OrderType}, {updatedOrder.PaymentType}, {updatedOrder.Subtotal}, {updatedOrder.Tax}, {updatedOrder.DeliveryFee}, {updatedOrder.Total}, {updatedOrder.Date}, {updatedOrder.IsFavorite}";
                        break;
                    }
                }
                File.WriteAllLines("Orders.txt", lines); // write all lines back to file
                Console.WriteLine("Order updated successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error updating file: " + ex.Message);
            }
        }
    }
}

