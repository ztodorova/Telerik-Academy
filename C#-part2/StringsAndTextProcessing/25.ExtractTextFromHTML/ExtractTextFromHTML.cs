/*
 * Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
Example input:

<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>
 * 
Output:

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace _25.ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        static void Main()
        {
            
            var inputHtml = new StreamReader(@"..\..\Html.txt");
            Console.SetIn(inputHtml);
            string input = Console.ReadLine();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(input);

            XmlNode node = doc.DocumentElement.SelectSingleNode("/html/head/title");
            Console.WriteLine("Title: " + node.InnerText);
            node = doc.DocumentElement.SelectSingleNode("/html/body");
            Console.WriteLine("Body: " + node.InnerText);
        }
    }
}
