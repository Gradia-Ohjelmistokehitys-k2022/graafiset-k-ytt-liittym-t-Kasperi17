﻿using System;
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
        private int kysymykset;
        private int ensimmainenLuku;
        private int toinenLuku;
        private int vastaus;
        int oikeinVastatut = 0;
        private int parasTulos = 0;
        private string parhaatTulokset = "parhaat miinuslaskut.txt";
        public Miinuslasku()
        {
            InitializeComponent();
            instance = this;
            UusiPeli.Click += new System.EventHandler(UusiPeli_Click);
            parasTulos = Hyöty.LataaParasTulos(parhaatTulokset);
            lasku1();
            Ennätys.Text = "Paras tulos: " + parasTulos;
        }
        



        private void PelaajaSaavuttiUudenTuloksen(int uusiTulos)
        {
            if (uusiTulos > parasTulos)
            {
                parasTulos = uusiTulos;
                Hyöty.TallennaParasTulos(parasTulos, parhaatTulokset);
                Ennätys.Text = "Paras tulos: " + parasTulos;
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
                //luodaan laskut ja määritellään oikea vastaus
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
                    //Tarkistetaan menikö lasku oikean ja luodaan uusi lasku.
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
            Ennätys.Text = "Paras tulos: " + parasTulos;
            Hyöty.TallennaParasTulos(parasTulos, "parhaat pluslasku tulokset.txt");
            //Resetoidaan ennätys.
        }
        

        private void UusiPeli_Click(object sender, EventArgs e)
        {
            kysymykset = 0; 
            oikeinVastatut = 0;
            lasku1();
            tulos();
            //aloitetaan uusipeli
        }

        private void takaisinPäävalikkoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form1 = new Menu();
            form1.Show();
            
        }

        private void Lasku_Click(object sender, EventArgs e)
        {

        }
    }
}
