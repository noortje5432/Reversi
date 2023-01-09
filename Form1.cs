using System;
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
        public Form1()
        {
            InitializeComponent();
            this.Speelveld.Paint += Tekenveld;
        }

        int grootte = 6;
       // PictureBox[,] P;
        int kol = 6;
        int rij = 6;

        private void Form1_Load(object sender, EventArgs e)
        {
           /* P = new PictureBox[grootte, grootte];
            int links, top = 2;
            for (int x = 0; x < grootte; x++) 
            {
                links = 2;
                for (int y = 0; y < grootte; y++) 
                {
                    P[x, y] = new PictureBox();
                    P[x, y].BackColor = Color.FromArgb(255, 245, 152);
                    P[x, y].Location = new Point(links, top);
                    P[x, y].Size = new Size(55, 55);
                    links += 60; 
                    Speelveld.Controls.Add(P[x, y]);
                }
                top += 60;
            }
            P[0, 0].BackColor = Color.Black; */
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
