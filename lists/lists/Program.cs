using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> movies = new List<string>();

            movies.Add("Pulp Fiction");
            movies.Add("Black Panther");
            movies.Add("Hangover");

            foreach(string m in movies)
            {
                Console.WriteLine(m);
            }

            movies.Sort();

            foreach (string m in movies)
            {
                Console.WriteLine(m);
            }

            movies.Remove("Hangover");

            foreach (string m in movies)
            {
                Console.WriteLine(m);
            }

            bool hangover = movies.Contains("Hangover");

            if(hangover)
            {
                Console.WriteLine("Hangover is on the list");
            }
            else
            {
                Console.WriteLine();

                Console.WriteLine("There are" + movies.Count + "movies in the list");
               
            }
        }
    }
}
