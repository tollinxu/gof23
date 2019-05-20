using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern
{
    class AccountCache : BaseCache<Account>
    {
        public override IDictionary<string, IEnumerable<Account>> CategoryEntityByHotelId()
        {
            Console.WriteLine("category account");
            return new Dictionary<string, IEnumerable<Account>>();
        }

        public override IEnumerable<Account> LoadEntityFromDb()
        {
            Console.WriteLine("loading account ...");

            return new List<Account>();
        }
    }
}
