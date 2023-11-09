using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tehtävä_13
{
    public partial class Form1 : Form
    {
        
        Point piste = new Point(150, 57);
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            taustakuva = Properties.Resources.picture04;
        }
        Bitmap taustakuva;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            taustakuva.MakeTransparent();
            e.Graphics.DrawImage(taustakuva,piste);
           

        }
        

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               
                piste = e.Location;
                Invalidate();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                piste = e.Location;
                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                piste = e.Location;
                Invalidate();
            }
        }
    }
}
