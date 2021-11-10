using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("Akhtala","Abovyan",23);
            Employee employee = new Employee(5,"Levon","Hakhverdyan",address);
            employee.display();
            Console.ReadKey();
        }
    }
}
