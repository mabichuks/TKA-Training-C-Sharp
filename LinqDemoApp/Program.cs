using DataObjects;
using System.Net.Sockets;

namespace LinqDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an array of strings
            //use linq to filter the array for words that start with A or B
            //sort the filtered words in alphabetic order

            //==================================================
            //Get all customers where first names start with A
            //use select tp project the fist and last name of the customers into a string
            // Get all orders with a laptop item
            // use select to project order number only into a string
            // use select to project the order number and item into an anoymous type with properties OrderNumber and Item
            // sort vendors alphabetically by name

            //join customers and orders on customer id. project the result into an anonymous type with CustomerName (first name + last name) OrderNumber and Items

            //var customerOrders2 = from c in customers
            //                      join o in orders
            //                      on c.Id equals o.CustomerId
            string name = "My name";

            Console.WriteLine("Hello, World!");

            int[] arr = [1, 3, 6, 5, 9, 7, 4, 5, 2, 3];
            int[] arr2 = [8,3,4,2,];
            //Skip and Take. Mostly used in pagination

            arr.Skip(3).Take(3);
            int pageNumber = 1;
            int pageSize = 10;

            List<int> list2 = arr.Where(i => i > 5).OrderBy(x => x).ToList();

            var reversed = arr.Reverse();

            IEnumerable<int> enumerable = from i in arr
                                          where i > 5
                                          orderby i descending
                                          select i;
            List<int> list3 = enumerable.ToList();


            List<int> list = new List<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 5)
                {
                    list.Add(arr[i]);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    //sort arr ascending
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            arr.Union(arr2); // Union of two arrays
            arr.Intersect(arr2); // Intersect of two arrays
            arr.Except(arr2); // Except of two arrays
            arr.OrderBy(i => i); // OrderBy


            // Where, OrderBy, OrderByDescending, Select, SelectMany, GroupBy, Join, GroupJoin, Distinct, Union, Intersect, Except


            var customers = Utility.GetCustomerList();
            var orders = Utility.GetOrderList();

            var customerOrder = customers.Join(orders, 
                customers => customers.Id,
                orders => orders.CustomerId, 
                (customer, order) => new 
                 {
                CustomerName = customer.FirstName + " " + customer.LastName,
                OrderNumber = order.OrderNumber,
                 }).ToList();

            var customerOrders2 = from c in customers
                                  where c.FirstName == "John"
                                  join o in orders
                                  on c.Id equals o.CustomerId
                                  select new
                                  {
                                      CustomerName = c.FirstName + " " + c.LastName,
                                      OrderNumber = o.OrderNumber,
                                  };

            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };
            List<Customer> customers2 = names.Select(customer => new Customer { FirstName = customer })
                .ToList();

            var query = from n in names
                        select new Customer
                        {
                            FirstName = n,
                        };
            List<Customer> customers3 = query.ToList();



 
                                               
        }

        public class CustomerOrder
        {
            public string CustomerName { get; set; }
            public string OrderNumber { get; set; }
        }
    }
}
