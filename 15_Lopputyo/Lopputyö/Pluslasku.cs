﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lopputyö
{
    
    
    public partial class Pluslasku : Form
    {
        public static Pluslasku instance;
        private Random random = new Random();
        private int kysymykset;
        private int ensimmainenLuku;
        private int toinenLuku;
        private int vastaus;
        int oikeinVastatut = 0;
        private int parasTulos = 0;
        private string kayttajaNimi;
        
        public Pluslasku()
        {
            InitializeComponent();
            instance = this;
            uusiPeli.Click += new System.EventHandler(uusiPeli_Click);
            LataaParasTulos();
            musiikki();
            Lasku1();
            string kayttajaNimi = Environment.UserName;

        }


        private void Lasku1()
        {
            if (kysymykset < 11)
            {
                ensimmainenLuku = random.Next(1, 10);
                toinenLuku = random.Next(1, 10);
                vastaus = ensimmainenLuku + toinenLuku;
                Lasku.Text = ensimmainenLuku + " + " + toinenLuku + " = ";
                Syötalasku1.Text = "";
                kysymykset++;
                //luodaan randomisti laskut ja katsotaan mikä on oikea vastaus

            }
            if (kysymykset == 11)
            {
                MessageBox.Show("Olet ratkaissut 10 kysymystä");
            }

        }
        private void Vastaus_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (kysymykset < 11)
                {
                    if (Syötalasku1.Text == vastaus.ToString())
                    {
                       
                        oikeinVastatut++;
                        PelaajaSaavuttiUudenTuloksen(oikeinVastatut);
                    }
                    Lasku1();
                    Tulos1();
                    //tarkistetaan oikea vastaus ja luodaan uusi lasku.
                }
            }



        }
         private void Tulos1()
         {
            label3.Text = oikeinVastatut + " / 10";
         }

        private void uusiPeli_Click(object sender, EventArgs e)
        {
            kysymykset = 0;
            oikeinVastatut = 0;
            Lasku1();
            Tulos1();
        }

        private void ResetoiEnnätys_Click(object sender, EventArgs e)
        {
            parasTulos = 0;
            Ennätys.Text = "Paras tulos: " + parasTulos;
            Hyöty.TallennaParasTulos(parasTulos, "parhaat pluslasku tulokset.txt");
        }
        public void PaivitaParasTulos(int uusiTulos)
        {
            if (uusiTulos > parasTulos)
            {
                parasTulos = uusiTulos;
                Ennätys.Text = "Paras tulos: " + parasTulos;
                //TallennaParasTulos();
                //Tarkistetaan saiko käyttä paremman tuloksen kuin viimeksi.
                Hyöty.TallennaParasTulos(parasTulos, "parhaat pluslasku tulokset.txt");
            }
        }

        private void PelaajaSaavuttiUudenTuloksen(int uusiTulos)
        {
            PaivitaParasTulos(uusiTulos);
        }


        
        private void LataaParasTulos()
        {
            if (File.Exists(kayttajaNimi + "parastulos3.txt"))
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
                catch (IOException)
                {
                    MessageBox.Show("Virhe ladattaessa tulosta: ");
                }
            }
        }
       
       
        private void päävalikkoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form1 = new Menu();
            form1.Show();
            
            
        }
        private void musiikki()
        {
            SoundPlayer musa = new SoundPlayer(Lopputyö.Properties.Resources.for_elevator_jazz_music_124005);
            //musa.Play();
        }

        private void Lasku_Click(object sender, EventArgs e)
        {

        }

        
    }
    



}
    


