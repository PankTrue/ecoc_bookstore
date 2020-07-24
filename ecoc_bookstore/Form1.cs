using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecoc_bookstore
{
    public partial class Form1 : Form
    {
        private Bookstore Bookstore{ get; set; }
        public Form1()
        {
            Bookstore = new Bookstore();
            InitializeComponent();
        }

        private void button_openXML_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = ".";
                openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bookstore.LoadFromXml(openFileDialog.FileName);
                    DataGridView_Populate();
                }
            }
        }


        private void DataGridView_Populate()
        {
            this.dataGridView1.Rows.Clear();

            foreach (var v in Bookstore.Books)
            { 
                dataGridView1.Rows.Add(new string [] { v.Title, String.Join(";", v.Author) , v.Category, v.Price.ToString() });
            }
        }


    }
}
