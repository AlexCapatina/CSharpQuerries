using Q1Lab4;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Question 01 - Lab 04");

        // Invokes methods
        Question1_1();
        Question1_2();
        Question1_3();
        Question1_4();
        Question1_5();
        Question1_6();


        // 1.1 List the names of the countries in alphabetical order [0.5 mark]
        void Question1_1()
        {
            Console.WriteLine("Question 1-1");
            IEnumerable<Country> countries = 
                from name in Country.GetCountries()
                orderby name.Name
                select name;
            foreach (Country country in countries)
            {
                Console.WriteLine(country.Name);
            }            
        }

        // 1.2 List the names of the countries in descending order of number of resources [0.5 mark]
        void Question1_2()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Question 1-2");
            IEnumerable<Country> resourceOrder = 
                from resources in Country.GetCountries()
                let count = resources.Resources.Count()
                orderby count descending
                select resources;

            foreach (Country country in resourceOrder)
            {
                Console.WriteLine(country.Name);
            }           
        }

        // 1.3 List the names of the countries that shares a border with Argentina [0.5 mark]
        void Question1_3()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Question 1-3");
            IEnumerable<Country> ArgentinaBorder = 
                from borders in Country.GetCountries()
                where borders.Borders.Contains("Argentina")
                orderby borders.Name
                select borders;

            foreach (Country country in ArgentinaBorder)
            {
                Console.WriteLine(country.Name);
            }
        }

        // 1.4 List the names of the countries that has more than 10,000,000 population [0.5 mark]
        void Question1_4()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Question 1-4");
            IEnumerable<Country> population =
                from countryPop in Country.GetCountries()
                where countryPop.Population > 10000000
                orderby countryPop.Name
                select countryPop;

            foreach (Country country in population)
            {
                Console.WriteLine(country.Name);
            }
        }

        // 1.5 List the country with highest population [1 mark]
        void Question1_5()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Question 1-5");

            var highPop =
                (from pop in Country.GetCountries()
                orderby pop.Population descending
                select pop).Take(1);     
            
            foreach (Country country in highPop)
            {
                Console.WriteLine(country.Name);
            }
        }

        // 1.6 List all the religion in south America in dictionary order [1 mark]
        void Question1_6()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Question 1-6");
            IEnumerable<string> religions =
                (from country in Country.GetCountries()
                 from religion in country.Religions                 
                 select religion
                 ).Distinct();
            foreach(var rel in religions)
            {
                Console.WriteLine(rel);
            }
        }
    }
}