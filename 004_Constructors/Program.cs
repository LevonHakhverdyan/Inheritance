using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass(44, 33);
            Console.WriteLine(derivedClass._baseNumber);
            Console.WriteLine(derivedClass._derivedField);
            Console.ReadKey();
        }
    }
}
