using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _64BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
        public ulong Value { get; set; }

        public BitArray64(ulong number)
        {
            this.Value = number;
        }

        public override bool Equals(object val)
        {
            return this.Value.Equals((val as BitArray64).Value);
        }

        public static bool operator ==(BitArray64 val1, BitArray64 val2)
        {
            if(val1.Value==val2.Value)
            {return true;}
            else
            {
                return false;
            }
        }

        public static bool operator !=(BitArray64 val1, BitArray64 val2)
        {
            if(val1.Value!=val2.Value)
            {return true;}
            else
            {
                return false;
            }
        }



        public override int GetHashCode()
        {

            return this.Value.GetHashCode();
        }

        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                return ((int)(this.Value >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid position.");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }

                if (((int)(this.Value >> pos) & 1) != value)
                {
                    this.Value ^= (1ul << pos);
                }
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return this[pos];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


    }
}
