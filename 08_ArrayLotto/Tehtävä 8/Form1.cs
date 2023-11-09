using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä_8
{
    public partial class Form1 : Form
    {
        private List<int> RandomNumbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
                
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private HashSet<int> UsedNumbers = new HashSet<int>();


        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 7; i++)
            {
                TextBox textBox = Controls.Find("textBox" + i, true).FirstOrDefault() as TextBox;
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"Kenttä {i} on tyhjä. Syötä numero.");
                    return;
                }
                if (!int.TryParse(textBox.Text, out int numero) || numero < 1 || numero > 40)
                {
                    MessageBox.Show($"Virheellinen numero kentässä {i}. Syötä numero 1 - 40.");
                    return;
                }
                if (UsedNumbers.Contains(numero))
                {
                    MessageBox.Show($"Numero {numero} on jo käytössä. Syötä toinen numero.");
                    UsedNumbers.Clear();
                    return;
                }
                UsedNumbers.Add(numero);
            }


            RandomNumbers.Clear();

            Random random = new Random();

            while (RandomNumbers.Count < 7)
            {
                int arvottuNumero = random.Next(1, 41);
                if (!RandomNumbers.Contains(arvottuNumero))
                {
                    RandomNumbers.Add(arvottuNumero);
                }
            }

            List<int> lisänumerot = new List<int>();
            while (lisänumerot.Count < 2)
            {
                int arvottuNumero = random.Next(1, 41);
                if (!lisänumerot.Contains(arvottuNumero) && !RandomNumbers.Contains(arvottuNumero))
                {
                    lisänumerot.Add(arvottuNumero);
                }
            }

            RandomNumbers.Sort();
            lisänumerot.Sort();

            label3.Text = string.Join(", ", RandomNumbers);
            label5.Text = string.Join(", ", lisänumerot);

            List<int> käyttäjänNumerot = new List<int>();

            for (int i = 1; i <= 7; i++)
            {
                TextBox textBox = Controls.Find("textBox" + i, true).FirstOrDefault() as TextBox;
                käyttäjänNumerot.Add(int.Parse(textBox.Text));
            }
            int oikeinLisänumerot = lisänumerot.Intersect(käyttäjänNumerot).Count();
            int oikein = RandomNumbers.Intersect(käyttäjänNumerot).Count();
            MessageBox.Show($"Arvasit nämä numerit {oikein} oikein ja listänumeroista {oikeinLisänumerot} oikein!");
            for (int i = 1; i <= 7; i++)
            {
                TextBox textBox = Controls.Find("textBox" + i, true).FirstOrDefault() as TextBox;
                textBox.Clear();
            }
            label3.Text = "";
            label5.Text = "";
            UsedNumbers.Clear();
        }

        

    }

}

