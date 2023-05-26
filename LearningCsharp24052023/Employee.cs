using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    public class Employee
    {
        public int Salary;

        public int Bonus;

        public Employee() 
        {
            Salary = 70000;
            Bonus = 7000;
        }


        public Employee(int Salary, int Bonus)
        {

            this.Salary = Salary;

            this.Bonus = Bonus;
           
        }



        public void CalculateSalary()
        {
            int totalSalary = Salary + Bonus;

            Console.WriteLine( "Total Salary - "+ totalSalary);

        }

        public int CalculateSalary2()
        {
            int totalSalary = Salary + Bonus;

            return totalSalary;

        }

        public int CalculateSalary2(int sal, int bon)
        {
            int totalSalary = sal + bon;

            return totalSalary;

        }

        public int CalculateSalary3(int Salary, int Bonus)
        {
            int totalSalary = Salary + Bonus;

            return totalSalary;

        }
    }
}
