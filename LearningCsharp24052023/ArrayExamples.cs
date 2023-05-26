using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    internal class ArrayExamples
    {

        public static void Main(string[] args)
        {
            int[] arr = new int[5];

            arr[0] = 10;
            arr[1] = 78;
            arr[2] = 90;
            arr[3] = 45;
            arr[4] = 187;

            Console.WriteLine(arr[3]);

            int max = arr[0];

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] > max)
                {
                   max = arr[i];
                }

            }

            Console.WriteLine("Maximum value is " + max); 
            
            int[] intArr = new int[] { 104, 220, 30, 140 };

            int[] intArr2 = { 45, 67, 87, 43, 23};

           int max2 = intArr[0];

            foreach (int i in intArr)
            {
                if(i > max2)
                {
                    max2 = i;
                }
            }

            Console.WriteLine("Maximum value is " + max2);
        }
    }
}
