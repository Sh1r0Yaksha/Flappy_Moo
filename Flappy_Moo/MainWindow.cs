using System.Media;

namespace Flappy_Moo
{
    public partial class MainWindow : Form
    {

        int pipeSpeed = 10;
        int gravity = 10;
        int score = 0;

        int prevScore = 0;

        int pipeCounterForScore = 0;
        bool hasJumped = false;
        bool gameStarted = false;
        bool gameOver = false;
        bool soundPlaying = false;
        int jumpCounter = 0;
        int pipeDownSpawnCounter = 0;
        int pipeUpSpawnCounter = 0;
        Random rand = new Random();
        List<PictureBox> pipes = new List<PictureBox>();
        List<int> removeIndex = new List<int>();

        int randomForPipes;

        SoundPlayer moo = new SoundPlayer(Properties.Resources.Cow_moo);
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                Cow_Update();
                Collision_Detect();
                Pipe_Update();
                scoreLabel.Text = "Score: " + score.ToString();
            }

            if (score > prevScore + 100)
            {
                if (randomForPipes <= 20)
                {
                    randomForPipes += rand.Next(10);
                }
                if (randomForPipes > 20)
                    randomForPipes -= 10;

                
                prevScore = score;
                pipeSpeed += 5;
            }

        }

        private void space_keyDown(object sender, KeyEventArgs e)
        {
            if (!gameStarted)
            {
                GC.Collect();
                score = 0;
                gameStarted = true;
                pipes.Clear();
                removeIndex.Clear();
                gameNameLabel.Visible = false;
                shir0Label.Visible = false;
            }

            if (gameOver)
            {
                gameOver = false;
                gameStarted = false;

                while (Controls.Count > 0)
                {
                    Controls[0].Dispose();
                }
                InitializeComponent();
                
            }

            if (e.KeyCode == Keys.Space && !hasJumped) 
            {

                moo.Play();
                jumpCounter = 0;
                hasJumped = true;
            }
        }

        private void space_keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                hasJumped = false;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            gameStarted = false;
            moo.Play(); 
            randomForPipes = rand.Next(10, 30);
        }

        private void Cow_Update()
        {
            cow.Top += gravity;


            if (jumpCounter < 5)
            {
                cow.Image = Properties.Resources.Right_Up;
                gravity = -15;
            }
            else if (jumpCounter > 10)
            {
                cow.Image = Properties.Resources.Right_Down; ;
                gravity = 5;
            }
            else
            {
                cow.Image = Properties.Resources.Right;
                gravity = 5;
            }
            jumpCounter++;
        }

        private void Pipe_Update()
        {


            if (pipeDownSpawnCounter > randomForPipes)
            {

                PictureBox tempPipeDown = new PictureBox();

                tempPipeDown.Size = new Size(pipeDown.Size.Width, rand.Next(20, pipeDown.Size.Height));
                tempPipeDown.Location = new Point(rand.Next(this.Width, this.Width + rand.Next(150)), -19);
                tempPipeDown.Image = pipeDown.Image;
                tempPipeDown.SizeMode = PictureBoxSizeMode.StretchImage;

                pipes.Add(tempPipeDown);
                this.Controls.Add(tempPipeDown);

                pipeDownSpawnCounter = 0;

                
            }

            RemovePipes();

            if (pipeUpSpawnCounter > pipeDownSpawnCounter + rand.Next(30)) 
            {
                PictureBox tempPipeUp = new PictureBox();
                tempPipeUp.Size = new Size(pipeUp.Size.Width, pipeUp.Size.Height);
                tempPipeUp.Location = new Point(rand.Next(this.Width, this.Width + rand.Next(150)),
                    rand.Next(400 , 600));
                tempPipeUp.Image = pipeUp.Image;
                tempPipeUp.SizeMode = PictureBoxSizeMode.StretchImage;

                pipes.Add(tempPipeUp);
                this.Controls.Add(tempPipeUp);

                pipeUpSpawnCounter = 0;
            }

            RemovePipes();

            pipeDownSpawnCounter++;
            pipeUpSpawnCounter++;
        }
        
        private void Collision_Detect()
        {

            Rectangle CowHitbox = new Rectangle(cow.Bounds.X + 50, cow.Bounds.Y + 50, cow.Width - 50, cow.Height - 50);

            foreach (PictureBox pipe in pipes)
            {
                if (pipe.Left < cow.Left)
                {
                    pipeCounterForScore++;
                }
                if (pipeCounterForScore >= 2)
                {
                    score++;
                    pipeCounterForScore = 0;
                }

                
                if (CowHitbox.IntersectsWith(pipe.Bounds))
                {
                    Endgame();
                }
            }

            if (CowHitbox.IntersectsWith(ground.Bounds))
            {
                Endgame();
            }
        }

        private void Endgame()
        {
            gameTimer.Stop();

            gameOver = true;
            gameNameLabel.Text = "Game Over!!";
            gameNameLabel.Location = new Point(this.Width / 2 - gameNameLabel.Width / 2, this.Height / 2 - 3 * gameNameLabel.Height / 2);
            gameNameLabel.Visible = true;
            
            
        }

        private void RemovePipes()
        {
            removeIndex.Clear();
            for (int i = 0; i < pipes.Count; i++)
            {
                pipes[i].Left -= pipeSpeed;
                if (pipes[i].Right < 0)
                {
                    removeIndex.Add(i);
                }
                
            }
            foreach (int i in removeIndex)
            {
                if (i < pipes.Count)
                {
                    pipes[i].Dispose();
                    pipes.RemoveAt(i);
                    GC.Collect();
                }
                
            }
            removeIndex.Clear();
        }
    }
}