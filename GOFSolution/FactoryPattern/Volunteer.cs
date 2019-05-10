using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Volunteer : IGoodThings
    {
        public void DoingGoodthings()
        {
            Console.WriteLine("volunteer do good things");
        }
    }
}
