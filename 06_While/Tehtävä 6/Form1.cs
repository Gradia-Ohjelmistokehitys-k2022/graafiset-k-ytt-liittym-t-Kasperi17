namespace Tehtävä_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                bool continueLoop = true;

                while (continueLoop)
                {
                   
                    DialogResult result = MessageBox.Show("Haluatko jatkaa luuppia?", "Huom!", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        
                        MessageBox.Show("Jatketaan luuppia!");
                    }
                    else if (result == DialogResult.No)
                    {
                        
                        MessageBox.Show("Poistutaan luupista.");
                        continueLoop = false;
                    }
                }
            

        }
    }
}