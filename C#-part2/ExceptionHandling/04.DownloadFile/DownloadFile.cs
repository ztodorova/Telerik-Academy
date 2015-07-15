/*Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _04.DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            try
            {
                Console.Write("Please enter URL to the file: ");
                string path = Console.ReadLine();
                Console.Write("Please enter file name: ");
                string name = Console.ReadLine();

                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile(path, name);
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Null value detected");
            }
            catch (WebException)
            {
                Console.WriteLine("Url not found");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Not supported");
            }
                catch(Exception)
            {
                Console.WriteLine("File not found!");
            }
            finally
            {
                Console.WriteLine("Program finished!");
            }
        }
    }
}
