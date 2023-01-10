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
        public int KleurVanSteen;
        double MiddenX, MiddenY; 
        
        public Stenen(double MiddenX, double MiddenY, int KleurVanDeSteen)
        {
            this.MiddenX = Form1.schaalx() * MiddenX;
            this.MiddenY = Form1.schaaly() * MiddenY;
            this.KleurVanSteen = KleurVanDeSteen; 
        }

        public void tekenSteen(object o, PaintEventArgs pea) 
        {
            float maatx = (float)Form1.schaalx() - 10;
            float maaty = (float)Form1.schaaly() - 10;
            if (KleurVanSteen == 0)
                pea.Graphics.FillEllipse(Brushes.RoyalBlue, (float)MiddenX + 5, (float)MiddenY + 5, maatx, maaty);
            if (KleurVanSteen == 1)
                pea.Graphics.FillEllipse(Brushes.DarkRed, (float)MiddenX + 5, (float)MiddenY + 5, maatx, maaty);

        }
    }
}
