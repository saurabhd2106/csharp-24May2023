using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    internal class StringManipulation
    {
        public static void Main(string[] args)
        {

            string str = "    Saurabh is my name and I am a DevOps Trainer  ";

            Console.WriteLine(str);

            str = str.Trim();

            Console.WriteLine(str);

            bool strIsThere =  str.Contains("Herman");

            Console.WriteLine(strIsThere);

            bool startsWith = str.StartsWith("Saurabh");

            Console.WriteLine("String starts with saurabh : " + startsWith);

            Console.WriteLine(str.EndsWith("Trainer"));

            Console.WriteLine(str.ToLower());

            Console.WriteLine(str.ToUpper());

            String[] strArr = str.Split(' ');

            foreach (string temp in strArr) {

                Console.WriteLine(temp);

            }

        }
    }
}
