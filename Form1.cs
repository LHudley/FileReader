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

namespace FileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string president;

                StreamReader inputFile;
                inputFile = File.OpenText(@"C:\Users\Admin\source\repos\FileReader\bin\Debug\presidents.txt");

                listBox1.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    president = inputFile.ReadLine();
                    listBox1.Items.Add(president);
                }

                inputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
