using CvHandlerForm.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvHandlerForm
{
    internal class FonctionsUtiles
    {
        static public void BonFormatCSV(string PathIN, string PathOUT)
        {
            string txt = System.IO.File.ReadAllText(PathIN, Encoding.GetEncoding("iso-8859-1"));
            System.IO.File.WriteAllText(PathOUT, txt);
        }

        static public void PeuplerLaBDD(string Path)
        {
            using (var context = new CVDBContext())
            {
                var cultureInfo = new CultureInfo("de-DE");
                const int NBRCOLONNES = 26;
                string[] row = new string[NBRCOLONNES];
                var sr = new StreamReader(Path);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var postulant = new Postulant();
                    row = line.Split(';');
                    postulant.Id = row[0];
                    postulant.Nom = row[1];
                    postulant.Prenom = row[2];
                    postulant.Age = row[3];
                    postulant.DateDeNaissance = row[4];
                    postulant.Adresse = row[5];
                    postulant.AdresseComplement = row[6];
                    postulant.CodePostal = row[7];
                    postulant.Ville = row[8];
                    postulant.TelPortable = row[9];
                    postulant.TelFixe = row[10];
                    postulant.Email = row[11];
                    postulant.ProfilePro = row[12];
                    postulant.Competence1 = row[13];
                    postulant.Competence2 = row[14];
                    postulant.Competence3 = row[15];
                    postulant.Competence4 = row[16];
                    postulant.Competence5 = row[17];
                    postulant.Competence6 = row[18];
                    postulant.Competence7 = row[19];
                    postulant.Competence8 = row[20];
                    postulant.Competence9 = row[21];
                    postulant.Competence10 = row[22];
                    postulant.SiteWeb = row[23];
                    postulant.ProfileLinkedin = row[24];
                    postulant.ProfileViadeo = row[25];  
                    postulant.ProfileFacebook = row[26];

                    try
                    {
                        var BirthDay = postulant.DateDeNaissance;
                        var dateTime = DateTime.Parse(BirthDay, cultureInfo);
                        var age = DateTime.Now.Year - dateTime.Year - 1;
                        postulant.Age = age.ToString();
                    }
                    catch 
                    {
                        postulant.Age = "";
                    }
                    

                    context.Postulants.Add(postulant);                   
                }            
                context.SaveChanges();
            }

            using (var context = new CVDBContext())
            {
                var lineAttributs = context.Postulants.Where(postulant => postulant.Nom == "Nom").FirstOrDefault();
                context.Remove(lineAttributs);
                context.SaveChanges();
            }
        }

        static public void EffacerLaBDD()
        {
            using (var context = new CVDBContext())
            {
                context.Postulants.RemoveRange(context.Postulants);
                context.SaveChanges();
            }

        }







    }
}
