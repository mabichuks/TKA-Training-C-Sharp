using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemoApp
{
    public static class Utility
    {
        // Static method to generate a list of customers with real-like names
        public static List<Customer> GetCustomerList()
        {
            List<Customer> customers = new List<Customer>();
            string[] firstNames = { "Alice", "Bob", "Charlie", "Diana", "Eve", "Frank", "Grace", "Heidi", "Ivan", "Judy" };
            string[] lastNames = { "Smith", "Jones", "Williams", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson" };

            for (int i = 0; i < 10; i++) // Generate 10 customers
            {
                customers.Add(new Customer(
                    id: i + 1,
                    firstName: firstNames[i],
                    lastName: lastNames[i]
                ));
            }
            return customers;
        }

        // Static method to generate a list of vendors with real-like names
        public static List<Vendor> GetVendorList()
        {
            List<Vendor> vendors = new List<Vendor>();
            string[] vendorNames = { "Tech Innovations Inc.", "Global Supply Co.", "United Distributors", "Prime Solutions Ltd.", "Rapid Logistics" };

            for (int i = 0; i < 5; i++) // Generate 5 vendors
            {
                vendors.Add(new Vendor(
                    id: i + 1,
                    name: vendorNames[i]
                ));
            }
            return vendors;
        }

        // Static method to generate a list of orders with real-like details
        public static List<Order> GetOrderList()
        {
            List<Order> orders = new List<Order>();
            Random rand = new Random();

            // Using the actual customers and vendors generated for better linking
            List<Customer> customers = GetCustomerList();
            List<Vendor> vendors = GetVendorList();

            string[] itemDetails = {
                "Laptop (Dell XPS 15, i7, 16GB RAM)",
                "Office Chair (Ergonomic Mesh)",
                "Wireless Mouse (Logitech MX Master 3)",
                "USB-C Hub (7-in-1 adapter)",
                "Monitor (27-inch 4K IPS)",
                "Keyboard (Mechanical RGB)",
                "Webcam (Full HD 1080p)",
                "Noise-Cancelling Headphones",
                "External SSD (1TB, USB 3.2)",
                "Printer (All-in-One Inkjet)",
                "Networking Cable (Cat 6, 10m)",
                "Standing Desk Converter",
                "Laptop Sleeve (15-inch, padded)",
                "Monitor Stand (Dual arm)",
                "Power Strip (Surge Protector, 6 outlets)"
            };

            for (int i = 1; i <= 15; i++) // Generate 15 orders
            {
                // Select a random customer and vendor ID from the generated lists
                int randomCustomerId = customers[rand.Next(customers.Count)].Id;
                int randomVendorId = vendors[rand.Next(vendors.Count)].Id;

                orders.Add(new Order(
                    id: i,
                    customerId: randomCustomerId,
                    orderNumber: $"PO-{DateTime.Now.Year}-{i:D4}-{Guid.NewGuid().ToString().Substring(0, 4).ToUpper()}", // More structured order number
                    vendorId: randomVendorId,
                    itemDetails: itemDetails[i - 1] // Assign specific detail based on loop index
                ));
            }
            return orders;
        }
    }



}


namespace DataObjects
{
    // --- Customer.cs ---
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Customer(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {FirstName} {LastName}";
        }
    }

    // --- Order.cs ---
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string OrderNumber { get; set; }
        public int VendorId { get; set; }
        public string ItemDetails { get; set; } // New property for realistic order details

        public Order(int id, int customerId, string orderNumber, int vendorId, string itemDetails)
        {
            Id = id;
            CustomerId = customerId;
            OrderNumber = orderNumber;
            VendorId = vendorId;
            ItemDetails = itemDetails;
        }

        public override string ToString()
        {
            return $"Id: {Id}, CustomerId: {CustomerId}, Order#: {OrderNumber}, VendorId: {VendorId}, Details: {ItemDetails}";
        }
    }

    // --- Vendor.cs ---
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Vendor(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
