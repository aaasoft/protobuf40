using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Google.Protobuf.Compatibility
{
    internal static class CharExtensions
    {
        internal static bool IsHighSurrogate(this char target)
        {
            return target >= '\uD800' && target<= '\uDBFF';
        }
        internal static bool IsLowSurrogate(this char target)
        {
            return target >= '\uDC00' && target <= '\uDFFF';
        }
    }
}
