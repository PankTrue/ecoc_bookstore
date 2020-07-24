﻿using System;
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

        private void DataGridView_Populate()
        {
            this.dataGridView1.Rows.Clear();

            foreach (var v in Bookstore.Books)
            {
                dataGridView1.Rows.Add(new string[] { v.Title, String.Join(";", v.Author), v.Category, v.Price.ToString() });
            }
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

        private void button_saveXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bookstore.SaveToXml(saveFileDialog1.FileName);
            }
        }

        private void button_reportHTML_Click(object sender, EventArgs e)
        {

        }

        private void button_deleteEntry_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void button_addEntry_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }
    }
}
