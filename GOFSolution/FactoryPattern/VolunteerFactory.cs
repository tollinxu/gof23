using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class VolunteerFactory : IFactory
    {
        public IGoodThings CreateGoodThings()
        {
            return new Volunteer();
        }
    }
}
