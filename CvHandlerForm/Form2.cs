using CvHandlerForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvHandlerForm
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonInsererPostulant_Click(object sender, EventArgs e) // Insérer les informations du postulant
        {
            var listString = new List<string>();
            var listInteger = new List<int>();
            textBoxId.Text = "0";

            using (var context = new CVDBContext())
            {
                listString.AddRange(context.Postulants.Select(x => x.Id).ToList());
            }

            foreach (var item in listString)
            {
                listInteger.Add(int.Parse(item));
            }

            int maxId = listInteger.Max();
            int a;

            if (!int.TryParse(textBoxId.Text, out a))
            {
                textBoxId.Text = "0";
            }

            int idChoice = int.Parse(textBoxId.Text);

            if (idChoice <= maxId)
            {
                textBoxId.Text = (maxId + 1).ToString();
            }

            //MessageBox.Show(textBoxId.Text.ToString());

            var cultureInfo = new CultureInfo("de-DE");
            var postulant = new Postulant();
            using (var context = new CVDBContext())
            {
                postulant.Id = textBoxId.Text;
                postulant.Nom = textBoxNom.Text;
                postulant.Prenom = textBoxPrenom.Text;
                postulant.Age = textBoxAge.Text;
                postulant.DateDeNaissance = textBoxDateDeNaissance.Text;
                postulant.Adresse = textBoxAdresse.Text;
                postulant.AdresseComplement = textBoxComplementAdresse.Text;
                postulant.CodePostal = textBoxCodePostal.Text;
                postulant.Ville = textBoxVille.Text;
                postulant.TelPortable = textBoxTelPortable.Text;
                postulant.TelFixe = textBoxTelFixe.Text;
                postulant.Email = textBoxEmail.Text;
                postulant.ProfilePro = textBoxProfilePro.Text;
                postulant.Competence1 = textBoxCompetence1.Text;
                postulant.Competence2 = textBoxCompetence2.Text;
                postulant.Competence3 = textBoxCompetence3.Text;
                postulant.Competence4 = textBoxCompetence4.Text;
                postulant.Competence5 = textBoxCompetence5.Text;
                postulant.Competence6 = textBoxCompetence6.Text;
                postulant.Competence7 = textBoxCompetence7.Text;
                postulant.Competence8 = textBoxCompetence8.Text;
                postulant.Competence9 = textBoxCompetence9.Text;
                postulant.Competence10 = textBoxCompetence10.Text;
                postulant.SiteWeb = textBoxSiteWeb.Text;
                postulant.ProfileLinkedin = textBoxProfileLinkedin.Text;
                postulant.ProfileViadeo = textBoxProfileViadeo.Text;
                postulant.ProfileFacebook = textBoxProfileFacebook.Text;

                try
                {
                    var BirthDay = postulant.DateDeNaissance;
                    var dateTime = DateTime.Parse(BirthDay, cultureInfo);
                    var age = DateTime.Now.Year - dateTime.Year - 1;
                    postulant.Age = age.ToString();
                }
                catch //(Exception ex)                  
                {
                    ;
                }

                context.Postulants.Add(postulant);
                context.SaveChanges();
            }


            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButonUpdateInsert_CheckedChanged(object sender, EventArgs e) // Choisir entre Insertion et Update
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }





    }
}
