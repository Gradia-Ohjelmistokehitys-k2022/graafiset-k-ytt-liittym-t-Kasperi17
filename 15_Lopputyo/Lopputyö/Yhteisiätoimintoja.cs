using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopputyö
{


    public class Hyöty
    {

        public static void TallennaParasTulos(int parasTulos, string tiedostoNimi)
        {
            try
            {
                File.WriteAllText(tiedostoNimi, parasTulos.ToString());
            }
            catch (IOException) { MessageBox.Show("Virhe tallennettaessa tulosta: "); }
            string moi = Directory.GetCurrentDirectory();

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
                
            }
            return 0;






        }
    }
    
}
