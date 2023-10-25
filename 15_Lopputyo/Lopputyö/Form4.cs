using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopputyö
{
    public partial class Form4 : Form
    {
        public static Form4 instance;
        private Random random = new Random();
        List<string> list = new List<string>();
        private int kysymykset;
        private int ensimmainenLuku;
        private int toinenLuku;
        private int vastaus;
        int oikeinVastatut = 0;
        public Form4()
        {
            InitializeComponent();
            instance = this;
            button1.Click += new System.EventHandler(button1_Click);



        }


        private void label2_Click_1(object sender, EventArgs e)
        {

            if (kysymykset < 10)
            {
                ensimmainenLuku = random.Next(1, 10);
                toinenLuku = random.Next(1, 10);
                vastaus = ensimmainenLuku + toinenLuku;
                label2.Text = ensimmainenLuku + " + " + toinenLuku + " = ";
                textBox1.Text = "";
                kysymykset++;
            }
            if (kysymykset == 10)
            {
                MessageBox.Show("Olet ratkaissut 10 kysymystä");
            }

        }




        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (kysymykset < 10)
                {
                    if (textBox1.Text == vastaus.ToString())
                    {
                        MessageBox.Show("Oikein!");
                        oikeinVastatut++; // Kasvata oikein vastattujen kysymysten määrää
                    }
                    else
                    {
                        MessageBox.Show("Väärin.");
                    }
                    label2_Click_1(sender, e);
                }
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Oikein vastattu: " + oikeinVastatut + " / 10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kysymykset = 0;
            oikeinVastatut = 0;
            label3.Text = "tulos";
            label2.Text = "lasku";
        }

        private void päävalikkoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tekstitiedostot|*.txt|Kaikki tiedostot|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                string content = label3.Text;

                try
                {
                    File.WriteAllText(fileName, content);
                    MessageBox.Show("Tiedosto tallennettu onnistuneesti.", "Tallennus onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe tallennettaessa tiedostoa: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }











            }

        }
    }
}