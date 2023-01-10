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
            this.Help.Click += new System.EventHandler(this.button2_Click);
            // 
            // GrootteVeld
            // 
            this.GrootteVeld.FormattingEnabled = true;
            this.GrootteVeld.Items.AddRange(new object[] {
            "4 bij 4",
            "6 bij 6",
            "8 bij 8"});
            this.GrootteVeld.Location = new System.Drawing.Point(355, 77);
            this.GrootteVeld.Margin = new System.Windows.Forms.Padding(4);
            this.GrootteVeld.Name = "GrootteVeld";
            this.GrootteVeld.Size = new System.Drawing.Size(133, 23);
            this.GrootteVeld.TabIndex = 3;
            this.GrootteVeld.Text = "Grootte veld";
            // 
            // Speelveld
            // 
            this.Speelveld.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Speelveld.Location = new System.Drawing.Point(55, 130);
            this.Speelveld.Margin = new System.Windows.Forms.Padding(4);
            this.Speelveld.Name = "Speelveld";
            this.Speelveld.Size = new System.Drawing.Size(400, 400);
            this.Speelveld.TabIndex = 4;
            this.Speelveld.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ZetSteen);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(541, 554);
            this.Controls.Add(this.Speelveld);
            this.Controls.Add(this.GrootteVeld);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.NieuwSpel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NieuwSpel;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.ComboBox GrootteVeld;
        private System.Windows.Forms.Panel Speelveld;
    }
}