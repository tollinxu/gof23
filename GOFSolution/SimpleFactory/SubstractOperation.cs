using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    internal class SubstractOperation : BaseOperation
    {
        public override int GetResult()
        {
            return OperationNumberA - OperationNumberB;
        }
    }
}
