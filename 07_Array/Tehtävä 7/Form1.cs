namespace Tehtävä_7
{
    public partial class Form1 : Form
    {
        private int[] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.Controls["textBox1"].Text, out int size))
            {
                // Luo taulukko annetulla koolla
                array = new int[size];
            }
        }
        
    }
}