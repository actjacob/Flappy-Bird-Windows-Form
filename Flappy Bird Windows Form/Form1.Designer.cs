namespace Flappy_Bird_Windows_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flappyBird = new PictureBox();
            pipeBottom = new PictureBox();
            ground = new PictureBox();
            pipeTop = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.bird;
            flappyBird.Location = new Point(135, 362);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(89, 75);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            flappyBird.Click += pictureBox1_Click;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipe;
            pipeBottom.Location = new Point(379, 521);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(153, 225);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 1;
            pipeBottom.TabStop = false;
            pipeBottom.Click += pictureBox2_Click;
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-1, 711);
            ground.Name = "ground";
            ground.Size = new Size(1847, 218);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 2;
            ground.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(379, -49);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(153, 257);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 3;
            pipeTop.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.PapayaWhip;
            scoreText.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(165, 750);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(170, 40);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            scoreText.Click += label1_Click;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(1837, 726);
            Controls.Add(scoreText);
            Controls.Add(flappyBird);
            Controls.Add(pipeTop);
            Controls.Add(ground);
            Controls.Add(pipeBottom);
            Name = "Form1";
            Text = "               ";
            Load += Form1_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox pipeBottom;
        private PictureBox ground;
        private PictureBox pipeTop;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
