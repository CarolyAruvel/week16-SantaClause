namespace SantaGame
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
            this.snowflake = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.santa = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.hut = new System.Windows.Forms.PictureBox();
            this.tree = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            this.SuspendLayout();
            // 
            // snowflake
            // 
            this.snowflake.Image = ((System.Drawing.Image)(resources.GetObject("snowflake.Image")));
            this.snowflake.Location = new System.Drawing.Point(174, 23);
            this.snowflake.Name = "snowflake";
            this.snowflake.Size = new System.Drawing.Size(108, 81);
            this.snowflake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.snowflake.TabIndex = 0;
            this.snowflake.TabStop = false;
            this.snowflake.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-8, 400);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(457, 210);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // santa
            // 
            this.santa.Image = ((System.Drawing.Image)(resources.GetObject("santa.Image")));
            this.santa.Location = new System.Drawing.Point(19, 172);
            this.santa.Name = "santa";
            this.santa.Size = new System.Drawing.Size(137, 104);
            this.santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.santa.TabIndex = 3;
            this.santa.TabStop = false;
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(315, 1);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(134, 92);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.moon.TabIndex = 4;
            this.moon.TabStop = false;
            // 
            // hut
            // 
            this.hut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hut.Image = ((System.Drawing.Image)(resources.GetObject("hut.Image")));
            this.hut.Location = new System.Drawing.Point(287, 345);
            this.hut.Name = "hut";
            this.hut.Size = new System.Drawing.Size(124, 113);
            this.hut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hut.TabIndex = 5;
            this.hut.TabStop = false;
            // 
            // tree
            // 
            this.tree.Image = ((System.Drawing.Image)(resources.GetObject("tree.Image")));
            this.tree.Location = new System.Drawing.Point(12, 345);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(100, 133);
            this.tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tree.TabIndex = 6;
            this.tree.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(135, 40);
            this.scoreLabel.TabIndex = 7;
            this.scoreLabel.Text = "score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playAgain
            // 
            this.playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgain.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.Location = new System.Drawing.Point(220, 190);
            this.playAgain.Name = "playAgain";
            this.playAgain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playAgain.Size = new System.Drawing.Size(179, 113);
            this.playAgain.TabIndex = 8;
            this.playAgain.Text = "PLAY AGAIN";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(450, 534);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.hut);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.santa);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.snowflake);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox snowflake;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox santa;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox hut;
        private System.Windows.Forms.PictureBox tree;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button playAgain;
    }
}

