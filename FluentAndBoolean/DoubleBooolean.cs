using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAndBoolean
{
    internal class DoubleBooolean
    {
        private bool value = true;
        public static bool operator ==(DoubleBooolean cb, bool b)
        {
            return cb.value;
        }

        public static bool operator !=(DoubleBooolean cb, bool b)
        {
            return !cb.value;
        }

        public static bool operator ==(bool b, DoubleBooolean cb)
        {
            return cb.value;
        }

        public static bool operator !=(bool b, DoubleBooolean cb)
        {
            return !cb.value;
        }

        public static implicit operator bool(DoubleBooolean cb)
        {
            return cb.value;
        }
    }
}
