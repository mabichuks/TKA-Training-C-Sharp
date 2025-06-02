using System.Xml.Linq;

namespace DemoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee
            {
                FirstName = "Chuck",
                LastName = "Norris"
            };

            Candidate candidate = new Candidate
            {
                FirstName = "Oisin",
                LastName = "McGarry",
            };

            GenericsDemo genericsDemo = new GenericsDemo();
            genericsDemo.GetVisitorName(emp);
            genericsDemo.GetVisitorName(candidate);

            //CollectionsDemo demo = new CollectionsDemo();
            //int[] arr = [1, 3, 45, 5, 3, 3, 4, 5, 2, 3];
            //demo.Solution1(arr);

            //Employee employee = new Employee
            //{
            //    Name = "John Doe",
            //    Age = 30,
            //    Department = "IT"
            //};

            //Employee employee1 = new Employee();
            //employee1.Name = "Jane Smith";
            //employee1.Age = 28;
            //employee1.Department = "HR";

           //create a student class with the properties name , age, college, qualification and write a method called PrintMe() to print the details of the student in the format below
            // Hello my name is {name}, I am {years old} i go to {college} college, I have {qualification} qualification 

            //string one = "One string";
            //string two = "Two string";

            //string three = one + " " + two; //One string Two string
            //string four = one + two; //One stringTwo string

            //string five = $"{one} {two}";
            //Console.WriteLine(employee.Name);
        }

        private static void DemoMethod()
        {
            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("Hello, Welcome!");

                Console.WriteLine("How old are you?");

                int age = int.Parse(Console.ReadLine());
                if (age < 18)
                {
                    Console.WriteLine($"Sorry, you are too young for a drink");
                }
                else
                {
                    Console.WriteLine($"You are {age} years old, Here is your drink");
                }


                Console.WriteLine("Do you want to play again? (yes (1)/no (any other key))");
                string response = Console.ReadLine();

                if (response == "1")
                {
                    Console.WriteLine("Great! Let's play again.");
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.ReadKey();
        }
    }
}
