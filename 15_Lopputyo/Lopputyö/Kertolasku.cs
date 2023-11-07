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
        private string parhaatTulokset = "parhaat kertolaskut.txt";
        
       
        public Kertolasku()
        {
            InitializeComponent();
            instance = this;
            button1.Click += new System.EventHandler(UusiPeli_Click);
            parasTulos = Hyöty.LataaParasTulos(parhaatTulokset);
            lasku1();
            Ennätys.Text = "Paras tulos: " + parasTulos;
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
                Hyöty.TallennaParasTulos(parasTulos, parhaatTulokset);
                Ennätys.Text = "Paras tulos: " + parasTulos;
                
                //Tarkistetaan saiko pelaaja uuden tuloksen ja jos sai niin tallennetaan se.
            }
         }
        private void PelaajaSaavuttiUudenTuloksen(int uusiTulos)
        {
            PaivitaParasTulos(uusiTulos);
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
            Ennätys.Text = "Paras tulos: " + parasTulos;
            Hyöty.TallennaParasTulos(parasTulos, "parhaat pluslasku tulokset.txt");
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

        private void Lasku_Click(object sender, EventArgs e)
        {

        }
    }
}
