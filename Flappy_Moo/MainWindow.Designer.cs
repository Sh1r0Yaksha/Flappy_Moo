namespace Flappy_Moo
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.cow = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.shir0Label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.cow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(217, 66);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score: ";
            // 
            // cow
            // 
            this.cow.Image = global::Flappy_Moo.Properties.Resources.Right;
            this.cow.Location = new System.Drawing.Point(66, 273);
            this.cow.Name = "cow";
            this.cow.Size = new System.Drawing.Size(150, 112);
            this.cow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cow.TabIndex = 1;
            this.cow.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Moo.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-12, 608);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1148, 210);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pipeUp
            // 
            this.pipeUp.Image = global::Flappy_Moo.Properties.Resources.pipe;
            this.pipeUp.Location = new System.Drawing.Point(410, 400);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(125, 212);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 4;
            this.pipeUp.TabStop = false;
            this.pipeUp.Tag = "pipe";
            this.pipeUp.Visible = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::Flappy_Moo.Properties.Resources.pipedown;
            this.pipeDown.Location = new System.Drawing.Point(796, -19);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(125, 266);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            this.pipeDown.Tag = "pipe";
            this.pipeDown.Visible = false;
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gameNameLabel.Location = new System.Drawing.Point(124, 92);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(836, 155);
            this.gameNameLabel.TabIndex = 5;
            this.gameNameLabel.Text = "Flappy Moo";
            // 
            // shir0Label
            // 
            this.shir0Label.AutoSize = true;
            this.shir0Label.Font = new System.Drawing.Font("Snap ITC", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.shir0Label.Location = new System.Drawing.Point(241, 247);
            this.shir0Label.Name = "shir0Label";
            this.shir0Label.Size = new System.Drawing.Size(783, 103);
            this.shir0Label.TabIndex = 6;
            this.shir0Label.Text = "By Shir0Yaksha";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1038, 683);
            this.Controls.Add(this.shir0Label);
            this.Controls.Add(this.gameNameLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.cow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Flappy Moo";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space_keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.space_keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.cow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label scoreLabel;
        private PictureBox cow;
        private PictureBox ground;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox pipeUp;
        private PictureBox pipeDown;
        private Label gameNameLabel;
        private Label shir0Label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}