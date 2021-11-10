using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Constructors
{
    class DerivedClass : BaseClass
    {
        public int _derivedField;
        public DerivedClass(int number)
        {

        }
        //public DerivedClass(int number1, int number2) : this(number1)
        //{
        //    _derivedField = number2;
        //}
        public DerivedClass(int number1, int number2) : base(number1)
        {
            _derivedField = number2;
        }
    }
}
