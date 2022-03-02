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
    }
}