using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ecoc_bookstore
{
    public class Bookstore
    {
        public List<Book> Books { get; set; }


        public Bookstore(){ }



        public void LoadFromXml(string filename = "books.xml")
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    Books = (List<Book>)formatter.Deserialize(fs);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void SaveToXml(string filename = "books.xml")
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, Books);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
