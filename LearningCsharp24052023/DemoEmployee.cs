using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    internal class DemoEmployee
    {
        public static void Main(string[] args)
        {
            Employee saurabh = new Employee();

            saurabh.Salary = 100000;
            saurabh.Bonus = 5000;

            saurabh.CalculateSalary();

            Employee harman = new Employee();

            harman.Salary = 87943534;
            harman.Bonus = 8797;

            int harmanSalary =   harman.CalculateSalary2();

            Console.WriteLine( "Harman's Salary - "+ harmanSalary);

            Employee gaurav = new Employee();

            gaurav.Salary = 90000;

            gaurav.CalculateSalary();

            Employee damien = new Employee(80000, 67770);

            damien.CalculateSalary();
        }
    }
}
