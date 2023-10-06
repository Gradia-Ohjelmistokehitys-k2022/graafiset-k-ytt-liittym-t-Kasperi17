using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä_9
{
    public partial class Form1 : Form
    {
        private List<string> merkkijonoLista = new List<string>();
        private bool listaLuotu = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            merkkijonoLista = new List<string>();
            MessageBox.Show("Lista luotu onnistuneesti.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!listaLuotu)
            {
                MessageBox.Show("Luo lista ennen merkkijonojen lisäämistä.");
                return; // Keskeytä lisäys, jos lista ei ole vielä luotu
            }

           
            string merkkijono = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(merkkijono))
            {
                merkkijonoLista.Add(merkkijono);
                MessageBox.Show("Merkkijono lisätty listaan.");
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Syötä merkkijono ensin.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             comboBox1.Items.Clear();

            foreach (string merkkijono in merkkijonoLista)
            {
                comboBox1.Items.Add(merkkijono);
            }

            if (comboBox1.Items.Count == 0)
            {
                MessageBox.Show("Lista on tyhjä.");
            }
            else
            {
                MessageBox.Show("Merkkijonot haettu ja lisätty ComboBoxiin.");
            }
        }
    }
    
}
