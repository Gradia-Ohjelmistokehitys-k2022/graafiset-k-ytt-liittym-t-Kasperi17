namespace Tehtävä
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string arivodefault = "Kirjoita arvio tähän";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Kasperi Salonen");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NimitextBox.Text = "Syötä elokuvan nimi";
            IDtextBox.Text = "0";
            JulkaisupäivätextBox.Text = GetCurrentYear();
            ArviotextBox.Text = arivodefault;
            numericUpDown1.Value = 5;
            KestotextBox.Text = "0";

        }

        public string GetCurrentYear()
        {

            {
                string CurrentYear = DateTime.Now.Year.ToString();

                return CurrentYear;
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtextBox_Enter(object sender, EventArgs e)
        {

        }

        private void NimitextBox_Enter(object sender, EventArgs e)
        {
            NimitextBox.Text = "";
        }


        private void JulkaisupäivätextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void KestotextBox_Enter(object sender, EventArgs e)
        {
            KestotextBox.Text = "";
        }

        private void JulkaisupäivätextBox_Enter(object sender, EventArgs e)
        {
            JulkaisupäivätextBox.Text = "";
        }


        private void ArviotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArviotextBox_Enter(object sender, EventArgs e)
        {
            ArviotextBox.Text = "";
        }

        private void NimitextBox_Leave(object sender, EventArgs e)
        {
            NimitextBox.Text = "Syötä elokuvan nimi";
        }

        private void JulkaisupäivätextBox_Leave(object sender, EventArgs e)
        {
            JulkaisupäivätextBox.Text = GetCurrentYear();
        }

        private void KestotextBox_Leave(object sender, EventArgs e)
        {
            KestotextBox.Text = "0";
        }

        private void ArviotextBox_Leave(object sender, EventArgs e)
        {
            ArviotextBox.Text = arivodefault;
        }
    }
}