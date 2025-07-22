using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models
{
    internal class Person
    {
        public Person() { }

        public Person(string name, string sobrenome)
        {
            Name = name;
            Sobrenome = sobrenome;
        }

        public string Name { get; set; }
        public string Sobrenome { get; set; }
        public override string ToString()
        {
            return $"{Name} {Sobrenome}".ToUpper();
        }

    }
}
