using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    internal class ListExamples
    {

        public static void Main()
        {
            var lstNumber = new List<int>();

            lstNumber.Add(1);

            lstNumber.Add(20);

            lstNumber.Add(82);

            lstNumber.Insert(2, 98);

            Console.WriteLine(lstNumber[0]);

            foreach (var item in lstNumber)
            {
                Console.WriteLine(item);
            }


        }



    }
}
