using System.Xml.Linq;

namespace DemoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
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
