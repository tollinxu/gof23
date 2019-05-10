using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Undergraduate : IGoodThings
    {
        public void DoingGoodthings()
        {
            Console.WriteLine("undergraduate student do good things");
        }
    }
}
