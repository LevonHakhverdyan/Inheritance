using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Constructors
{
    class DerivedClass:BaseClass
    {
        public int _derivedField;
        public DerivedClass(int number1 , int number2 )
        {
            _baseNumber = number1;
            _derivedField = number2;

        }
    }
}
