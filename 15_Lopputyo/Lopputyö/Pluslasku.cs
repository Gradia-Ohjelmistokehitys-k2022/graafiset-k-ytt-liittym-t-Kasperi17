using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Lopputyö
{
    public partial class Pluslasku : Form
    {
        public static Pluslasku instance;
        private Random random = new Random();
        private SoundPlayer musa;
        private int kysymykset;
        private int ensimmainenLuku;
        private int toinenLuku;
        private int vastaus;
        int oikeinVastatut = 0;
        private int parasTulos = 0;
        public Pluslasku()
        {
            InitializeComponent();
            instance = this;
            uusiPeli.Click += new System.EventHandler(uusiPeli_Click);
            LataaParasTulos();


        }


        private void laskuClick_1(object sender, EventArgs e)
        {

            if (kysymykset < 11)
            {
                ensimmainenLuku = random.Next(1, 10);
                toinenLuku = random.Next(1, 10);
                vastaus = ensimmainenLuku + toinenLuku;
                lasku.Text = ensimmainenLuku + " + " + toinenLuku + " = ";
                syötalasku1.Text = "";
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
                Ennätys.Text = "Paras tulos: " + parasTulos;
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
                        Ennätys.Text = "Ennätys tulos: " + parasTulos;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Virhe ladattaessa tulosta: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void Vastaus_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (kysymykset < 11)
                {
                    if (syötalasku1.Text == vastaus.ToString())
                    {
                        MessageBox.Show("Oikein!");
                        oikeinVastatut++;
                        PelaajaSaavuttiUudenTuloksen(oikeinVastatut);
                    }
                    else
                    {
                        MessageBox.Show("Väärin.");
                    }
                    laskuClick_1(sender, e);
                }
            }



        }

        private void UusiPeli_Click(object sender, EventArgs e)
        {
            label3.Text = "Oikein vastattu: " + oikeinVastatut + " / 10";
        }

        private void uusiPeli_Click(object sender, EventArgs e)
        {
            kysymykset = 0;
            oikeinVastatut = 0;
            label3.Text = "tulos";
            lasku.Text = "lasku";
        }

        private void päävalikkoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form1 = new Menu();
            form1.Show();
            musa.Stop();
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

        private void ResetoiEnnätys_Click(object sender, EventArgs e)
        {
            parasTulos = 0;
            Ennätys.Text = "Paras tulos: " + parasTulos;
            TallennaParasTulos();
        }

        private void musiikki()
        {
            SoundPlayer musa = new SoundPlayer(Lopputyö.Properties.Resources.for_elevator_jazz_music_124005);
            musa.Play();
        }

        
    }
}