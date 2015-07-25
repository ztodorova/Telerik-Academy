using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
   public class InvalidRangeException<T> : ApplicationException
    {
       private T start;
       private T end;

       public InvalidRangeException(T start, T end)
       {
           this.start = start;
           this.end = end;
       }

       public InvalidRangeException(string msg, T start, T end)
           : base(msg)
       {
           this.start = start;
           this.end = end;
       }

    }
}
