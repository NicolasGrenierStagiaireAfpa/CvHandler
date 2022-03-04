using System.Linq.Dynamic.Core;
using CvHandlerForm.Models;
using System.Data;
using System.Text;
using Microsoft.Extensions.Primitives;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

//using Excel = Microsoft.Office.Interop.Excel;

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
            //string PathIN = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdata.csv";

            //string PathOUT = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdataUTF8.csv";

            //FonctionsUtiles.BonFormatCSV(PathIN, PathOUT);

        }
           
        private void button2_Click(object sender, EventArgs e) // Peupler la BDD
        {
            string PathIN = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdata.csv";

            string PathOUT = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdataUTF8.csv";

            FonctionsUtiles.BonFormatCSV(PathIN, PathOUT);

            FonctionsUtiles.PeuplerLaBDD(PathOUT);
        }

        private void button3_Click(object sender, EventArgs e) // Effacer la BDD
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

        private void button4_Click(object sender, EventArgs e) // Voir les postulants
        {
            string str = "Nom";


            using(var context = new CVDBContext())
            {
                List<Postulant> postulants = context.Postulants.OrderBy(str).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("Nom");
                dt.Columns.Add("Prenom");
                dt.Columns.Add("Age");
                dt.Columns.Add("DateDeNaissance");
                dt.Columns.Add("Adresse");
                dt.Columns.Add("AdresseComplement");
                dt.Columns.Add("CodePostal");
                dt.Columns.Add("Ville");
                dt.Columns.Add("TelPortable");
                dt.Columns.Add("TelFixe");
                dt.Columns.Add("Email");
                dt.Columns.Add("ProfilePro");
                dt.Columns.Add("Competence1");
                dt.Columns.Add("Competence2");
                dt.Columns.Add("Competence3");
                dt.Columns.Add("Competence4");
                dt.Columns.Add("Competence5");
                dt.Columns.Add("Competence6");
                dt.Columns.Add("Competence7");
                dt.Columns.Add("Competence8");
                dt.Columns.Add("Competence9");
                dt.Columns.Add("Competence10");
                dt.Columns.Add("SiteWeb");
                dt.Columns.Add("ProfileLinkedin");
                dt.Columns.Add("ProfileViadeo");
                dt.Columns.Add("ProfileFacebook");
                foreach (Postulant postulant in postulants)
                {
                    dt.Rows.Add(postulant.Id,
                        postulant.Nom,
                        postulant.Prenom,
                        postulant.Age,
                        postulant.DateDeNaissance,
                        postulant.Adresse,
                        postulant.AdresseComplement,
                        postulant.CodePostal,
                        postulant.Ville,
                        postulant.TelPortable,
                        postulant.TelFixe,
                        postulant.Email,
                        postulant.ProfilePro,
                        postulant.Competence1,
                        postulant.Competence2,
                        postulant.Competence3,
                        postulant.Competence4,
                        postulant.Competence5,
                        postulant.Competence6,
                        postulant.Competence7,
                        postulant.Competence8,
                        postulant.Competence9,
                        postulant.Competence10,
                        postulant.SiteWeb,
                        postulant.ProfileLinkedin,
                        postulant.ProfileViadeo,
                        postulant.ProfileFacebook
                        );
                }
                dataGridView1.DataSource = dt;  









                //dataGridView1.DataSource = context.Postulants.OrderBy(str).ToList();


                //     .OrderBy(x => x.GetType().GetProperty(str).GetValue(x, null));
                //foreach (DataGridViewColumn column in dataGridView1.Columns)
                //{

                //    column.SortMode = DataGridViewColumnSortMode.Programmatic;
                //}

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void btnExportGrid_Click(object sender, EventArgs e) // Exporter la vue dans Excell
        {
            int nbrLignes = dataGridView1.Rows.Count;
            int nbrColonnes = dataGridView1.Columns.Count;
            var preCSV = new List<string>();
            var file = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdataFromGrid.csv";

            for (int i = 0; i < nbrLignes - 1; i++)
            {
                var strb = new StringBuilder();
                string str;

                for (int j = 0; j < nbrColonnes - 2; j++)
                {
                    var props = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    var propsConvert = FonctionsUtiles.ConvertSring(Encoding.GetEncoding("UTF-16"), Encoding.GetEncoding("ISO-8859-1"),props);
                    strb.Append(propsConvert);
                    strb.Append(";");
                }
                
                var propsFinal= dataGridView1.Rows[i].Cells[nbrColonnes - 1].Value.ToString();
                var propsConvertFinal = FonctionsUtiles.ConvertSring(Encoding.GetEncoding("UTF-16"), Encoding.GetEncoding("ISO-8859-1"), propsFinal);
                strb.Append(propsConvertFinal);
                str = strb.ToString();
                preCSV.Add(str);
            }

            using (var stream = File.CreateText(file))
            {
                foreach (string item in preCSV)
                {
                    //MessageBox.Show(item);
                    var itemFinal = FonctionsUtiles.ConvertSring(Encoding.GetEncoding("UTF-16"), Encoding.GetEncoding("ISO-8859-1"), item);
                    stream.WriteLine(itemFinal);
                }
            }

            string PathIN2 = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdataFromGrid.csv";

            string PathOUT2 = @"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdataFromGridWin.csv";

            FonctionsUtiles.BonFormatCSV(PathIN2, PathOUT2);






            using (var process = new Process())
            {
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = @"C:\Program Files\Microsoft Office\Office16\EXCEL.EXE";
                process.StartInfo.Arguments = PathIN2;
                process.Start();

            } ;


            //using (StreamReader sr = new StreamReader(@"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdataFromGrid.csv"))
            //{
            //    MessageBox.Show(sr.CurrentEncoding);
            //};

            //using (StreamReader sr = new StreamReader(@"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdataFromGrid.csv")
            //{
            //    MessageBox.Show(sr.CurrentEncoding);
            //};
            //using (StreamReader sr = new StreamReader(@"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdataFromGrid.csv")
            //{
            //     MessageBox.Show(sr.CurrentEncoding);
            //};
            //using (StreamReader sr = new StreamReader(@"C:\Users\USER\Documents\CsharpProjects\CvHandler\CvHandlerForm\CSV\hrdataFromGrid.csv")
            //{
            //    MessageBox.Show(sr.CurrentEncoding);
            //}:





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new CVDBContext())
            {
                List<Postulant> usepurposes = context.Postulants.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Nom");
                foreach (Postulant postulant in usepurposes)
                {
                    dt.Rows.Add(postulant.Nom);
                }
                comboBox1.ValueMember = dt.Columns[0].ColumnName; 
                comboBox1.DisplayMember = dt.Columns[0].ColumnName;
                comboBox1.DataSource = dt;  


               
                
                
                
                
                //comboBox1.DataSource = (from l in context.Postulants
                //                        select l.Id)
                //                        .ToList();


                //comboBox1.DataSource= context.Postulants.ToList();
                //comboBox1.ValueMember = "Nom";
                //comboBox1.DisplayMember = "Nom";
            }


            //dataGridView1.DataSource = context.Postulants.OrderBy(str).ToList()
        }
    }
}