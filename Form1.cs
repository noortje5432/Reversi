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
        }

        int grootte;
        PictureBox[,] P;
        private void Form1_Load(object sender, EventArgs e)
        {
            grootte = 6;
            P = new PictureBox[grootte, grootte];
            int links = 2, top = 2;
            for (int x = 0; x < grootte; x++) 
            {
                links = 2;
                for (int y = 0; y < grootte; y++) 
                {
                    P[x, y] = new PictureBox();
                    Color kleur = Color.FromArgb(255, 245, 152);
                    P[x, y].BackColor = kleur;
                    P[x, y].Location = new Point(links, top);
                    P[x, y].Size = new Size(55, 55);
                    links += 60; 
                    Speelveld.Controls.Add(P[x, y]);
                }
                top += 60;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        /*private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.BackColor= Color.FromArgb(255, 245, 152);
            Pen pen= new Pen(Color.DarkGray, 2);
            e.Graphics.DrawRectangle(pen, 1, 1, 358, 358);
            e.Graphics.DrawLine(pen, 60, 0, 60, 360);
            e.Graphics.DrawLine(pen, 120, 0, 120, 360);
            e.Graphics.DrawLine(pen, 180, 0, 180, 360);
            e.Graphics.DrawLine(pen, 240, 0, 240, 360);
            e.Graphics.DrawLine(pen, 300, 0, 300, 360);
            e.Graphics.DrawLine(pen, 0, 60, 360, 60);
            e.Graphics.DrawLine(pen, 0, 120, 360, 120);
            e.Graphics.DrawLine(pen, 0, 180, 360, 180);
            e.Graphics.DrawLine(pen, 0, 240, 360, 240);
            e.Graphics.DrawLine(pen, 0, 300, 360, 300);

        }
        */
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
    }
}
