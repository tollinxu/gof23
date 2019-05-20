using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    class Builder
    {
        public static void BuildCache<T>(BaseCache<T> cache) where T : class
        {
            cache.LoadEntityFromDb();

            cache.CategoryEntityByHotelId();
        }
    }
}
