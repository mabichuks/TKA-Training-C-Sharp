using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    public class Employee : Person
    {
        public string Name {  get;  set; }
        public int Age { get; set; }
        public string Department { get; set; }
    }
    public class Person
    {
        public Person()
        {
            
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void SayName()
        {
            Console.WriteLine("Person says their name");
        }

    }

    public class Student : Person
    {
        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
                
        }
        public override void SayName()
        {
            Console.WriteLine("My name is??");
        }
    }
    public class Animal
    {
        public virtual void Speak()
        {
            Person person = new Person();
            Console.WriteLine("Animal speaks");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
           Console.WriteLine("Woof  Woof");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}