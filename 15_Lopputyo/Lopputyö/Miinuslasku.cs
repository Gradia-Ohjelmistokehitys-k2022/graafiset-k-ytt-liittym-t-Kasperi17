using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopputyö
{       
    public partial class Miinuslasku : Form
    {
        private Random random = new Random();
        public static Miinuslasku instance;
        private SoundPlayer musa;
        private int kysymykset;
        private int ensimmainenLuku;
        private int toinenLuku;
        private int vastaus;
        int oikeinVastatut = 0;
        private int parasTulos = 0; 
        public Miinuslasku()
        {
            InitializeComponent();
            instance = this;
            button1.Click += new System.EventHandler(UusiPeli_Click);
            LataaParasTulos();
            lasku1();
            musiikki();
            
        }
        
        


        private void PelaajaSaavuttiUudenTuloksen(int uusiTulos)
        {
            if (uusiTulos > parasTulos)
            {
                parasTulos = uusiTulos;
                label5.Text = "Paras tulos: " + parasTulos;

                TallennaParasTulos();
            }

        }

        private void TallennaParasTulos()
        {
            try
            {
                File.WriteAllText("parastulos.txt", parasTulos.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show("Virhe tallennettaessa tulosta: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LataaParasTulos()
        {
            if (File.Exists("parastulos.txt"))
            {
                try
                {
                    string tallennettuTulos = File.ReadAllText("parastulos.txt");
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
        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog tallenna = new SaveFileDialog();
            if (tallenna.ShowDialog() == DialogResult.OK)
            {
                string tiedostoNimi = tallenna.FileName;
                string sisältö = Tulos.Text;

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
        private void lasku1()
        {
            if (kysymykset < 11)
            {
                ensimmainenLuku = random.Next(1, 10);
                toinenLuku = random.Next(1, 10);
                vastaus = ensimmainenLuku - toinenLuku;
                Lasku.Text = ensimmainenLuku + " - " + toinenLuku + " = ";
                textBox1.Text = "";
                kysymykset++;
                
            }
            if (kysymykset == 11)
            {
                MessageBox.Show("Olet ratkaissut 10 kysymystä");
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
                        oikeinVastatut++; 
                        PelaajaSaavuttiUudenTuloksen(oikeinVastatut);
                    }
                    lasku1();
                    tulos();
                }
            }


        }
        private void tulos()
        {
            Tulos.Text = oikeinVastatut + " / 10";
            
        }
        private void ResetoiEnnätys_Click(object sender, EventArgs e)
        {
            parasTulos = 0;
            label5.Text = "Paras tulos: " + parasTulos;
            TallennaParasTulos();
        }
        

        private void UusiPeli_Click(object sender, EventArgs e)
        {
            kysymykset = 0; 
            oikeinVastatut = 0;
            Tulos.Text = "tulos";
            Lasku.Text = "lasku";

        }

        

        

        private void takaisinPäävalikkoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form1 = new Menu();
            form1.Show();
            
        }
        private void musiikki()
        {
            SoundPlayer musa = new SoundPlayer(Lopputyö.Properties.Resources.for_elevator_jazz_music_124005);
            musa.Play();
        }       
    }
}
