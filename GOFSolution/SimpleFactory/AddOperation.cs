using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    internal class AddOperation : BaseOperation
    {
        public override int GetResult()
        {
            return OperationNumberA + OperationNumberB;
        }
    }
}
