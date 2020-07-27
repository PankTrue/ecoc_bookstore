using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ecoc_bookstore
{
    [XmlType(TypeName = "book")]
    public class Book
    {
        [XmlAttribute("category")]
        public string Category { get; set; }

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        
        [XmlElement("author")]
        public string[] Author { get; set; }
        
        [XmlElement(ElementName = "year")]
        public int Year { get; set; }

        [XmlElement(ElementName = "price")]
        public double Price { get; set; }
    }

}