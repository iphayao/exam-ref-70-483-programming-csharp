using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-90 Using a StringReader as the input for an XmlReader
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string xml = "PATH TO XML FILE";
            var stringReader = new StringReader(xml);
            using(XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(), new CultureInfo("en-US"));
                Console.WriteLine(price);
            }
        }
    }
}
