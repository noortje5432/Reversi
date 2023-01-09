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
            this.KleurX = Form1.schaalx() * KleurX;
            this.KleurY = Form1.schaaly() * Kleur;
            this.KleurVanSteen = KleurVanDeSteen; 
        }

        public void tekenSteen(object o, PaintEventArgs pea) 
        {
            float maatx = (float)Form1.schaalx() - 10;
            float maaty = (float)Form1.schaaly() - 10;
            if (KleurVanSteen == 0)
                Kleur = Brushes.RoyalBlue;
            if (KleurVanSteen == 1)
                Kleur = Brushes.DarkRed;
            pea.Graphics.FillEllipse(Kleur, (float)KleurX + 5, (float)KleurY, maatx, maaty);
        }
    }
}
