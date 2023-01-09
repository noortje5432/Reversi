using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi_Namespace
{
    class Stenen
    {
        Brush Kleur;
        public int KleurVanSteen;
        double KleurX, KleurY; 
        
        public Stenen(double KleurX, double KleurY, int KleurVanDeSteen)
        {
            this.KleurX = this.zoomx() * KleurX;
            this.KleurY = this.zoomy() * Kleur;
            this.KleurVanDeSteen = KleurVanDeSteen; 
        }

        public void tekenSteen(object o, PaintEventArgs pea) 
        {
            float maatx = (float)Scherm.zoomx() - 10;
            float maaty = (float)Scherm.zoomy() - 10;
            if (kleurSteen == 0)
                Kleur = Brushes.RoyalBlue;
            if (kleursteen == 1)
                Kleur = Brushes.Red;
            pea.Graphics.FillEllipse(Kleur, (float)KleurX + 5, (float)KleurY, maatx, maaty);
        }
    }
}
