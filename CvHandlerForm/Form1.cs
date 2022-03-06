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


        public Form1() => InitializeComponent();

        DataTable table = new DataTable();

        private void Form1_Load(object sender, EventArgs e) // Charger le formulaire
        {
            dataGridView1.DataSource = FonctionsUtiles.BddToDataTable();

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(FonctionsUtiles.ArrayOfIdFromDbb());

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(FonctionsUtiles.ArrayOfCompetenceFromDbb());
        }

        private void button4_Click(object sender, EventArgs e) // Voir tous les postulants
        {
            dataGridView1.DataSource = FonctionsUtiles.BddToDataTable();

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(FonctionsUtiles.ArrayOfIdFromDbb());

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(FonctionsUtiles.ArrayOfCompetenceFromDbb());

        }

        private void button2_Click(object sender, EventArgs e) // Réinitialiser la BDD
        {

            FonctionsUtiles.EffacerLaBDD();

            var relatifPath1 = Directory.GetCurrentDirectory();

            var relatifPath2 = Directory.GetParent(relatifPath1).FullName;

            var relatifPath3 = Directory.GetParent(relatifPath2).FullName;

            var relatifPath4 = Directory.GetParent(relatifPath3).FullName;

            var relatifPath5 = relatifPath4 + "\\CSV\\hrdata.csv";

            //MessageBox.Show(relatifPath4);

            string PathIN = @"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\CSV\hrdata.csv";

            string PathOUT = @"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\CSV\hrdataUTF8.csv";

            FonctionsUtiles.BonFormatCSV(PathIN, PathOUT);

            FonctionsUtiles.PeuplerLaBDD(PathOUT);


            dataGridView1.DataSource = FonctionsUtiles.BddToDataTable();

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(FonctionsUtiles.ArrayOfIdFromDbb());

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(FonctionsUtiles.ArrayOfCompetenceFromDbb());


        }

        private void btnEffacerLigne_Click(object sender, EventArgs e) // Effacer un postulant de la BDD
        {
            if (comboBox1.SelectedItem != null)
            {
                var idChoice = comboBox1.SelectedItem.ToString();
                using (var context = new CVDBContext())
                {
                    var postulant = context.Postulants.SingleOrDefault(a => a.Id == idChoice);
                    if (postulant != null)
                    {
                        context.Remove(postulant);
                        context.SaveChanges();
                    }
                }
            }

            dataGridView1.DataSource = FonctionsUtiles.BddToDataTable();

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(FonctionsUtiles.ArrayOfIdFromDbb());

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(FonctionsUtiles.ArrayOfCompetenceFromDbb());


        }

        private void button2_Click_1(object sender, EventArgs e) // Voir les postulants qui ont cette compétence
        {
            if (comboBox2.SelectedItem != null)
            {
                var competenceChoice = comboBox2.SelectedItem.ToString();

                using (var context = new CVDBContext())
                {
                    List<Postulant> postulants = context.Postulants.Where(a => a.Competence1 == competenceChoice
                                                                           || a.Competence2 == competenceChoice
                                                                           || a.Competence3 == competenceChoice
                                                                           || a.Competence4 == competenceChoice
                                                                           || a.Competence5 == competenceChoice
                                                                           || a.Competence6 == competenceChoice
                                                                           || a.Competence7 == competenceChoice
                                                                           || a.Competence8 == competenceChoice
                                                                           || a.Competence9 == competenceChoice
                                                                           || a.Competence10 == competenceChoice
                                                                           ).ToList();
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
                }
            }
        }

        private void btnInsererLigne_Click(object sender, EventArgs e) // Idérer ou editer les informations d'un postulant
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnExportGrid_Click(object sender, EventArgs e) // Exporter la vue dans Excell
        {
            int nbrLignes = dataGridView1.Rows.Count;
            int nbrColonnes = dataGridView1.Columns.Count;
            var preCSV = new List<string>();
            var file = @"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\CSV\hrdataFromGrid.csv";

            for (int i = 0; i < nbrLignes - 1; i++)
            {
                var strb = new StringBuilder();
                string str;

                for (int j = 0; j < nbrColonnes - 2; j++)
                {
                    var props = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    var propsConvert = FonctionsUtiles.ConvertSring(Encoding.GetEncoding("UTF-16"), Encoding.GetEncoding("ISO-8859-1"), props);
                    strb.Append(propsConvert);
                    strb.Append(";");
                }

                var propsFinal = dataGridView1.Rows[i].Cells[nbrColonnes - 1].Value.ToString();
                var propsConvertFinal = FonctionsUtiles.ConvertSring(Encoding.GetEncoding("UTF-16"), Encoding.GetEncoding("ISO-8859-1"), propsFinal);
                strb.Append(propsConvertFinal);
                str = strb.ToString();
                preCSV.Add(str);
            }

            using (var stream = File.CreateText(file))
            {
                foreach (string item in preCSV)
                {
                    var itemFinal = FonctionsUtiles.ConvertSring(Encoding.GetEncoding("UTF-16"), Encoding.GetEncoding("ISO-8859-1"), item);
                    stream.WriteLine(itemFinal);
                }
            }

            string PathIN2 = @"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\CSV\hrdataFromGrid.csv";

            string PathOUT2 = @"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\CSV\hrdataFromGridWin.csv";

            FonctionsUtiles.BonFormatCSV(PathIN2, PathOUT2);

            using (var process = new Process())
            {
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = @"C:\Program Files\Microsoft Office\Office16\EXCEL.EXE";
                process.StartInfo.Arguments = PathIN2;
                process.Start();

            }

            // C:\Program Files\Mozilla Firefox



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

        private void btnCvPDF_Click(object sender, EventArgs e) // Lire les CV PDF
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\PDF";
            openFileDialog1.ShowDialog();

            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            //if (result == DialogResult.OK) // Test result.
            //{
            //    string file = openFileDialog1.FileName;
            //    openFileDialog1.InitialDirectory = @"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\PDF";

            //    try
            //    {
            //        string text = File.ReadAllText(file);

            //    }
            //    catch (IOException)
            //    {
            //    }
            //    MessageBox.Show(file.ToString());
            //}

            //using (var process = new Process())
            //{
            //C:\Program Files(x86)\Microsoft Office\OFFICE11\WORDVIEW.exe

            //C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\CSV

            //string PathIN2 = @"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\CSV\hrdataFromGrid.csv";

            //process.StartInfo.UseShellExecute = false;
            //process.StartInfo.FileName = @"C:\Program Files(x86)\Microsoft Office\OFFICE11\WORDVIEW.exe";
            //process.StartInfo.Arguments = PathIN2;
            //process.Start();

            //var choixId = comboBox1.SelectedItem as string;
            //MessageBox.Show(choixId);
            //@"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\PDF\2"

            //process.StartInfo.UseShellExecute = false;
            //process.StartInfo.FileName = @"C:\Program Files(x86)\Microsoft Office\OFFICE11\WORDVIEW.exe";
            //process.StartInfo.Arguments = @"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\PDF\2";
            //process.Start();

            //C:\Program Files\Tracker Software\PDF Viewer\PDFXCview.exe


            //process.StartInfo.UseShellExecute = false;
            //process.StartInfo.FileName = @"C:\Program Files\Tracker Software\PDF Viewer\PDFXCview.exe";
            //process.StartInfo.Arguments = @"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\PDF\2";
            //process.Start();

            //};

        }

        private void btnCvWORD_Click(object sender, EventArgs e)  // Lire les CV WORD
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.InitialDirectory = @"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\WORD";
            openFileDialog2.ShowDialog();

        }



 //"Datasource=C:\\Users\\USER\\Documents\\CsharpProjects\\CvHandler\\CvHandlerForm\\DB\\CvHandlerDb.sqlite;"
        //C:\\Users\\GRENIER\\source\\repos\\CvHandler\\CvHandlerForm\\DB\\CvHandlerDb.sqlite;
        // string Imgpath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "\\File\\img.png";
        //string = Directory.GetCurrentDirectory().toString();

        //string Path = "Datasource="+Directory.GetParent(Directory.GetCurrentDirectory()).FullName+"\\File\\img.png";
        //string relativePathToImage = Path.Combine(Directory.GetCurrentDirectory(), "File", "img.png");







        private void button1_Click(object sender, EventArgs e) 
        {
        }

        private void button3_Click(object sender, EventArgs e) 
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {
        }

        private void btnEditerLigne_Click(object sender, EventArgs e)
        {            
            
        }
    }
}