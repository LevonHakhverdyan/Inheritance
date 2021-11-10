using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_inheritance
{
    sealed class DerivedClass : BaseClass
    {
        public  DerivedClass()
        {
           publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";
        }
        public void Show(string source)
        {
            Console.WriteLine(source + " " + protectedField);
        }
    }
}
