using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    interface IFactory
    {
        IGoodThings CreateGoodThings();
    }
}
