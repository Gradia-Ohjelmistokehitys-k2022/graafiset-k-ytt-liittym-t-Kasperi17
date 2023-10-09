using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä_10
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dictionary = new Dictionary<string, string>();
            MessageBox.Show("Dictionary luotu.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            string value = textBox2.Text;

            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                dictionary[key] = value;
                MessageBox.Show("Key/Value-pari lisätty dictionaryyn.");
            }
            else
            {
                MessageBox.Show("Syötä sekä Key että Value.");
            }

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string key = textBox3.Text;
            if (!string.IsNullOrEmpty(key) && dictionary.ContainsKey(key))
            {
                string value = dictionary[key];
                label8.Text = "Hakutulos: " + value;
            }
            else
            {
                label8.Text = "Keytä ei löytynyt tai se on tyhjä.";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
