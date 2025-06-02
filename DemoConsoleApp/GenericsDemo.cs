using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    public class CandidateCollection 
    {

    }
    public class Candidate : Person
    {
        public int Age { get; set; }
        public string Country { get; set; }
    }

    public class Country
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
    }

    //person class FirstName, LastName
    //Visitor class Company, TimeIn, TimeOut, Reason
    //visitor class inherits from person
    //create list of 5 visitors
    // print the details of each visitor in the format below
    //Visitor Details:  Name {firstname and last name}, Company, TimeIn, TimeOut, Reason, Person


    public class GenericsDemo
    {
        public List<Candidate> Candidates { get; set; } = new List<Candidate>
        {
            new Candidate { FirstName = "John", LastName = "Doe", Age = 30, Country = "USA" },
            new Candidate { FirstName = "Jane", LastName = "Smith", Age = 28, Country = "CAN" },
            new Candidate { FirstName = "Alice", LastName = "Johnson", Age = 25, Country = "GBR" },
            new Candidate { FirstName = "Bob", LastName = "Brown", Age = 35, Country = "USA" },
            new Candidate { FirstName = "Charlie", LastName = "Davis", Age = 22, Country = "DEU" },
            new Candidate { FirstName = "Eve", LastName = "Wilson", Age = 27, Country = "USA" },
        };

        public List<Country> countries { get; set; } = new List<Country>
        {
            new Country { Name = "United States of America", CountryCode = "USA" },
            new Country { Name = "Canada", CountryCode = "CAN" },
            new Country { Name = "United Kingdom", CountryCode = "GBR" },
            new Country { Name = "Germany", CountryCode = "DEU" },
            new Country { Name = "France", CountryCode = "FRA" },
        };

        public void LinqDemo()
        {
            // find everyone from USA
            //Language Integrated Query (LINQ) is a powerful feature in C# that allows you to query collections in a more readable and concise way.

            // query method syntax and lambda expressions

            CandidateCollection cc = new CandidateCollection();

            var query = from candidate in Candidates
                        where candidate.Country == "USA"
                        select candidate;

            Candidate[] candidates = query.ToArray();
            
            var lambda = candidates.Where((c) => c.Country == "USA").ToArray();

        }


        public void GetVisitorName<T>(T t) where T : List<Person>
        {
            // Console.WriteLine($"FirstName is {t.FirstName} and LastName is {t.LastName}");
            //foreach item in t print item first name and item last name

            foreach (var item in t)
            {
                Console.WriteLine($"FirstName is {item.FirstName} and LastName is {item.LastName}");
            }
        }
    }

    //Visitor Details:  Name, Company, TimeIn, TimeOut, Reason, Person
}
