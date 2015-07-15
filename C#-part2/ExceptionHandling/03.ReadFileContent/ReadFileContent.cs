﻿using System;
using System.Collections.Generic;
/*Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
 * */

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.ReadFileContent
{
    class ReadFileContent
    {
        static void Main()
        {
            try
            {
                Console.Write("Please enter file name with full path: ");
                string path = Console.ReadLine();
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid path or file name!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path is too long!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Directory not found!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No access to file!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format!");
            }
        }
    }
}
