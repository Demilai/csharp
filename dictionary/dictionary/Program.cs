using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> recipes = new Dictionary<string, string>();

            recipes.Add("Cake", "Beat butter, sugar, eggs. bake in the oven.");
            recipes.Add("Bread", "flour, yeast, water & hope.");
            recipes.Add("Pizza", "dough, tomatoes, cheese, skip the anchovies.");

            foreach(KeyValuePair<string, string>kvp in recipes)
            {
                Console.WriteLine("The dish is: " + kvp.Key);
                Console.WriteLine("The method is: " + kvp.Value);
                Console.WriteLine();
            }

            if(recipes.ContainsKey("cake"))
            {
                Console.WriteLine("Cake is in the recipe ditionary");
            }
            else
            {
                Console.WriteLine("Sorry, no cake!");
            }
            if (recipes.ContainsValue("flour,yeast,water and hope"))
            {
                Console.WriteLine("flour,yeast,water and hope is in the recipe ditionary");
            }
            else
            {
                Console.WriteLine("Sorry, no flour,yeast,water and hope!");
            }

            string result = "";
            bool found = recipes.TryGetValue("Pizza", out result);

            if(found)
            {
                Console.WriteLine("The recpie ")
            }
        }
    }
}
