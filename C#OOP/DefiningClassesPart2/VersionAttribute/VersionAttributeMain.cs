using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [Version("2.11")]
    class VersionAttributeMain
    {
        static void Main()
        {
            Type type = typeof(VersionAttributeMain);
            object[] attribute = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attribute)
            {
                Console.WriteLine("Version = {0}", item.Version);
            }
        }
    }
}
