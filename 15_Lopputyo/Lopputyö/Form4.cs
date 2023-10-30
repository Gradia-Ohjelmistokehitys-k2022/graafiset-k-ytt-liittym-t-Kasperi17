using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lopputyö
{
    public partial class Form4 : Form
    {
        public static Form4 instance;
        private Random random = new Random();
        List<string> list = new List<string>();
        private int kysymykset;
        private int ensimmainenLuku;
        private int toinenLuku;
        private int vastaus;
        int oikeinVastatut = 0;
        private int parasTulos = 0;
        public Form4()
        {
            InitializeComponent();
            instance = this;
            button1.Click += new System.EventHandler(button1_Click);
            LataaParasTulos();


        }


        private void label2_Click_1(object sender, EventArgs e)
        {

            if (kysymykset < 11)
            {
                ensimmainenLuku = random.Next(1, 10);
                toinenLuku = random.Next(1, 10);
                vastaus = ensimmainenLuku + toinenLuku;
                label2.Text = ensimmainenLuku + " + " + toinenLuku + " = ";
                textBox1.Text = "";
                kysymykset++;
            }
            if (kysymykset == 11)
            {
                MessageBox.Show("Olet ratkaissut 10 kysymystä");
            }

        }

        public void PaivitaParasTulos(int uusiTulos)
        {
            if (uusiTulos > parasTulos)
            {
                parasTulos = uusiTulos;
                label5.Text = "Paras tulos: " + parasTulos;
                TallennaParasTulos();
            }
        }



        private void PelaajaSaavuttiUudenTuloksen(int uusiTulos)
        {
            PaivitaParasTulos(uusiTulos);
        }


       


        private void TallennaParasTulos()
        {
            try
            {
                File.WriteAllText("parastulos3.txt", parasTulos.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show("Virhe tallennettaessa tulosta: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LataaParasTulos()
        {
            if (File.Exists("parastulos3.txt"))
            {
                try
                {
                    string tallennettuTulos = File.ReadAllText("parastulos3.txt");
                    if (int.TryParse(tallennettuTulos, out int tulos))
                    {
                        parasTulos = tulos;
                        label5.Text = "Ennätys tulos: " + parasTulos;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Virhe ladattaessa tulosta: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (kysymykset < 11)
                {
                    if (textBox1.Text == vastaus.ToString())
                    {
                        MessageBox.Show("Oikein!");
                        oikeinVastatut++;
                        PelaajaSaavuttiUudenTuloksen(oikeinVastatut);
                    }
                    else
                    {
                        MessageBox.Show("Väärin.");
                    }
                    label2_Click_1(sender, e);
                }
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Oikein vastattu: " + oikeinVastatut + " / 10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kysymykset = 0;
            oikeinVastatut = 0;
            label3.Text = "tulos";
            label2.Text = "lasku";
        }

        private void päävalikkoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog tallenna = new SaveFileDialog();
            tallenna.Filter = "Tekstitiedostot|*.txt|Kaikki tiedostot|*.*";

            if (tallenna.ShowDialog() == DialogResult.OK)
            {
                string tiedostoNimi = tallenna.FileName;
                string sisältö = label3.Text;

                try
                {
                    File.WriteAllText(tiedostoNimi, sisältö);
                    MessageBox.Show("Tiedosto tallennettu onnistuneesti.", "Tallennus onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe tallennettaessa tiedostoa: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            parasTulos = 0;
            label5.Text = "Paras tulos: " + parasTulos;
            TallennaParasTulos();
        }
    }
}