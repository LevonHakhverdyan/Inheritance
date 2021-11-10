using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    public class Address
    {
        public string _city, _street;
        public int _number;
        public Address(string city, string street,int number)
        {
            _city = city;
            _street = street;
            _number = number;
        }
    }
}
