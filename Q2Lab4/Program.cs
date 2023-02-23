using System.Threading.Tasks.Dataflow;
using System.Linq;
using System;
using Q2Lab4;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity;
using System.Data.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Question 02 - Lab 04");

        // Invokes methods
        Question2_1();
        Question2_2();
        Question2_3();

        //1.Get a list of all the titles and the authors who wrote them. Sort the results by title. [2 marks]
        void Question2_1()
        {
            LINQtoSQLDataContext context = new ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Alex\\Desktop\\Lab04 - Solution Template\\Q2Lab4\\Database\\Books.mdf\";Integrated Security=True");
            var aut = new Author();
            
            var titlesByAuthor =
            from author in aut.AuthorISBNs
            orderby author.Title
            select new
            {
                Name = author.FirstName + " " + author.LastName,
                Titles =
                    from book in author.Titles
                    orderby book.Title1
                    select book.Title1
            };

            Console.WriteLine("Titles grouped by author:");

            foreach (var author in titlesByAuthor)
            {
                Console.WriteLine(author.Name);
                foreach (var title in author.Titles)
                {
                    Console.WriteLine(title);
                }
            }            
        }

        //2.Get a list of all the titles and the authors who wrote them. Sort the results by title.  Each title sort the authors alphabetically by last name, then first name[4 marks]
        void Question2_2()
        {
            var aut = new Author();

            var titlesByAuthor =
                from author in aut.AuthorISBNs
                orderby author.Title1, author.LastName, author.FirstName                
                select new
                {
                    Name = author.FirstName + " " + author.LastName,
                    Titles =
                        from book in author.Titles
                        orderby book.Title1
                        select book.Title1
                };

            Console.WriteLine("Titles grouped by author:");

            foreach (var author in titlesByAuthor)
            {
                Console.WriteLine(author.Name);
                foreach (var title in author.Titles)
                {
                    Console.WriteLine(title);
                }
            }
        }

        //3.Get a list of all the authors grouped by title, sorted by title; for a given title sort the author names alphabetically by last name then first name.[4 marks]
        void Question2_3()
        {

        }
    }
}