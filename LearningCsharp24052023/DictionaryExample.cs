using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    internal class DictionaryExample
    {
        public static void Main(string[] args)
        {
            var element = new Dictionary<string, string>();

            element.Add("name", "Saurabh");
            element.Add("age", "36");
            element.Add("address", "Gurgaon");

            Console.WriteLine(element["age"]);

            foreach (var item in element)
            {
                Console.WriteLine($"key is {item.Key} and the value is {item.Value}");
            }

        }
    }
}
