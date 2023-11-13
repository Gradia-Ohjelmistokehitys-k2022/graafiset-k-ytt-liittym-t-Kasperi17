using System;
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
        private int kysymykset;
        private int ensimmainenLuku;
        private int toinenLuku;
        private int vastaus;
        int oikeinVastatut = 0;
        private int parasTulos = 0;
        private string parhaatTulokset = "parhaat pluslaskut.txt";
        public Pluslasku()
        {
            InitializeComponent();
            instance = this;
            uusiPeli.Click += new System.EventHandler(uusiPeli_Click);
            parasTulos = Hyöty.LataaParasTulos(parhaatTulokset);
            Lasku1();
            Ennätys.Text = "Paras tulos: " + parasTulos;
        }




        private void Lasku1()
        {
            if (kysymykset < 11)
            {   
                
                
                vastaus = ensimmainenLuku + toinenLuku;
                Lasku.Text = ensimmainenLuku + " + " + toinenLuku + " = ";
                Syötalasku1.Text = "";
                kysymykset++;
                //luodaan randomisti laskut ja katsotaan mikä on oikea vastaus

            }
            if (kysymykset == 11)
            {
                MessageBox.Show("Olet ratkaissut 10 kysymystä. Peli päättyi.");
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
                    comboBox1_SelectedIndexChanged(sender, e);
                    Lasku1();
                    Tulos1();
                    //tarkistetaan oikea vastaus ja luodaan uusi lasku.
                }
            }



        }
         private void Tulos1()
         {
            label3.Text = "Pisteitä: " + oikeinVastatut + " / 10";
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
            Hyöty.TallennaParasTulos(parasTulos, parhaatTulokset);
        }
        public void PaivitaParasTulos(int uusiTulos)
        {
            if (uusiTulos > parasTulos)
            {
                parasTulos = uusiTulos;
                Hyöty.TallennaParasTulos(parasTulos, parhaatTulokset);
                Ennätys.Text = "Paras tulos: " + parasTulos;
                
            }
        }

        private void PelaajaSaavuttiUudenTuloksen(int uusiTulos)
        {
            PaivitaParasTulos(uusiTulos);
        }

        private void päävalikkoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu form1 = new Menu();
            form1.Show();
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           string vaikeustaso = comboBox1.SelectedItem.ToString();
           Hyöty.VaikeusTasonAsettaminen(vaikeustaso, out ensimmainenLuku, out toinenLuku);
           Lasku.Text = ensimmainenLuku + " + " + toinenLuku + " = ";
            



        }
    }
    



}
    


