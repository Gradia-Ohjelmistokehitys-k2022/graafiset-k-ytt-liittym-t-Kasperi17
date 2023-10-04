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
                    // Kysy käyttäjältä, haluaako hän jatkaa luuppia
                    DialogResult result = MessageBox.Show("Haluatko jatkaa luuppia?", "Kysymys", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        // Käyttäjä haluaa jatkaa, suorita uusi kierros luupissa
                        MessageBox.Show("Jatketaan luuppia!");
                    }
                    else if (result == DialogResult.No)
                    {// Käyttäjä ei halua jatkaa, poistu luupista
                        
                        MessageBox.Show("Poistutaan luupista.");
                        continueLoop = false;
                    }
                }
            

        }
    }
}