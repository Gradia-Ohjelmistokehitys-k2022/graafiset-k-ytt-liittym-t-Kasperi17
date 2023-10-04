using System.Windows.Forms;

namespace Tehtävä_5
{
    public partial class Pääformi : Form
    {
        public Pääformi()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Int32.Parse(textBox1.Text); i++)
            {
                label1.Text = i.ToString();
                Thread.Sleep(100);
                label1.Update();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}