/*
 * Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Example:

URL	Information                                         Information:
http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
                                                        [server] = telerikacademy.com 
                                                        [resource] = /Courses/Courses/Details/212
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter URL address: ");
            string address = Console.ReadLine();
            int indexSlashes = address.IndexOf("//");
            string protocol = address.Substring(0, indexSlashes-1);
            Console.WriteLine("[protocol] = {0}", protocol);
            int indexSlash = address.IndexOf("/", indexSlashes+2);
            string server = address.Substring(indexSlashes+2, indexSlash-(indexSlashes+2) );
           Console.WriteLine("[server] = {0}", server);
           int indexSlashLast = address.IndexOf("/", indexSlash + 1);
           string resource = address.Substring(indexSlashLast);
           Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
