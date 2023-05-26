using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    internal class SwitchExample
    {

        public static void Main(string[] args)
        {
            int dayOfTheWeek = 1;

            switch (dayOfTheWeek) {
                case 0:
                    Console.WriteLine( "It's Monday");
                    break;
                case 1:
                    Console.WriteLine("Tuesday");
                    break;

                case 2:
                    Console.WriteLine("Wednesday");
                    break;

                case 3:
                    Console.WriteLine("Thirsday");
                    break;
                case 4:
                    Console.WriteLine("Friday");
                    break;
                case 5:
                    Console.WriteLine("Saturday");
                    break;
                case 6:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Wrong day");
                    break;
            }
        }
    }
}
