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
        }
    }
}


