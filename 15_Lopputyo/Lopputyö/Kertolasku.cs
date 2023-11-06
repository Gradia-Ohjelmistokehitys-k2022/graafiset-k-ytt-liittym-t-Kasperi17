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
    public partial class Kertolasku : Form
    {
        public static Kertolasku instance;
        private int kysymykset;
        private int ensimmainenLuku;
        private int toinenLuku;
        private int vastaus;
        int oikeinVastatut = 0;
        private int parasTulos = 0;
        private Random random = new Random();
       
        public Kertolasku()
        {
            InitializeComponent();
            instance = this;
            button1.Click += new System.EventHandler(UusiPeli_Click);
            LataaParasTulos();
            lasku1();
        }
        


        private void lasku1()
        {
            if (kysymykset < 11)
            {
                ensimmainenLuku = random.Next(1, 10);
                toinenLuku = random.Next(1, 10);
                vastaus = ensimmainenLuku * toinenLuku;
                Lasku.Text = ensimmainenLuku + " * " + toinenLuku + " = ";
                Syötälasku.Text = "";
                kysymykset++;
                //Luodaan random laskut ja määritellään oikea vastaus.
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
                //Tarkistetaan saiko pelaaja uuden tuloksen ja jos sai niin tallennetaan se.
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
                catch (IOException)
                {
                    MessageBox.Show("Virhe ladattaessa tulosta: ");
                }
                //Paras tulos tiedosto tarkistetaan ja sieltä otetaan paras tulos.
            }
        }


        private void TallennaParasTulos()
        {
            try
            {
                File.WriteAllText("parastulos1.txt", parasTulos.ToString());
            }
            catch (IOException)
            {
                MessageBox.Show("Virhe tallennettaessa tulosta: ");
            }
        }

        private void Vastaus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (kysymykset < 11)
                {
                    if (Syötälasku.Text == vastaus.ToString())
                    {
                        
                        oikeinVastatut++;
                        PelaajaSaavuttiUudenTuloksen(oikeinVastatut);
                    }
                    lasku1();
                    Tulos1();
                    //Tarkistetaan enteriä painamalla onko vastaus oikea.
                }
            }


        }

        private void Tulos1()
        {
            Tulos.Text = oikeinVastatut + " / 10";
        }
        


        private void ResetoiTulos_Click(object sender, EventArgs e)
        {
            parasTulos = 0;
            label5.Text = "Paras tulos: " + parasTulos;
            TallennaParasTulos();
        }

        private void UusiPeli_Click(object sender, EventArgs e)
        {
            kysymykset = 0;
            oikeinVastatut = 0;
            lasku1();
            Tulos1();
        }
        private void päävalikkoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form1 = new Menu();
            form1.Show();
            
        }

        
    }
}
