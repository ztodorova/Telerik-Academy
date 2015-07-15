//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            string text = @"My email is ""zaioBayo@abv.bg"". My friend's email is ""mechoPuh@gmail.com"".";
            Console.WriteLine(text);
            Console.WriteLine("The emails are:");
            Console.WriteLine(String.Join("\n", ExtractEmail(text)));
        }

        static List<string> ExtractEmail(string text)
        {
            var emails = new List<string>();
            string[] email = text.Split(new char[] { '"', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in email)
            {
                if (word.Contains("@"))
                {
                    emails.Add(word);
                }
            }
            return emails;
        }
    }
}
