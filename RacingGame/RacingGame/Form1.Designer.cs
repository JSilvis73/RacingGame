namespace RacingGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.carBox = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.Label();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.Coin4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(174, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(174, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 108);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(174, 328);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 105);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(174, 475);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 111);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Location = new System.Drawing.Point(3, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 445);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Location = new System.Drawing.Point(365, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 445);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // carBox
            // 
            this.carBox.Image = ((System.Drawing.Image)(resources.GetObject("carBox.Image")));
            this.carBox.Location = new System.Drawing.Point(64, 328);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(52, 82);
            this.carBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carBox.TabIndex = 6;
            this.carBox.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(19, 142);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(52, 82);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 7;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(205, 21);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(52, 82);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 8;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(307, 206);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(52, 82);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 9;
            this.enemy3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Coins = 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOver.ForeColor = System.Drawing.Color.Red;
            this.GameOver.Location = new System.Drawing.Point(66, 176);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(235, 48);
            this.GameOver.TabIndex = 11;
            this.GameOver.Text = "Game Over";
            this.GameOver.Click += new System.EventHandler(this.label2_Click);
            // 
            // Coin1
            // 
            this.Coin1.Image = ((System.Drawing.Image)(resources.GetObject("Coin1.Image")));
            this.Coin1.Location = new System.Drawing.Point(81, 69);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(35, 34);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 12;
            this.Coin1.TabStop = false;
            // 
            // Coin2
            // 
            this.Coin2.Image = ((System.Drawing.Image)(resources.GetObject("Coin2.Image")));
            this.Coin2.Location = new System.Drawing.Point(289, 109);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(35, 34);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin2.TabIndex = 13;
            this.Coin2.TabStop = false;
            // 
            // Coin3
            // 
            this.Coin3.Image = ((System.Drawing.Image)(resources.GetObject("Coin3.Image")));
            this.Coin3.Location = new System.Drawing.Point(99, 238);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(35, 34);
            this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin3.TabIndex = 14;
            this.Coin3.TabStop = false;
            // 
            // Coin4
            // 
            this.Coin4.Image = ((System.Drawing.Image)(resources.GetObject("Coin4.Image")));
            this.Coin4.Location = new System.Drawing.Point(253, 318);
            this.Coin4.Name = "Coin4";
            this.Coin4.Size = new System.Drawing.Size(35, 34);
            this.Coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin4.TabIndex = 15;
            this.Coin4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(378, 423);
            this.Controls.Add(this.Coin4);
            this.Controls.Add(this.Coin3);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.carBox);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox carBox;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.PictureBox Coin4;
    }
}

