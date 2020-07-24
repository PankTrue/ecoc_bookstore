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
        private string Filename;

        public List<Book> Books { get; set; }


        public Bookstore(string filename = "books.xml")
        {
            Filename = filename;
        }



        public void LoadFromXml()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));
            try
            {
                using (FileStream fs = new FileStream(Filename, FileMode.OpenOrCreate))
                {
                    Books = (List<Book>)formatter.Deserialize(fs);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void SaveToXml()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Book>));
            try
            {
                using (FileStream fs = new FileStream(Filename, FileMode.OpenOrCreate))
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
