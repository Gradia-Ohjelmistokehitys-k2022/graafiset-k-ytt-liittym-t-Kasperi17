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

        }

        private void Valintabutton2_Click(object sender, EventArgs e)
        {

        }
        


        private void CommonButtonClick(object sender, EventArgs e)
        {
            // Muutetaan objekti Button-tyyppiseksi
            if (sender is Button clickedButton)
            {
                string message = "";

                // Käytetään switch-lausetta, jotta tiedetään, mikä nappi klikattiin
                switch (clickedButton.Name)
                {
                    case "Valintabutton1":
                        message = "Nappi 1 valittu";
                        break;
                    case "button2":
                        message = "Nappi 2 valittu";
                        break;
                    case "button3":
                        message = "Nappi 3 valittu";
                        break;
                    case "button4":
                        message = "Nappi 4 valittu";
                        break;
                    case "button5":
                        message = "Nappi 5 valittu";
                        break;
                    default:
                        message = "Tuntematon nappi valittu";
                        break;
                }

                // Näytetään MessageBox valinnasta
                MessageBox.Show(message, "Nappi Valittu");
            }
        }


    }






}