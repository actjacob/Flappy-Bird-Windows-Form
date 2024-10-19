
namespace Flappy_Bird_Windows_Form
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        int pipeGap = 150;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score:" + score + "\n";       

            if(pipeBottom.Left < -50)
            {
                pipeBottom.Left = 800;
                //pipeBottom.Top = rand.Next(200, 400);
                pipeBottom.Top = this.ClientSize.Height - pipeBottom.Height;
                int randomTopHeight = rand.Next(-200, -pipeTop.Height + pipeGap);
                pipeTop.Top = randomTopHeight;
                score++;
            }
            if(pipeTop.Left < -60)
            { 
                pipeTop.Left = 800;
                pipeTop.Top = rand.Next(-300, -100);
                score++;
            }


        


            if(flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                )
            {
                endGame();
            }

            if(score > 5)
            {
                pipeSpeed = 15;
            }


        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15; 
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }


        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "Game over!!!";
        }
    }
}
