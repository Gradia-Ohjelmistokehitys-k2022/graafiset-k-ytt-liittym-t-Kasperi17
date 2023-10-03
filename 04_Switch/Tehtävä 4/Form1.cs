using System.Windows.Forms;

namespace Tehtävä_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Valintabutton1_Click(object sender, EventArgs e)
        {
            Button painettuNappi = (Button)sender;

            switch (painettuNappi.Name)
            {
                case "Valintabutton1":
                    MessageBox.Show("Nappi 1 painettu!");
                    break;
                case "Valintabutton2":
                    MessageBox.Show("Nappi 2 painettu!");
                    break;
                case "Valintabutton3":
                    MessageBox.Show("Nappi 3 painettu!");
                    break;
                case "Valintabutton4":
                    MessageBox.Show("Nappi 4 painettu!");
                    break;
                case "Default":
                    MessageBox.Show("Nappi 5 painettu!");
                    break;

            }

        }

        private void Valintabutton2_Click(object sender, EventArgs e)
        {

        }
        private void Nappi_Click(object sender, EventArgs e)
        {
           
            
        }







    }






}