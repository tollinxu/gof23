using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Resume : ICloneable
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string University { get; set; }

        public Resume(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "this is " + this.Name + $"'s resume. His age is {Age}, and graduated from {University}";
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}
