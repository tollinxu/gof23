using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    class PriceDetailCache : BaseCache<PriceDetail>
    {
        public override IDictionary<string, IEnumerable<PriceDetail>> CategoryEntityByHotelId()
        {
            Console.WriteLine("category PriceDetail");
            return new Dictionary<string, IEnumerable<PriceDetail>>();
        }

        public override IEnumerable<PriceDetail> LoadEntityFromDb()
        {
            Console.WriteLine("loading PriceDetail ...");

            return new List<PriceDetail>();
        }
    }
}
