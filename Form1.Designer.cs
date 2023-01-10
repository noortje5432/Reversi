using System.Drawing;

namespace Reversi_Namespace
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NieuwSpel = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.GrootteVeld = new System.Windows.Forms.ComboBox();
            this.Speelveld = new System.Windows.Forms.Panel();
            this.Winnaar = new System.Windows.Forms.Label();
            this.Stand = new System.Windows.Forms.PictureBox();
            this.BlauwePunten = new System.Windows.Forms.Label();
            this.RodePunten = new System.Windows.Forms.Label();
            this.SpelerBeurt = new System.Windows.Forms.Label();
            this.IllegaleZet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Stand)).BeginInit();
            this.SuspendLayout();
            // 
            // NieuwSpel
            // 
            this.NieuwSpel.Location = new System.Drawing.Point(355, 6);
            this.NieuwSpel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NieuwSpel.Name = "NieuwSpel";
            this.NieuwSpel.Size = new System.Drawing.Size(95, 32);
            this.NieuwSpel.TabIndex = 0;
            this.NieuwSpel.Text = "Nieuw Spel";
            this.NieuwSpel.UseVisualStyleBackColor = true;
            this.NieuwSpel.Click += new System.EventHandler(this.button1_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(355, 40);
            this.Help.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(95, 32);
            this.Help.TabIndex = 2;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.HelpKnop);
            // 
            // GrootteVeld
            // 
            this.GrootteVeld.FormattingEnabled = true;
            this.GrootteVeld.Items.AddRange(new object[] {
            "4 bij 4",
            "6 bij 6",
            "8 bij 8",
            "10 bij 10"});
            this.GrootteVeld.Location = new System.Drawing.Point(355, 77);
            this.GrootteVeld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrootteVeld.Name = "GrootteVeld";
            this.GrootteVeld.Size = new System.Drawing.Size(133, 23);
            this.GrootteVeld.TabIndex = 3;
            this.GrootteVeld.Text = "Grootte veld";
            this.GrootteVeld.SelectedIndexChanged += new System.EventHandler(this.GrootteVeld_SelectedIndexChanged);
            // 
            // Speelveld
            // 
            this.Speelveld.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Speelveld.Location = new System.Drawing.Point(55, 130);
            this.Speelveld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Speelveld.Name = "Speelveld";
            this.Speelveld.Size = new System.Drawing.Size(350, 300);
            this.Speelveld.TabIndex = 4;
            this.Speelveld.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ZetSteen);
            // 
            // Winnaar
            // 
            this.Winnaar.AutoSize = true;
            this.Winnaar.BackColor = System.Drawing.Color.Transparent;
            this.Winnaar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Winnaar.Location = new System.Drawing.Point(63, 8);
            this.Winnaar.Name = "Winnaar";
            this.Winnaar.Size = new System.Drawing.Size(12, 18);
            this.Winnaar.TabIndex = 10;
            this.Winnaar.Text = " ";
            // 
            // Stand
            // 
            this.Stand.Location = new System.Drawing.Point(55, 25);
            this.Stand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Stand.Name = "Stand";
            this.Stand.Size = new System.Drawing.Size(109, 92);
            this.Stand.TabIndex = 5;
            this.Stand.TabStop = false;
            this.Stand.Paint += new System.Windows.Forms.PaintEventHandler(this.ScoreCirkels);
            // 
            // BlauwePunten
            // 
            this.BlauwePunten.AutoSize = true;
            this.BlauwePunten.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BlauwePunten.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BlauwePunten.Location = new System.Drawing.Point(108, 34);
            this.BlauwePunten.Name = "BlauwePunten";
            this.BlauwePunten.Size = new System.Drawing.Size(119, 32);
            this.BlauwePunten.TabIndex = 6;
            this.BlauwePunten.Text = "2 stenen";
            // 
            // RodePunten
            // 
            this.RodePunten.AutoSize = true;
            this.RodePunten.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RodePunten.ForeColor = System.Drawing.Color.DarkRed;
            this.RodePunten.Location = new System.Drawing.Point(108, 79);
            this.RodePunten.Name = "RodePunten";
            this.RodePunten.Size = new System.Drawing.Size(119, 32);
            this.RodePunten.TabIndex = 7;
            this.RodePunten.Text = "2 stenen";
            // 
            // SpelerBeurt
            // 
            this.SpelerBeurt.AutoSize = true;
            this.SpelerBeurt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SpelerBeurt.Location = new System.Drawing.Point(55, 434);
            this.SpelerBeurt.Name = "SpelerBeurt";
            this.SpelerBeurt.Size = new System.Drawing.Size(232, 18);
            this.SpelerBeurt.TabIndex = 8;
            this.SpelerBeurt.Text = "Speler 1 (blauw) is aan de beurt.";
            // 
            // IllegaleZet
            // 
            this.IllegaleZet.AutoSize = true;
            this.IllegaleZet.Location = new System.Drawing.Point(63, 8);
            this.IllegaleZet.Name = "IllegaleZet";
            this.IllegaleZet.Size = new System.Drawing.Size(10, 15);
            this.IllegaleZet.TabIndex = 9;
            this.IllegaleZet.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(541, 554);
            this.Controls.Add(this.Winnaar);
            this.Controls.Add(this.IllegaleZet);
            this.Controls.Add(this.SpelerBeurt);
            this.Controls.Add(this.RodePunten);
            this.Controls.Add(this.BlauwePunten);
            this.Controls.Add(this.Stand);
            this.Controls.Add(this.Speelveld);
            this.Controls.Add(this.GrootteVeld);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.NieuwSpel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Stand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NieuwSpel;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.ComboBox GrootteVeld;
        private System.Windows.Forms.Panel Speelveld;
        private System.Windows.Forms.PictureBox Stand;
        private System.Windows.Forms.Label RodePunten;
        private System.Windows.Forms.Label BlauwePunten;
        private System.Windows.Forms.Label SpelerBeurt;
        private System.Windows.Forms.Label IllegaleZet;
        private System.Windows.Forms.Label Winnaar;
    }
}