using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAndBoolean
{
    internal class Values
    {
        private int _value;

        public Values(int value)
        {
            _value = value;
        }
        public Operations Plus => new Operations(_value, OperationType.Add);
        public Operations Minus => new Operations(_value, OperationType.Subtract);
        public Operations Multiply => new Operations(_value, OperationType.Multiply);
        public Operations DividedBy => new Operations(_value, OperationType.Divide);

        public static implicit operator int(Values v)
        {
            return v._value;
        }

        public int Result => _value;


    }
}
