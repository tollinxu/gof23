using System;
using System.Collections.Generic;
using System.Text;

namespace DecorationPattern
{
    public class Person
    {
        public Person()
        {
        }

        private string name;

        public Person(string Name)
        {
            this.name = Name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"make up {name}");
        }
    }
}
