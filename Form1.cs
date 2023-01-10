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
        //Hieronder benoemen wij gebruikte variabelen
        static int kol = 6;
        static int rij = 6;
        Stenen[,] steen;                //Dit wordt de array waar alle stenen in staan. 
        bool LegaleZet = false;
        int help, pas, beurt, BeurtenGepast = 0;


        //Hier laden wij onze beginopstelling en andere componenten op de form.
        public Form1()
        {
            steen = new Stenen[kol, rij];
            InitializeComponent();
            Beginopstelling();
            this.Speelveld.Paint += Tekenveld;
        }

        //In deze methodes worden onze speelstenen op de juiste plek op het bord gezet tezamen met de juiste grootte.
        public static double schaalx()
        {
            return 400 / kol;
        }

        public static double schaaly()
        {
            return 400 / rij;
        }

        //Deze methode maakt de beginopstelling op het speelbord.
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

        //Er wordt een nieuw spel aangemaakt, door op de knop 'nieuw spel' te klikken. 
        private void NieuwSpelStarten(object sender, EventArgs e)
        {
            SpeelbordLeeg(sender, e);
        }

        //Hier worden alle stenen van het bord verwijderd en gebruikte waarden gereset.
        private void SpeelbordLeeg(object sender, EventArgs e)
        {
            Array.Clear(steen, 0, steen.Length);
            steen = new Stenen[kol, rij];
            Beginopstelling();
            Speelveld.Invalidate();
            help = 0;
            beurt = 0;
            BlauwePunten.Text = AantalBlauweStenen() + " blauwe stenen";
            RodePunten.Text = AantalRodeStenen() + " rode stenen";
            IllegaleZet.Text = "";
            SpelerBeurt.Text = "Speler 1 (blauw) is aan de beurt.";

        }

        //Met deze methode worden op het speelveld de benodigde lijnen getekend, worden stenen getekend
        //en worden de hulpcirkels getekend.
        //De benodigde lijnen worden getekend met behulp van twee for-loops.
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

            //We maken een lijst om te kijken of er nog mogelijke zetten zijn. 
            //Zodra er een getal (1, willekeurig gekozen) wordt toegevoegd, geldt er dus dat er nog een zet mogelijk is. 
            //Er wordt dus niet gepast. 
            List<int> Mogelijkheid= new List<int>();

            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < rij; j++)
                {
                    if ((steen[i, j] == null && MagZet(i, j) != false) == true)
                    {
                        Mogelijkheid.Add(1);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            //Als er geen een zet mogelijk is, zal hier de beurt naar de andere speler overgaan. 
            if (Mogelijkheid.Count == 0)
            {
                beurt++;
                Mogelijkheid.Clear();
                BeurtenGepast++;
            }

            //Hier wordt gekeken waar de hulpcirkels moeten.
            for (int i = 0; i < kol; i++)
            {
                for (int j = 0; j < rij; j++)
                {
                    if (steen[i, j] == null && help % 2 == 1 && MagZet(i, j) != false)
                    {
                        pea.Graphics.DrawEllipse(pen, i * 400 / kol + 9, j * 400 / rij + 9, 400 / kol - 18, 400 / rij - 18);
                    }
                }
            }
        }

        //Hier zijn alle mogelijke stenen om de aangeklikte steen van de speler.
        ///Hiermee wordt gekeken welke stenen van kleur moeten veranderen. 
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

        //In deze methode wordt gekeken of de stenen ingesloten zijn, en daarmee ook of de steen gezet mag worden.
        private bool MagZet(int SteenX, int SteenY)
        {
            int Zet;
            Zet = beurt % 2 == 0 ? 0 : 1;
            var Mogelijkheid = Mogelijkheden();
            //Hier wordt gekeken in alle mogelijke richtingen of er een eventuele steen geplaatst kan worden
            //door middel van een for-loop.
            //Als dit mogelijk is worden de coordinaten tot een steen gemaakt en wordt een kleur geven aan de steen.
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

        //Hier worden het aantal blauwe stenen op het bord geteld.
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

        //Hier worden het aantal rode stenen op het bord geteld.
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

        //Onderin staat wie er aan de beurt is. 
        public string WieIsAanDeBeurt()
        {
            if (beurt % 2 == 1)
                return "Speler 1 (blauw) is aan de beurt.";
            else
                return "Speler 2 (rood) is aan de beurt.";
        }

        //Als er op de help-knop wordt geklikt, zullen de hulpcirkels op het bord verschijnen.
        //Bij nog een keer klikken zullen deze hulpcirkels weer verdwijnen. 
        private void HelpKnop(object sender, EventArgs e)
        {
            help++;
            Speelveld.Invalidate();
        }

        //Hier worden de cirkels boven het speelvlak getekend.
        //Deze dienen slechts als decoratie en worden niet interactief gebruikt.
        private void ScoreCirkels(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.RoyalBlue, 5, 5, 50, 50);
            e.Graphics.FillEllipse(Brushes.DarkRed, 5, 60, 50, 50);
        }

        //Hieronder wordt de combobox die in onze applicatie "grootteveld" heet, toegepast. Door middel van switch cases
        // worden de verschillende grotes aan variabelen toegekend. 
        private void GrootteVeld_SelectedIndexChanged(object sender, EventArgs e)
        {
            string woord = GrootteVeld.Text;
            switch (woord)
            {
                case "4 bij 4":
                    kol = 4;
                    rij = 4;
                    break;
                case "6 bij 6":
                    kol = 6;
                    rij = 6;
                    break;
                case "8 bij 8":
                    kol = 8;
                    rij = 8;
                    break;
                case "10 bij 10":
                    kol = 10;
                    rij = 10;
                    break;
            }
            //Het speelbord wordt na het kiezen van de veldgrootte natuurlijk leeg gemaakt.
            SpeelbordLeeg(sender, e);
        }

        //Deze methode verandert de kleur van de stenen.
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
                        //In dit stuk kijkt het programma wie er aan de beurt is, zodat de stenen naar de goede kleur kunnen veranderen.
                        //Er wordt hier ook gekeken hoeveel stenen er moeten veranderen.
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

        //In deze methode wordt de steen gezet door middel van een muisklik.
        //Eerst wordt er door middel van twee for-loops gekeken waar er wordt geklikt,
        //en deze worden later gematched met de steen array.
        private void ZetSteen(object sender, MouseEventArgs mea)
        {
            int muiscoordx = mea.X;
            int muiscoordy = mea.Y;
            int SteenX = 0;
            int SteenY = 0;
            for (int i = kol; muiscoordx < i * Speelveld.Width / kol; i--)
            {
                SteenX = i - 1;
            }
            for (int j = rij; muiscoordy < j * Speelveld.Height / rij; j--)
            {
                SteenY = j - 1;
            }

            if (steen[SteenX, SteenY] == null && MagZet(SteenX, SteenY) == true)
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

                //In dit deel van de methode worden de teksten aangepast die corresponderen met het aantal
                //blauwe en rode stenen boven het speelveld.
                //Ook worden hier de teksten over de beurten en de teksten over de eindstand aangepast.
                if (AantalBlauweStenen() == 1)
                    BlauwePunten.Text = $"{AantalBlauweStenen()} steen";
                else
                    BlauwePunten.Text = $"{AantalBlauweStenen()} stenen";

                if (AantalRodeStenen() == 1)
                    RodePunten.Text = $"{AantalRodeStenen()} steen";
                else
                    RodePunten.Text = $"{AantalRodeStenen()} stenen";
                Speelveld.Invalidate();
                SpelerBeurt.Text = $"{WieIsAanDeBeurt()}";
                IllegaleZet.Text = "";

                if (beurt == BeurtenGepast + kol * rij - 5)
                {
                    if (AantalBlauweStenen() > AantalRodeStenen())
                        SpelerBeurt.Text = "Speler 1 (blauw) heeft gewonnen!";
                    if (AantalRodeStenen() > AantalBlauweStenen())
                        SpelerBeurt.Text = "Speler 2 (rood) heeft gewonnen!";
                    else
                        SpelerBeurt.Text = "Remise";
                }

                beurt++;
            }
            //Als de zet niet mogelijk is komt boven het speelveld deze tekst tevoorschijn.
            else
            {
                IllegaleZet.Text = "Deze zet is illegaal!";
            }
        }
    }
}
