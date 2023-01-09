﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi_Namespace
{
    public partial class Form1 : Form
    {
        int grootte = 6;
        // PictureBox[,] P;
        static int kol = 6;
        static int rij = 6;
        Stenen[,] steen;
        int beurt = 0;



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
            steen[MiddenX, MiddenY] = new Stenen(MiddenX, MiddenY, -1);
            steen[MiddenX, MiddenY -1] = new Stenen(MiddenX, MiddenY - 1, 1);
            steen[MiddenX -1, MiddenY] = new Stenen(MiddenX - 1, MiddenY, 1);
            steen[MiddenX -1, MiddenY - 1] = new Stenen(MiddenX - 1, MiddenY - 1 , -1);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
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

        }

        static Tuple<int[], int[]> Mogelijkheden()
        {
            int[] MogelijkVoorX = new int[3];
            int[] MogelijkVoorY = new int[3];

            MogelijkVoorX[0] = -1;
            MogelijkVoorY[0] = -1;
            MogelijkVoorX[0] = 0;
            MogelijkVoorY[0] = 0;
            MogelijkVoorX[0] = 1;
            MogelijkVoorY[0] = 1;

            return new Tuple<int[], int[]>(MogelijkVoorX, MogelijkVoorY);
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
                    
                    for (int x = SteenX + MogelijkheidX * r, int y = SteenY + Mogelijkheid * r ; x >= 0 && x < kol && y >= 0 && y < rij; r++, x = SteenX + MogelijkheidX * r, y = SteenY + Mogelijkheid * r  )
                }
            }
        }

        private void buttonNieuwSpel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush Speler1 = new SolidBrush(Color.RoyalBlue);
            e.Graphics.FillEllipse(Speler1, 10, 10, 100, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}