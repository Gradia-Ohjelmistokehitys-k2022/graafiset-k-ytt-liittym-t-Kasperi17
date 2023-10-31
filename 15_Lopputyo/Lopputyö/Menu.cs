using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Lopputyö
{
    public partial class Menu : Form
    {   
        public static Menu instance;
        List<int> kayttaja = new List<int>();
        private SoundPlayer musa;
        private SoundPlayer musa2;
        public Menu()
        {
            musiikki();
            InitializeComponent();
            instance = this;
            musa = new SoundPlayer(Lopputyö.Properties.Resources.Ketsa___Firstly);

        }
        public void musiikki()
        {
            SoundPlayer musa = new SoundPlayer(Lopputyö.Properties.Resources.Ketsa___Firstly);
            musa.Play();

        }
       

        private void miinusbutton1_Click(object sender, EventArgs e)
        {
            
            Miinuslasku form = new Miinuslasku();
            this.Hide();
            form.Show();
            musa.Stop();

        }

        private void kertobutton2_Click(object sender, EventArgs e)
        {
            Kertolasku form = new Kertolasku();
            this.Hide();
            form.Show();
        }

        private void plusbutton3_Click(object sender, EventArgs e)
        {
            Pluslasku form = new Pluslasku();
            this.Hide();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string loggedInUser = Environment.UserName;


            label2.Text = "Kirjautunut käyttäjä:\n" + loggedInUser;
        }

        private void tallennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void musiikki1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer musa = new SoundPlayer(Lopputyö.Properties.Resources.Ketsa___Firstly);
            musa.Play();
            musa2.Stop();
        }

        private void musiikka2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musa.Stop();
            SoundPlayer musa2 = new SoundPlayer(Lopputyö.Properties.Resources.in_the_cafe_with_coffee_after_lunch_140_173156);
            musa2.Play();
        }
    }
}
