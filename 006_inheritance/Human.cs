using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_inheritance
{
    public class Human:Animal
    {
        public string _name;
        public Human(long id):base(id)
        {

        }
        public void Speak (string speakObject)
        {
            Console.WriteLine($"{_name} with id: {_id} speaks when sees {speakObject}");
        }
    }
}
