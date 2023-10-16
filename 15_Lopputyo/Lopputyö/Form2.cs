using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopputyö
{       
    public partial class Form2 : Form
    {
        private Random random = new Random();
        int kysymykset;
        List<string> list = new List<string>();
        public static Form2 instance;
        
        private int ensimmainenLuku;
        private int toinenLuku;
        private int vastaus;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

           
                ensimmainenLuku = random.Next(1, 10);
                toinenLuku = random.Next(1, 10);
                vastaus = ensimmainenLuku - toinenLuku;
                label2.Text = ensimmainenLuku + " - " + toinenLuku + " = ";
                textBox1.Text = "";



        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                if (textBox1.Text == vastaus.ToString())
                {
                    MessageBox.Show("Oikein!");
                }
                else
                {
                    MessageBox.Show("Väärin.");
                }
                label2_Click(sender, e);


            }
            

        }

    }
}
