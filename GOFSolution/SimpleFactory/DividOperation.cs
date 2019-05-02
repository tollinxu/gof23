using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    internal class DividOperation: BaseOperation
    {
        public override int GetResult()
        {
            if(OperationNumberB == 0)
            {
                throw new Exception($"could be not divided by 0, OperationNumberB is Zero.");
            }

            return OperationNumberA / OperationNumberB;
        }
    }
}
