using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    public class LinqDemo
    {
        public void LinqExample()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Using LINQ to filter even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            // Using LINQ to find the sum of all numbers
            var sum = numbers.Sum();
            Console.WriteLine($"Sum of all numbers: {sum}");
        }
    }
}
