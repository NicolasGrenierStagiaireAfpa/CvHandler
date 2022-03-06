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

            string str = "Nom";

            using (var context = new CVDBContext())
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

                //System.Object[] ItemObject = new System.Object[10];
                //for (int i = 0; i <= 9; i++)
                //{
                //    ItemObject[i] = "Item" + i;
                //}
                //comboBox1.Items.AddRange(ItemObject);

                //int nbrLignes = dataGridView1.Rows.Count;
                //System.Object[] ItemObject = new System.Object[nbrLignes];

                //for (int i = 0; i <= nbrLignes - 1; i++)
                //{
                //    ItemObject[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                //}
                //comboBox1.Items.AddRange(ItemObject);

            }
            List<string> list = new List<string>();
            using (var contxt = new CVDBContext())
            {
                list.AddRange(contxt.Postulants.Select(x => x.Competence1).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence2).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence3).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence4).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence5).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence6).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence7).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence8).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence9).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence10).ToList());
            }

            HashSet<string> hashWithoutDuplicates = new HashSet<string>(list);
            List<string> listWithoutDuplicates = hashWithoutDuplicates.ToList();
            listWithoutDuplicates.Remove("NULL");
            listWithoutDuplicates.Sort();

            comboBox1.Items.Clear();
            int nbrLignes = dataGridView1.Rows.Count - 1;
            System.Object[] ItemObject = new System.Object[nbrLignes];

            for (int i = 0; i <= nbrLignes - 1; i++)
            {
                ItemObject[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
            }

            comboBox1.Items.AddRange(ItemObject);

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(listWithoutDuplicates.ToArray());

        }

        DataTable table = new DataTable();

        private void button1_Click(object sender, EventArgs e) 
        {
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
        }

        
        //"Datasource=C:\\Users\\USER\\Documents\\CsharpProjects\\CvHandler\\CvHandlerForm\\DB\\CvHandlerDb.sqlite;"
        //C:\\Users\\GRENIER\\source\\repos\\CvHandler\\CvHandlerForm\\DB\\CvHandlerDb.sqlite;
        // string Imgpath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "\\File\\img.png";
        //string = Directory.GetCurrentDirectory().toString();

        //string Path = "Datasource="+Directory.GetParent(Directory.GetCurrentDirectory()).FullName+"\\File\\img.png";
        //string relativePathToImage = Path.Combine(Directory.GetCurrentDirectory(), "File", "img.png");

        private void button3_Click(object sender, EventArgs e) // Effacer la BDD
        {
            //FonctionsUtiles.EffacerLaBDD();

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
                    //dt2.Rows.Add(postulant.Competence1);
                    //dt2.Rows.Add(postulant.Competence2);
                    //dt2.Rows.Add(postulant.Competence3);
                    //dt2.Rows.Add(postulant.Competence4);
                }
                dataGridView1.DataSource = dt;

                //dataGridView1.DataSource = context.Postulants.OrderBy(str).ToList();


                //     .OrderBy(x => x.GetType().GetProperty(str).GetValue(x, null));
                //foreach (DataGridViewColumn column in dataGridView1.Columns)
                //{

                //    column.SortMode = DataGridViewColumnSortMode.Programmatic;
                //}

                //System.Object[] ItemObject = new System.Object[10];
                //for (int i = 0; i <= 9; i++)
                //{
                //    ItemObject[i] = "Item" + i;
                //}
                //comboBox1.Items.AddRange(ItemObject);

                //int nbrLignes = dataGridView1.Rows.Count;
                //System.Object[] ItemObject = new System.Object[nbrLignes];

                //for (int i = 0; i <= nbrLignes - 1; i++)
                //{
                //    ItemObject[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                //}
                //comboBox1.Items.AddRange(ItemObject);

            }
            List<string> list = new List<string>();
            using (var contxt = new CVDBContext())
            {               
                list.AddRange(contxt.Postulants.Select(x => x.Competence1).ToList()); 
                list.AddRange(contxt.Postulants.Select(x => x.Competence2).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence3).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence4).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence5).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence6).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence7).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence8).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence9).ToList());
                list.AddRange(contxt.Postulants.Select(x => x.Competence10).ToList());
            }

            HashSet<string> hashWithoutDuplicates = new HashSet<string>(list);
            List<string> listWithoutDuplicates = hashWithoutDuplicates.ToList();
            listWithoutDuplicates.Remove("NULL");
            listWithoutDuplicates.Sort();

            comboBox1.Items.Clear();
            int nbrLignes = dataGridView1.Rows.Count-1;
            System.Object[] ItemObject = new System.Object[nbrLignes];

                for (int i = 0; i <= nbrLignes-1; i++)
                {
                    ItemObject[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                }

            comboBox1.Items.AddRange(ItemObject);

            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(listWithoutDuplicates.ToArray());
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Liste des Id des postulants
        {
            //using (var context = new CVDBContext())
            //{


                //System.Object[] ItemObject = new System.Object[10];
                //for (int i = 0; i <= 9; i++)
                //{
                //    ItemObject[i] = "Item" + i;
                //}
                //comboBox1.Items.AddRange(ItemObject);


                //this.comboBox1.Items.AddRange(new object[] {"Item 1",
                //        "Item 2",
                //        "Item 3",
                //        "Item 4",
                //        "Item 5"});


                //List<Postulant> usepurposes = context.Postulants.ToList();
                //DataTable dt = new DataTable();
                //dt.Columns.Add("Nom");
                //foreach (Postulant postulant in usepurposes)
                //{
                //    dt.Rows.Add(postulant.Nom);
                //}
                //comboBox1.ValueMember = dt.Columns[0].ColumnName; 
                //comboBox1.DisplayMember = dt.Columns[0].ColumnName;
                //comboBox1.DataSource = dt;  







                //comboBox1.DataSource = (from l in context.Postulants
                //                        select l.Id)
                //                        .ToList();


                //comboBox1.DataSource= context.Postulants.ToList();
                //comboBox1.ValueMember = "Nom";
                //comboBox1.DisplayMember = "Nom";
            //}


            //dataGridView1.DataSource = context.Postulants.OrderBy(str).ToList()
        }

        private void btnCvPDF_Click(object sender, EventArgs e)
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

        private void btnCvWORD_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.InitialDirectory = @"C:\Users\GRENIER\source\repos\CvHandler\CvHandlerForm\WORD";
            openFileDialog2.ShowDialog();

        }

        private void btnEffacerLigne_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem!= null)
            {
                var idChoice = comboBox1.SelectedItem.ToString();

                using (var context = new CVDBContext())
                {
                    //var query = from p in context.Postulants
                    //            where p.Id == idChoice
                    //            select p;
                    //foreach (var postulants in query)
                    //{
                    //    context.Remove(postulants);
                    //}

                    var postulant = context.Postulants.SingleOrDefault(a => a.Id == idChoice);
                    if (postulant != null)
                    {
                        context.Remove(postulant);
                        context.SaveChanges();

                    }
                }
            }
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

        private void btnInsererLigne_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnEditerLigne_Click(object sender, EventArgs e)
        {            
            
        }
    }
}