using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{

    public class Employee
    {
        public int _id;
        public string _name;
        public string _surname;
        public Address _address;
        public Employee(int id, string name, string surname, Address address)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _address = address;
        }
        public void display()
        {
            Console.WriteLine($"{_id}  {_name}  {_surname}  {_address._city}  {_address._street}  {_address._number}");
        }
    }

}
