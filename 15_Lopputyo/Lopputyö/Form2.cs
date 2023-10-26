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
    public partial class Form2 : Form
    {
        private Random random = new Random();
        List<string> list = new List<string>();
        public static Form2 instance;
       

        private int kysymykset;
        private int ensimmainenLuku;
        private int toinenLuku;
        private int vastaus;
        int oikeinVastatut = 0;
        private int parasTulos = 0; 
        public Form2()
        {
            InitializeComponent();
            instance = this;
            button1.Click += new System.EventHandler(button1_Click);
            LataaParasTulos();

        }
        public void PaivitaParasTulos(int uusiTulos)
        {
            if (uusiTulos > parasTulos)
            {
                parasTulos = uusiTulos;
                label5.Text = "Paras tulos: " + parasTulos;
                TallennaParasTulos();
            }
        }

        private string TallennustiedostonNimi()
        {
            // Voit käyttää esimerkiksi Formin nimeä tallennustiedoston osana.
            return "parastulos_Form2.txt";
        }





        private void PelaajaSaavuttiUudenTuloksen(int uusiTulos)
        {
            PaivitaParasTulos(uusiTulos);
        }

        private void TallennaParasTulos()
        {
            try
            {
                File.WriteAllText("parastulos.txt", parasTulos.ToString());
            }
            catch (IOException ex)
            {
                MessageBox.Show("Virhe tallennettaessa tulosta: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LataaParasTulos()
        {
            if (File.Exists("parastulos.txt"))
            {
                try
                {
                    string tallennettuTulos = File.ReadAllText("parastulos.txt");
                    if (int.TryParse(tallennettuTulos, out int tulos))
                    {
                        parasTulos = tulos;
                        label5.Text = "Paras tulos: " + parasTulos;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Virhe ladattaessa tulosta: " + ex.Message, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }







        private void label2_Click(object sender, EventArgs e)
        {

            if (kysymykset < 10)
            {
                ensimmainenLuku = random.Next(1, 10);
                toinenLuku = random.Next(1, 10);
                vastaus = ensimmainenLuku - toinenLuku;
                label2.Text = ensimmainenLuku + " - " + toinenLuku + " = ";
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
                        PelaajaSaavuttiUudenTuloksen(oikeinVastatut);
                    }
                    else
                    {
                        MessageBox.Show("Väärin.");
                    }
                    label2_Click(sender, e);
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

        }

        private void takaisinPäävalikkoonToolStripMenuItem_Click(object sender, EventArgs e)
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
