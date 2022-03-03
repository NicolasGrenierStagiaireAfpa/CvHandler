using System.Linq.Dynamic.Core;
using CvHandlerForm.Models;
using System.Data;


namespace CvHandlerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        int indexRow;

        private void button1_Click(object sender, EventArgs e)
        {
            string PathIN = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdata.csv";

            string PathOUT = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdataUTF8.csv";

            FonctionsUtiles.BonFormatCSV(PathIN, PathOUT);

        }
           
        private void button2_Click(object sender, EventArgs e)
        {
            string Path = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdataUTF8.csv";

            FonctionsUtiles.PeuplerLaBDD(Path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FonctionsUtiles.EffacerLaBDD();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //table.Columns.Add("Id", typeof(int));
            //table.Columns.Add("First Name", typeof(string));
            //table.Columns.Add("Last Name", typeof(string));
            //table.Columns.Add("Age", typeof(int));

            //table.Rows.Add(1, "First A", "Last A", 10);
            //table.Rows.Add(2, "First B", "Last B", 20);
            //table.Rows.Add(3, "First C", "Last C", 30);
            //table.Rows.Add(4, "First D", "Last D", 40);
            //table.Rows.Add(5, "First E", "Last E", 50);
            //table.Rows.Add(6, "First F", "Last F", 60);
            //table.Rows.Add(7, "First G", "Last G", 70);
            //table.Rows.Add(8, "First H", "Last H", 80);

            //dataGridView1.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "Nom";
            //Func<Postulant, string> orderByFunc = item => item.Nom;
            //orderByFunc = item => item.Nom;
            
            //DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            //newDataRow.Cells[0].Value = textBox1.Text;
            //newDataRow.Cells[1].Value = textBox2.Text;
            //newDataRow.Cells[2].Value = textBox3.Text;
            //newDataRow.Cells[3].Value = textBox4.Text;
            try
            {
                using(var context = new CVDBContext())
                {

                    dataGridView1.DataSource = context.Postulants.OrderBy(str).ToList();
                       // .OrderBy(x => x.GetType().GetProperty(str).GetValue(x, null)); 

                       
                }

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = e.RowIndex;// get the Row Index
            //DataGridViewRow selectedRow = dataGridView1.Rows[index];
            //textBox1.Text = selectedRow.Cells[0].Value.ToString();
            //textBox2.Text = selectedRow.Cells[1].Value.ToString();
            //textBox3.Text = selectedRow.Cells[2].Value.ToString();
            //textBox4.Text = selectedRow.Cells[3].Value.ToString();
        }
    }
}