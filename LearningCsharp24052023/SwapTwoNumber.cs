using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    internal class SwapTwoNumber
    {
        public static void Main()
        {
            int firstNumber = 10;
            int secondNumber = 20;

            int temp;

            temp = firstNumber;

            firstNumber = secondNumber;

            secondNumber = temp;

            Console.WriteLine("First Number " + firstNumber + " and the second number is "+ secondNumber);
        }
    }
}
