using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopputyö
{
    public partial class Form3 : Form
    {
        public static Form3 instance;
        public Form3()
        {
            InitializeComponent();
            instance = this;
            button1.Click += new System.EventHandler(button1_Click);
            LataaParasTulos();
        }
        private Random random = new Random();
        List<string> list = new List<string>();
        private int kysymykset;
        private int ensimmainenLuku;
        private int toinenLuku;
        private int vastaus;
        int oikeinVastatut = 0;
        private int parasTulos = 0;



        private void label2_Click(object sender, EventArgs e)
        {


            if (kysymykset < 10)
            {
                ensimmainenLuku = random.Next(1, 10);
                toinenLuku = random.Next(1, 10);
                vastaus = ensimmainenLuku * toinenLuku;
                label2.Text = ensimmainenLuku + " * " + toinenLuku + " = ";
                textBox1.Text = "";
                kysymykset++;
            }
            if (kysymykset == 10)
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





        private void LataaParasTulos()
        {
            if (File.Exists("parastulos1.txt"))
            {
                try
                {
                    string tallennettuTulos = File.ReadAllText("parastulos1.txt");
                    if (int.TryParse(tallennettuTulos, out int tulos))
                    {
                        parasTulos = tulos;
                        label5.Text = "Paras tulos: " + parasTulos;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Virhe ladattaessa tulosta: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
        }


        private void TallennaParasTulos()
        {
            try
            {
                File.WriteAllText("parastulos1.txt", parasTulos.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show("Virhe tallennettaessa tulosta: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (kysymykset < 10)
                {
                    if (textBox1.Text == vastaus.ToString())
                    {
                        MessageBox.Show("Oikein!");
                        oikeinVastatut++; // Kasvata oikein vastattujen kysymysten määrää
                        PelaajaSaavuttiUudenTuloksen(oikeinVastatut);
                    }
                    else
                    {
                        MessageBox.Show("Väärin.");
                    }
                    label2_Click(sender, e);

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
