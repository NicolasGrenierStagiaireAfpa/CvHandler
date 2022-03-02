using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvHandlerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string PathIN = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdata.csv";

            string PathOUT = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdataUTF8.csv";

            FonctionsUtiles.BonFormatCSV(PathIN, PathOUT);

        }
           
        private void button2_Click(object sender, EventArgs e)
        {
            string Path = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdata.csv";

            FonctionsUtiles.PeuplerLaBDD(Path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FonctionsUtiles.EffacerLaBDD();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Age", typeof(int));

            table.Rows.Add(1, "First A", "Last A", 10);
            table.Rows.Add(2, "First B", "Last B", 20);
            table.Rows.Add(3, "First C", "Last C", 30);
            table.Rows.Add(4, "First D", "Last D", 40);
            table.Rows.Add(5, "First E", "Last E", 50);
            table.Rows.Add(6, "First F", "Last F", 60);
            table.Rows.Add(7, "First G", "Last G", 70);
            table.Rows.Add(8, "First H", "Last H", 80);

            dataGridView1.DataSource = table;



        }
    }
}