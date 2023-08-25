using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAndBoolean
{
    internal class FluentCalculator
    {
        /// <summary>
        /// get { return new Values(x) } 
        /// ->
        /// => new Values (x)
        /// </summary>
        public Values Zero => new Values(0); 
        public Values One => new Values(1);
        public Values Two => new Values(2);
        public Values Three => new Values(3);
        public Values Four => new Values(4);
        public Values Five => new Values(5);
        public Values Six => new Values(6);
        public Values Seven => new Values(7);
        public Values Eight => new Values(8);
        public Values Nine => new Values(9);
        public Values Ten => new Values(10);
    }
}
