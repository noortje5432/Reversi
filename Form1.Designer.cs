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
            this.buttonHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNieuwSpel = new System.Windows.Forms.Button();
            this.BordGrootte = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(403, 17);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(111, 22);
            this.buttonHelp.TabIndex = 0;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(102, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // buttonNieuwSpel
            // 
            this.buttonNieuwSpel.Location = new System.Drawing.Point(403, 43);
            this.buttonNieuwSpel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNieuwSpel.Name = "buttonNieuwSpel";
            this.buttonNieuwSpel.Size = new System.Drawing.Size(110, 22);
            this.buttonNieuwSpel.TabIndex = 2;
            this.buttonNieuwSpel.Text = "Nieuw Spel";
            this.buttonNieuwSpel.UseVisualStyleBackColor = true;
            this.buttonNieuwSpel.Click += new System.EventHandler(this.buttonNieuwSpel_Click);
            // 
            // BordGrootte
            // 
            this.BordGrootte.BackColor = System.Drawing.Color.White;
            this.BordGrootte.FormattingEnabled = true;
            this.BordGrootte.Location = new System.Drawing.Point(403, 70);
            this.BordGrootte.Name = "BordGrootte";
            this.BordGrootte.Size = new System.Drawing.Size(109, 23);
            this.BordGrootte.TabIndex = 3;
            this.BordGrootte.Text = "Bord Grootte";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 106);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(524, 436);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BordGrootte);
            this.Controls.Add(this.buttonNieuwSpel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonHelp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNieuwSpel;
        private System.Windows.Forms.ComboBox BordGrootte;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}