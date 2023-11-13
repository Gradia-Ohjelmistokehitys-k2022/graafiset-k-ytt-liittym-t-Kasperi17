using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lopputyö
{


    public class Hyöty
    {
        public static Random random = new Random();
        public static void TallennaParasTulos(int parasTulos, string tiedostoNimi)
        {
            try
            {
                File.WriteAllText(tiedostoNimi, parasTulos.ToString());
            }
            catch (IOException) { MessageBox.Show("Virhe tallennettaessa tulosta: "); }
            //Tallenetaan parastulos tekstitiedostoon.
        }
        public static int LataaParasTulos(string tiedostoNimi)
        {
            if (File.Exists(tiedostoNimi))
            {
                try
                {
                    string tallennettuTulos = File.ReadAllText(tiedostoNimi);
                    if (int.TryParse(tallennettuTulos, out int tulos))
                    {
                        int parasTulos = tulos;
                        return parasTulos;
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Virhe ladattaessa tulosta: ");
                }
                //ladataan paras tulos tiedostosta ja tallenetaan se parastulos muuttujaan
            }
            return 0;
        }
        public static void VaikeusTasonAsettaminen(string vaikeustaso, out int ensimmainenLuku, out int toinenLuku)
        {   ensimmainenLuku = 0; toinenLuku = 0;

            if (vaikeustaso == "Helppo")
            {
                ensimmainenLuku = random.Next(1, 10);
                toinenLuku = random.Next(1, 10);
                
            }
            else if (vaikeustaso == "Vaikea")
            {
                ensimmainenLuku = random.Next(1, 50);
                toinenLuku = random.Next(1, 50);
                
            }

        }
    }
    
}
