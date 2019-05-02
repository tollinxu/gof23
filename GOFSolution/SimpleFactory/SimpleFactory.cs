using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class SimpleFactory
    {
        public static BaseOperation GetOperation(string mathOperator)
        {
            switch (mathOperator)
            {
                case "+":
                    return new AddOperation();
                case "-":
                    return new SubstractOperation();
                case "/":
                    return new DividOperation();

                default:
                    throw new NotImplementedException($"haven't implement your operator {mathOperator}");
            }
        }
    }
}
