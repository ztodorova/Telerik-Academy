using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
    public static class StringBuilderSubstringExtention
    {

        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            StringBuilder result = new StringBuilder();

            for (int i = index; i < index+length; i++)
            {
                result.Append(builder[i]);
            }
            return result;
        }

    }
}
