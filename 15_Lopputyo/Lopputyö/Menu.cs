using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lopputyö
{
    public partial class Menu : Form
    {   
        public static Menu instance;
        private SoundPlayer musa;
        private SoundPlayer musa2;
        private List<Pelaaja> pelaajat = new List<Pelaaja>();
        private string pelaajanNimi;

        public Menu()
        {
            musiikki();
            InitializeComponent();
            instance = this;
        }

        

        
        



        private void miinusbutton1_Click(object sender, EventArgs e)
        {
            
            Miinuslasku form = new Miinuslasku();
            this.Hide();
            form.Show();
            

        }

        private void kertobutton2_Click(object sender, EventArgs e)
        {
            Kertolasku form = new Kertolasku();
            this.Hide();
            form.Show();
        }

        private void plusbutton3_Click(object sender, EventArgs e)
        {
            Pluslasku form = new Pluslasku();
            this.Hide();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string kayttajaNimi = Environment.UserName;
            LataaKayttajat();

            label2.Text = "Kirjautunut käyttäjä:\n" + kayttajaNimi;
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            TallennaKayttajat();
            
        }

        private void musiikki1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer musa = new SoundPlayer(Lopputyö.Properties.Resources.Ketsa___Firstly);
            musa.Play();
            musa2.Stop();
        }

        private void musiikka2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SoundPlayer musa2 = new SoundPlayer(Lopputyö.Properties.Resources.in_the_cafe_with_coffee_after_lunch_140_173156);
            musa2.Play();
        }
        public void musiikki()
        {
            SoundPlayer musa = new SoundPlayer(Lopputyö.Properties.Resources.Ketsa___Firstly);
            //musa.Play();

        }

        private void Vahvista_Click(object sender, EventArgs e)
        {
            string nimi = textBox1.Text;
            KirjauduSisaan(nimi);
        }
        private void KirjauduSisaan(string nimi)
        {
            
            bool kayttaja = false;
            
            if (pelaajat == null)
            {
                Pelaaja pelaaja = new Pelaaja(nimi);
                pelaajat.Add(pelaaja);
            }

            foreach (Pelaaja pelaaja in pelaajat)
            {
                if (pelaaja.Nimi == nimi)
                {
                    kayttaja = true;
                    break;
                }
            }

            if (kayttaja)
            {
                MessageBox.Show("Kirjautuminen onnistui!");
            }
            else
            {
                Pelaaja uusiPelaaja = new Pelaaja(nimi);
                pelaajat.Add(uusiPelaaja);
                MessageBox.Show("Uusi käyttäjä lisätty!");
            }

        }


        public void TallennaKayttajat()
        {
            
            string tiedostoNimi = "kayttajat.txt";

            
            using (StreamWriter tiedosto = new StreamWriter(tiedostoNimi))
            {
                foreach (Pelaaja pelaaja in pelaajat)
                {
                    tiedosto.WriteLine(pelaaja.Nimi);
                    
                }
            }
        }
        public void LataaKayttajat()
        {
            string tiedostoNimi = "kayttajat.txt";

            if (File.Exists(tiedostoNimi))
            {
                
                using (StreamReader tiedosto = new StreamReader(tiedostoNimi))
                {
                    string rivi;
                    while ((rivi = tiedosto.ReadLine()) != null)
                    {
                        Pelaaja pelaaja = new Pelaaja(rivi);
                        pelaaja.Nimi = rivi;
                        pelaajat.Add(pelaaja);
                    }
                }
            }
            else
            {
                pelaajat = new List<Pelaaja>();
            }
        }












    }
}
