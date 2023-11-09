namespace Tehtävä_7
{
    public partial class Form1 : Form
    {
        int[] taulukko;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (int.TryParse(this.Controls["textBox1"].Text, out int size))
            {
                
                array = new int[size];
            }
=======
            taulukko = new int[(int.Parse(textBox1.Text))];
        }

        private void numerotextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void indeksitextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

        {
            int indeksi = int.Parse(indeksitextBox3.Text);
            taulukko[indeksi] = int.Parse(numerotextBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int indeksi = int.Parse(tallennuspaikantextBox4.Text);
            label8.Text = taulukko[indeksi].ToString();
>>>>>>> c2d0ec775013d7a6cbb7875fabeea349e00750f2
        }
    }
}


