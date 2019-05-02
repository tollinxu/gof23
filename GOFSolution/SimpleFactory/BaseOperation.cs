using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    /// <summary>
    /// Operation base class
    /// </summary>
    public abstract class BaseOperation
    {
        /// <summary>
        /// the first operation number 
        /// </summary>
        public int OperationNumberA { get; set; }

        /// <summary>
        /// the second operation number
        /// </summary>
        public int OperationNumberB { get; set; }

        /// <summary>
        /// the operator in expression
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// get result
        /// </summary>
        /// <returns></returns>
       public abstract int GetResult();
    }
}
