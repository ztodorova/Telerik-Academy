using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _64BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
        public ulong Value64 { get; private set; }

        public int GetEnumerator()
        {
            return 1;
        }

    }
}
