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

namespace Lopputyö
{
    public partial class Form1 : Form
    {   
        public static Form1 instance;
        List<int> kayttaja = new List<int>();
        List<int> kayttajaParhaatTulokset = new List<int>();
        int kayttajaParasTulos = 0;

        private int suurinTulos;
        public Form1()
        {
          
            InitializeComponent();
            instance = this;
        }
        public void PaivitaParasTulos(int uusiTulos)
        {
            if (uusiTulos > kayttajaParasTulos)
            {
                kayttajaParasTulos = uusiTulos;
                label3.Text = "Paras tulos: " + kayttajaParasTulos;
            }
        }
       



        private void miinusbutton1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
            
        }

        private void kertobutton2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            form.Show();
        }

        private void plusbutton3_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            this.Hide();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string loggedInUser = Environment.UserName;


            label2.Text = "Kirjautunut käyttäjä:\n" + loggedInUser;
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        


















    }
}
