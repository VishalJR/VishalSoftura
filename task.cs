using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace ConsoleApp1
{
    class task
    {
        class Book
        {

            public int BookID { get; set; }
            public string BookName { get; set; }
            public int Price { get; set; }

            public string AuthorName { get; set; }
        }


        public static void Main()
        {
            IList<Book> StuData = new List<Book>()
            {
              new Book(){ BookID = 1 ,BookName="The Sorcerer's Stone",Price =2222,AuthorName="JK Rowling"},
              new Book(){ BookID = 2 , BookName="The ABC Murders",Price =223,AuthorName="Agatha Christie"},
              new Book(){ BookID = 3 , BookName="Secret Seven on the Trail", Price = 28,AuthorName="Enid Blyton"},
              new Book(){ BookID = 4 , BookName="Welcome to Halloween", Price = 21,AuthorName="RL Stine"}
             };
            //Console.WriteLine("Books Menu");
            // var BQry = from stud in StuData
            //           select stud;
            //  foreach (var v in BQry)
            //Console.WriteLine(v.BookID + " " + v.BookName+"  by "+v.AuthorName+" and the price is "+v.Price);
            Console.WriteLine("Sort by Author Name");
            var BQry = from stud in StuData
                       where stud.AuthorName.Contains("JK Rowling")
                       select stud;
            foreach (var names in BQry)
                Console.WriteLine(names.BookName+ " "+ "By " + names.AuthorName);

            // var BQry = from stud in StuData
            //   orderby stud.Price
            // select stud;
            //foreach (var names in BQry)
            // Console.WriteLine(names.Price + " " + names.BookName);
            //Console.WriteLine("Books by Author");
            //var BQry = from stud in StuData
            //       orderby stud.AuthorName
            //        select stud;
            //foreach (var names in BQry)
            //  Console.WriteLine(names.AuthorName + " " + names.BookName);

        }
    }
}

