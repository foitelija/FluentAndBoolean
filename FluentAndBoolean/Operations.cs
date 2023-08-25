using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAndBoolean
{
    internal class Operations
    {
        private int currentValue;
        private OperationType _operationType;

        public Operations(int value, OperationType operationType)
        {
            currentValue = value;
            _operationType = operationType;
        }
        private int ApplyOperation(int a, int b)
        {
            switch (_operationType)
            {
                case OperationType.Add:
                    return a + b;
                case OperationType.Subtract:
                    return a - b;
                case OperationType.Multiply:
                    return a * b;
                case OperationType.Divide:
                    if (b == 0)
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    return a / b;
                default:
                    throw new InvalidOperationException("Unsupported operation.");
            }
        }

        public Values Zero => new Values(ApplyOperation(currentValue, 0));
        public Values One => new Values(ApplyOperation(currentValue, 1));
        public Values Two => new Values(ApplyOperation(currentValue, 2));
        public Values Three => new Values(ApplyOperation(currentValue, 3));
        public Values Four => new Values(ApplyOperation(currentValue, 4));
        public Values Five => new Values(ApplyOperation(currentValue, 5));
        public Values Six => new Values(ApplyOperation(currentValue, 6));
        public Values Seven => new Values(ApplyOperation(currentValue, 7));
        public Values Eight => new Values(ApplyOperation(currentValue, 8));
        public Values Nine => new Values(ApplyOperation(currentValue, 9));
        public Values Ten => new Values(ApplyOperation(currentValue, 10));

        public int Result => currentValue;
    }
}
