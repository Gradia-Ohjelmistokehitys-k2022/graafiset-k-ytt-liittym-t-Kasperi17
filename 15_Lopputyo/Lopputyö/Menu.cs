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
//Matikkapeli kirjautumissysteemi vielä keskeneräinen.

namespace Lopputyö
{
    public partial class Menu : Form
    {   
        public static Menu instance;
        private List<Pelaaja> pelaajat = new List<Pelaaja>();

        public Menu()
        {
            
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
            TarkistaKayttajat();

            
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
            TallennaKayttajat();
            
        }

        
       

        private void Vahvista_Click(object sender, EventArgs e)
        {
            string nimi = textBox1.Text;
            KirjauduSisaan(nimi);
        }
        private void KirjauduSisaan(string nimi)
        {
            
            bool kayttaja = false;
            
            

            foreach (Pelaaja pelaaja in pelaajat)
            {
                if (pelaaja.Nimi == nimi)
                {
                    kayttaja = true;
                    break;
                }
                //Tarkistetaan onko syötetty käyttäjä olemassa.
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
                // Lisätään uusi käyttäjä jos ei ollut olemassa.
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
        public void TarkistaKayttajat()
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
