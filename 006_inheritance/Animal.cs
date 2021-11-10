using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_inheritance
{
    public class Animal
    {
        protected long _id;
        public Animal(long id)
        {
            _id = id;

        }
        public void Eat (string eatObject)
        {
            Console.WriteLine($"the animal with id {_id} eats {eatObject}");
        }
        public override string ToString()
        {
            return "";
        }
    }
}
