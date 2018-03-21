using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> languages = new Dictionary<string, string>();

            languages.Add("Basic", "Simple Language");
            languages.Add("Ada", "Named After Lady Lovelace");
            languages.Add("c#", "Best of the best");
            languages.Add("Java", "Named after inventors fav coffee");
            languages.Add("Scratch", "Lil kiddies");

            foreach (KeyValuePair<string, string> kvp in languages)
            {
                Console.WriteLine("The language is " + kvp.Key);
                Console.WriteLine(",- " + kvp.Value);
                Console.WriteLine();
            }

            Console.WriteLine("Coding language for dictionary - choose K to find a key or V to find a value");

            string userinput = Console.ReadLine().ToLower();
            do
            {
                switch (userinput)
                {
                    case "k":
                        Console.WriteLine("Which key?");
                        string key = Console.ReadLine();
                        if (languages.ContainsKey(key))
                        {
                            Console.WriteLine(key + " is in the dictionary");
                        }
                        else
                        {
                            Console.WriteLine(key + " is not in the dictionary");
                        }
                        break;
                }
                Console.WriteLine("Type the language that you want");
            }
            while (userinput != "x");
        }
    }
}
