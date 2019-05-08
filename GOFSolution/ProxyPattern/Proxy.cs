using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Proxy : ProxySurface
    {
        private ProxySurface persuitor;
        public Proxy(string name, SchoolGirl girl)
        {
            persuitor = new Pursuitor("Felix", girl);
            Name = name;
        }

        public string Name { get; set; }

        public void SendFlower()
        {
            persuitor.SendFlower();
        }
    }
}
