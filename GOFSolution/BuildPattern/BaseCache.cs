using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    public abstract class BaseCache<T> where T : class
    {
        public abstract IEnumerable<T> LoadEntityFromDb();

        public abstract IDictionary<string, IEnumerable<T>> CategoryEntityByHotelId();
    }
}
