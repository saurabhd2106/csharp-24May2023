using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{

    public class EmployeeDetail
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public long PhoneNumber { get; set; }

        public string Address { get; set; }

    }

    internal class SerializationBasics
    {
        public static void Main(string[] args)
        {
            var saurabh = new EmployeeDetail();

            saurabh.Name = "Saurabh";

            saurabh.Address = "974/12 Krishna colony";

            saurabh.PhoneNumber = 7843545l;

            saurabh.Age = 15;


            string employeeDataAsJson = JsonSerializer.Serialize(saurabh);

            Console.WriteLine( employeeDataAsJson);
        }

    }
}
