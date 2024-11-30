using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        // "PersitentNextorderID.txt"
        private static string txtFile = "C:\\Users\\atidw\\source\\repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\PersistentNextOrderID.txt";
        public static int nextOrderID = GetNextOrderID(txtFile);
        
        public Orders()
        {
            orderID = nextOrderID;
            deliveryFee = 4.99;
            nextOrderID++;
            SetNextOrderID(txtFile);
        }
        
        public Orders(string phoneNumber, string orderType, string paymentType, double subtotal, double tax, double total, string date, bool isFavorite)
        {
            this.orderID = nextOrderID;
            this.phoneNumber = phoneNumber;
            this.orderType = orderType;
            this.paymentType = paymentType;
            this.subtotal = subtotal;
            this.tax = tax;
            deliveryFee = 4.99;
            this.total = total;
            this.date = date;
            this.isFavorite = isFavorite;
            nextOrderID++;
            SetNextOrderID(txtFile);
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
        public static void CreateOrder(Orders order)
        {
            try
            {
                // "Orders.txt"
                using (StreamWriter sw = new StreamWriter("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Orders.txt", append: true))
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
                // "Orders.txt"
                using (StreamReader sr = new StreamReader("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Orders.txt"))
                {
                    string line;
                    bool isFavorite = false;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] orderData = line.Split(',');
                        if (orderData[0].Equals("OrderID"))
                        {
                            continue;
                        }
                        for (int x = 0; x < orderData.Length; x++)
                        {
                            orderData[x] = orderData[x].Trim();
                        }
                        if (Convert.ToInt32(orderData[0]) == orderID)
                        {
                            order.orderID = Convert.ToInt32(orderData[0]);
                            order.phoneNumber = orderData[1];
                            order.orderType = orderData[2];
                            order.paymentType = orderData[3];
                            order.subtotal = Convert.ToDouble(orderData[4]);
                            order.tax = Convert.ToDouble(orderData[5]);
                            order.deliveryFee = Convert.ToDouble(orderData[6]);
                            order.total = Convert.ToDouble(orderData[7]);
                            order.date = orderData[8];
                            if ((orderData[9].ToLower()).Equals("yes"))
                            {
                                isFavorite = true;
                            }
                            order.isFavorite = isFavorite;
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
        public static void UpdateOrder(Orders updatedOrder)
        {
            try
            {
                // "Orders.txt"
                string[] lines = File.ReadAllLines("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Orders.txt");
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
                File.WriteAllLines("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\Orders.txt", lines); // write all lines back to file
                Console.WriteLine("Order updated successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error updating file: " + ex.Message);
            }
        }

        public static void DeleteOrder(int orderID)
        {
            try
            {
                // "LineItems.txt"
                string[] lines = File.ReadAllLines("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\LineItems.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] orderData = lines[i].Split(',');
                    if (Convert.ToInt32(orderData[0].Trim()) == orderID)
                    {
                        // update line with new data
                        lines[i] = "\b";
                        break;
                    }
                }
                // "LineItems.txt"
                File.WriteAllLines("C:\\Users\\atidw\\Source\\Repos\\B-Sharp-SWE-Project\\Sprint2PizzaProject\\Sprint2PizzaProject\\LineItems.txt", lines); // write all lines back to file
                Console.WriteLine("Item updated successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error updating file: " + ex.Message);
            }
        }

        public static int GetNextOrderID(string txtFile)
        {
            StreamReader sr = new StreamReader(txtFile);
            string line = sr.ReadLine();
            sr.Close();
            return Convert.ToInt32(line);
        }
        public static void SetNextOrderID(string txtFile)
        {
            StreamWriter sw = new StreamWriter(txtFile);
            string line = nextOrderID.ToString();
            sw.WriteLine(line);
            sw.Close();
        }
    }
}

