using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Reversi_Namespace
{
    public partial class Form1 : Form
    {
        static int kol = 6;
        static int rij = 6;
        Stenen[,] steen;
        bool LegaleZet = false;
        int pas, help, beurt = 0;


        public Form1()
        {
            steen = new Stenen[kol, rij];
            InitializeComponent();
            Beginopstelling();
            this.Speelveld.Paint += Tekenveld;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static double schaalx()
        {
            return 400 / kol;
        }

        public static double schaaly()
        {
            return 400 / rij;
        }

        private void Beginopstelling()
        {
            int MiddenX = kol / 2;
            int MiddenY = rij / 2;
            steen[MiddenX, MiddenY] = new Stenen(MiddenX, MiddenY, 0);
            steen[MiddenX, MiddenY - 1] = new Stenen(MiddenX, MiddenY - 1, 1);
            steen[MiddenX - 1, MiddenY] = new Stenen(MiddenX - 1, MiddenY, 1);
            steen[MiddenX - 1, MiddenY - 1] = new Stenen(MiddenX - 1, MiddenY - 1, 0);
            steen[MiddenX - 1, MiddenY - 1] = new Stenen(MiddenX - 1, MiddenY - 1, 0);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Tekenveld(object sender, PaintEventArgs pea)
        {
            Pen pen = new Pen(Color.Black, 5);
            for (int i = 0; i < kol + 2; i++)
                pea.Graphics.DrawLine(pen, Speelveld.Width / kol * i, 0, Speelveld.Width / kol * i, Speelveld.Height);
            for (int j = 0; j < rij + 2; j++)
                pea.Graphics.DrawLine(pen, 0, Speelveld.Height / rij * j, Speelveld.Width, Speelveld.Height / rij * j);
            foreach (Stenen s in steen)
            {
                if (s != null)
                    s.tekenSteen(sender, pea);
            }

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < rij; j++)
                { 
                    if (steen[i,j] == null && help % 2 == 1 && MagZet(i, j) != false)
                    {
                        pea.Graphics.DrawEllipse(pen, i * 400 / kol + 9, j * 400 / rij + 9, 400 / kol - 18, 400 / rij - 18);
                    }
                }
            }
            
        }

        static Tuple<int[], int[]> Mogelijkheden()
        {
            int[] MogelijkheidX = new int[3];
            int[] MogelijkheidY = new int[3];

            MogelijkheidX[0] = -1;
            MogelijkheidY[0] = -1;
            MogelijkheidX[1] = 0;
            MogelijkheidY[1] = 0;
            MogelijkheidX[2] = 1;
            MogelijkheidY[2] = 1;

            return new Tuple<int[], int[]>(MogelijkheidX, MogelijkheidY);
        }

        private bool MagZet(int SteenX, int SteenY)
        {
            int Zet;
            Zet = beurt % 2 == 0 ? 0 : 1;
            var Mogelijkheid = Mogelijkheden();

            foreach (int MogelijkheidX in Mogelijkheid.Item1)
            {
                foreach (int MogelijkheidY in Mogelijkheid.Item2)
                {
                    int r = 1;
                    int t = 0;

                    for (int x = SteenX + MogelijkheidX * r, y = SteenY + MogelijkheidY * r;
                         x >= 0 && x < kol && y >= 0 && y < rij;
                         r++, x = SteenX + MogelijkheidX * r, y = SteenY + MogelijkheidY * r)
                    {
                        Stenen buurStenen = steen[x, y];
                        if (buurStenen == null)
                            break;
                        if (buurStenen.KleurVanSteen != Zet)
                            t++;
                        else
                        {
                            if (t > 0)
                                return true;
                            else
                                break;
                        }
                    }
                }
            }

            return false;
        }


        public int AantalBlauweStenen()
        {
            int AantalBlauw = 0;
            foreach (Stenen s in steen)
            {
                if (s == null)
                    continue;
                if (s.KleurVanSteen == 0)
                    AantalBlauw += 1;
            }
            return AantalBlauw;
        }

        public int AantalRodeStenen()
        {
            int AantalRood = 0;
            foreach (Stenen s in steen)
            {
                if (s == null)
                    continue;
                if (s.KleurVanSteen == 1)
                    AantalRood += 1;
            }
            return AantalRood;
        }

        public string WieIsAanDeBeurt()
        {
            if (beurt % 2 == 0)
                return "Speler 1 (blauw) is aan de beurt.";
            else
                return "Speler 2 (rood) is aan de beurt.";
        }

        public Color KleurvanSpeler()
        {
            if (beurt % 2 == 0)
                return Color.RoyalBlue;
            else
                return Color.DarkRed;
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush Speler1 = new SolidBrush(Color.RoyalBlue);
            e.Graphics.FillEllipse(Speler1, 10, 10, 100, 100);
        }

        private void HelpKnop(object sender, EventArgs e)
        {
            help++;
            Speelveld.Invalidate();
        }

        private void ScoreCirkels(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.RoyalBlue, 5, 5, 50, 50);
            e.Graphics.FillEllipse(Brushes.DarkRed, 5, 60, 50, 50);
        }

        public void Verkleuring(int SteenX, int SteenY)
        {
            var zet = beurt % 2 == 0 ? 0 : 1;
            var Mogelijkheid = Mogelijkheden();
            foreach (int MogelijkheidX in Mogelijkheid.Item1)
            {
                foreach (int MogelijkheidY in Mogelijkheid.Item2)
                {
                    int r = 1;
                    int t = 0;

                    for (int x = SteenX + MogelijkheidX * r, y = SteenY + MogelijkheidY * r;
                         x >= 0 && x < kol && y >= 0 && y < rij;
                         r++, x = SteenX + MogelijkheidX * r, y = SteenY + MogelijkheidY * r)
                    {
                        Stenen buurStenen = steen[x, y];
                        if (MogelijkheidX == 0 && MogelijkheidY == 0)
                            break;
                        if (buurStenen == null)
                            break;

                        if (zet == 0)
                        {
                            if (buurStenen.KleurVanSteen == 1)
                                t++;
                            else if (buurStenen.KleurVanSteen == 0)
                            {
                                if (t > 0)
                                {
                                    while (t > 0)
                                    {
                                        steen[SteenX + MogelijkheidX * t, SteenY + MogelijkheidY * t].KleurVanSteen = 0;
                                        t--;
                                    }
                                }
                            }
                            else
                                break;
                        }
                        if (zet == 1)
                        {
                            if (buurStenen.KleurVanSteen == 0)
                                t++;
                            else if (buurStenen.KleurVanSteen == 1)
                            {
                                if (t > 0)
                                {
                                    while (t > 0)
                                    {
                                        steen[SteenX + MogelijkheidX * t, SteenY + MogelijkheidY * t].KleurVanSteen = 1;
                                        t--;
                                    }
                                }
                            }
                            else
                                break;
                        }

                    }
                }
            }
        }

        private void ZetSteen(object sender, MouseEventArgs mea)
        {
            int muiscoordx = mea.X;
            int muiscoordy = mea.Y;
            int SteenX = 0;
            int SteenY = 0;
            for (int i = kol; muiscoordx < i * Speelveld.Width / kol; i--)
            {
                SteenX = i -1;
            }
            for (int j = rij; muiscoordy < j * Speelveld.Height / rij; j--)
            {
                SteenY = j -1;
            }

            if (steen[SteenX, SteenY] == null && MagZet(SteenX, SteenY)==true)
                LegaleZet = true;
            else
                LegaleZet = false;

            if (LegaleZet == true)
            {
                if (beurt % 2 == 0)
                {
                    steen[SteenX, SteenY] = new Stenen(SteenX, SteenY, 0);

                }
                else
                {
                    steen[SteenX, SteenY] = new Stenen(SteenX, SteenY, 1);
                }
                pas = 0;
                Verkleuring(SteenX, SteenY);
                beurt += 1;
                if (AantalBlauweStenen() == 1)
                    BlauwePunten.Text = $"{AantalBlauweStenen()} steen";
                else
                    BlauwePunten.Text = $"{AantalBlauweStenen()} stenen";
                if (AantalRodeStenen() == 1)
                    RodePunten.Text = $"{AantalRodeStenen()} steen";
                else
                    RodePunten.Text = $"{AantalRodeStenen()} stenen";
                Speelveld.Invalidate();
                //Zet.Text = beurt();
                BeurtKleur.Text = $"{WieIsAanDeBeurt()}";
                //TekstLegaleZet.Text = "";*/
            }
            /*else
            {
                TekstLegaleZet.Text = "Deze zet is illegaal!";
            }*/
        }
    }
}
