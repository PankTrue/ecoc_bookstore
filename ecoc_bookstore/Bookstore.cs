using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ecoc_bookstore
{
    public class Bookstore
    {
        public List<Book> Books { get; set; }

        static private XmlSerializer formatter = new XmlSerializer(typeof(List<Book>), new XmlRootAttribute("bookstore"));
        static private XmlWriterSettings xmlWriterSettings;
        static private XmlReaderSettings xmlReaderSettings;
        static private XmlSerializerNamespaces dummyNSs;


        public Bookstore()
        {
            xmlWriterSettings = new XmlWriterSettings() { ConformanceLevel = ConformanceLevel.Document,
                                                    OmitXmlDeclaration = false,
                                                    Encoding = Encoding.UTF8,
                                                    Indent = true,
                                                    IndentChars = "    " };

            dummyNSs = new XmlSerializerNamespaces();
            dummyNSs.Add(string.Empty, string.Empty);
        }



        public void LoadFromXml(string filename = "books.xml")
        {
            try
            {
                using (FileStream fileStream = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    using (XmlReader xw = XmlReader.Create(fileStream, xmlReaderSettings))
                    {
                        Books = (List<Book>)formatter.Deserialize(xw);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void SaveToXml(string filename = "books.xml")
        {
            try
            {
                using (FileStream fileStream = new FileStream(filename, FileMode.Create))
                {
                    using (XmlWriter xw = XmlWriter.Create(fileStream, xmlWriterSettings))
                    {
                        formatter.Serialize(xw, Books, dummyNSs);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
