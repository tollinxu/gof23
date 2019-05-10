using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class UndergraduateFactory : IFactory
    {
        public IGoodThings CreateGoodThings()
        {
            return new Undergraduate();
        }
    }
}
