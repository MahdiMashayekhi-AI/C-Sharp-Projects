namespace FlappyBird
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
            this.picGround = new System.Windows.Forms.PictureBox();
            this.picFlappy = new System.Windows.Forms.PictureBox();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.picDown = new System.Windows.Forms.PictureBox();
            this.lblTextScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picGround2 = new System.Windows.Forms.PictureBox();
            this.picGround1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround1)).BeginInit();
            this.SuspendLayout();
            // 
            // picGround
            // 
            this.picGround.Image = global::FlappyBird.Properties.Resources.ground;
            this.picGround.Location = new System.Drawing.Point(-2, 249);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(292, 124);
            this.picGround.TabIndex = 0;
            this.picGround.TabStop = false;
            // 
            // picFlappy
            // 
            this.picFlappy.Image = global::FlappyBird.Properties.Resources.bird;
            this.picFlappy.Location = new System.Drawing.Point(111, 113);
            this.picFlappy.Name = "picFlappy";
            this.picFlappy.Size = new System.Drawing.Size(42, 34);
            this.picFlappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFlappy.TabIndex = 1;
            this.picFlappy.TabStop = false;
            // 
            // picTop
            // 
            this.picTop.Image = global::FlappyBird.Properties.Resources.pipe;
            this.picTop.Location = new System.Drawing.Point(460, -7);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(32, 117);
            this.picTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTop.TabIndex = 2;
            this.picTop.TabStop = false;
            // 
            // picDown
            // 
            this.picDown.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.picDown.Location = new System.Drawing.Point(326, 142);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(32, 122);
            this.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDown.TabIndex = 2;
            this.picDown.TabStop = false;
            // 
            // lblTextScore
            // 
            this.lblTextScore.AutoSize = true;
            this.lblTextScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextScore.Location = new System.Drawing.Point(12, 9);
            this.lblTextScore.Name = "lblTextScore";
            this.lblTextScore.Size = new System.Drawing.Size(70, 24);
            this.lblTextScore.TabIndex = 3;
            this.lblTextScore.Text = "Score: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(107, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(20, 24);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picGround2
            // 
            this.picGround2.Image = global::FlappyBird.Properties.Resources.ground;
            this.picGround2.Location = new System.Drawing.Point(576, 249);
            this.picGround2.Name = "picGround2";
            this.picGround2.Size = new System.Drawing.Size(292, 124);
            this.picGround2.TabIndex = 0;
            this.picGround2.TabStop = false;
            // 
            // picGround1
            // 
            this.picGround1.Image = global::FlappyBird.Properties.Resources.ground;
            this.picGround1.Location = new System.Drawing.Point(287, 249);
            this.picGround1.Name = "picGround1";
            this.picGround1.Size = new System.Drawing.Size(292, 124);
            this.picGround1.TabIndex = 0;
            this.picGround1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(651, 332);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTextScore);
            this.Controls.Add(this.picTop);
            this.Controls.Add(this.picFlappy);
            this.Controls.Add(this.picGround1);
            this.Controls.Add(this.picGround2);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFlappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.PictureBox picDown;
        private System.Windows.Forms.Label lblTextScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picFlappy;
        private System.Windows.Forms.PictureBox picGround2;
        private System.Windows.Forms.PictureBox picGround1;
    }
}

