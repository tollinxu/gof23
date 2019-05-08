using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Pursuitor : ProxySurface
    {
        public SchoolGirl girl { get; set; }

        public string Name { get; set; }

        public Pursuitor(string name, SchoolGirl schoolGirl)
        {
            girl = schoolGirl;
            Name = name;
        }

        public void SendFlower()
        {
            Console.WriteLine(Name + " send flower to " + girl.Name);
        }
    }
}
