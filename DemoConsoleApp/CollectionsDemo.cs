using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    public class CollectionsDemo
    {
        //List
        //Stack
        //Queue
        //Dictionary
        //hashset
        //Array

        //Array

        public void ListDemo()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> numbers1 = new List<int>();
            numbers.Add(2);
            numbers.RemoveAt(3);
            numbers.Insert(2, 10); // Insert 10 at index 2
        }

        public void StackDemo()
        { //LIFO
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Top element: {stack.Peek()}"); // 3
            Console.WriteLine($"Popped element: {stack.Pop()}"); // 3
            Console.WriteLine($"Is stack empty? {stack.Count == 0}"); // False
        }

        public void QueueDemo() 
        { //FIFO
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine($"Front element: {queue.Peek()}"); // 1
            Console.WriteLine($"Dequeued element: {queue.Dequeue()}"); // 1
            Console.WriteLine($"Is queue empty? {queue.Count == 0}"); // False
        }

        //O(n)
        public void DictionaryDemo() 
        {             
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("One", 1);
            dictionary.Add("Two", 2);
            dictionary.Add("Three", 3);

            Console.WriteLine($"Value for 'Two': {dictionary["Two"]}"); // 2
            Console.WriteLine($"Contains key 'One'? {dictionary.ContainsKey("One")}"); // True
        }

        public void HashsetDemo() { 
            //O(1)
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);

            Console.WriteLine($"Contains 2? {hashSet.Contains(2)}"); // True
            hashSet.Remove(2);
            Console.WriteLine($"Contains 2 after removal? {hashSet.Contains(2)}"); // False
        }
        public void LoopDemo()
        {
            int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            //for loop
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                //sum = sum + arr[i];
                //sum += arr[i];
            }

  
            
            // for each loop
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            // while loop
            int j = 0;

            while(j < arr.Length)
            {
                Console.WriteLine(arr[j]);
                j++;
            }
            
        }

        //print array at ith value
        //add array to total sum
        //print total sum
        public void Solution1(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length ; i++)
            {
                Console.WriteLine($"Array at index {i} is {arr[i]}");
                sum += arr[i];
            }
            Console.WriteLine($"Total sum is {sum}");
        }
    }
}
