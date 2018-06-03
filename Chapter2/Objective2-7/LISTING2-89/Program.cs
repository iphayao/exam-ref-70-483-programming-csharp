using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LISTING2_89
{
    /// <summary>
    /// LISTING 2-89 Using a StringWriter as the output for an XmlWriter
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var stringWriter = new StringWriter();
            using(XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }

            string xml = stringWriter.ToString();
            Console.WriteLine(xml);
        }
    }
}
