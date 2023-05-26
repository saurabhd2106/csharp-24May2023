using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    internal class MaxOutOfTwoNumber
    {
        public static void Main(String[] arg)
        {
            int firstNumber = 78;
            int secondNumber = 78;

            if(firstNumber > secondNumber)
            {
                Console.WriteLine("First number is greater");
            } else if(secondNumber > firstNumber)
            {
                Console.WriteLine(  "Second number is greater");
            } else
            {
                Console.WriteLine(  "Both are equal");
            }
        }
    }
}
