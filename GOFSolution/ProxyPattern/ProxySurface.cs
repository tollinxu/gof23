using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    interface ProxySurface
    {
        string Name { get; set; }
        void SendFlower();
    }
}
