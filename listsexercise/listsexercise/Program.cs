using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listsexercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Book Collection called Specs");

            List<string> books = new List<string>();

            books.Add("A Hitch-hikers Guide To The Galaxy");
            books.Add("To Kill A Mockingbird");
            books.Add("451 Fahrenheit");
            books.Add("Then");

            foreach (string b in books)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("Add another book or click x to exit");
            string userInput = Console.ReadLine().ToLower();


            //string noMore = "";
            while (userInput != "x")
            {
                books.Add(userInput);
                Console.WriteLine("Add another book or click x to exit");
                userInput = Console.ReadLine();
            }
            foreach (string b in books)
            {
                Console.WriteLine(b);
            }

         
        } //main
    }//class
}//namespace
