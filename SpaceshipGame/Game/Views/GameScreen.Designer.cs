namespace SpaceshipGame.Game.Views
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            Inf_score = new Label();
            Asteroide = new PictureBox();
            Nave = new PictureBox();
            Count_Collision = new Label();
            Count_Asteroids = new Label();
            Score = new Label();
            ((System.ComponentModel.ISupportInitialize)Asteroide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Nave).BeginInit();
            SuspendLayout();
            // 
            // Inf_score
            // 
            Inf_score.AutoSize = true;
            Inf_score.BackColor = Color.DarkBlue;
            Inf_score.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Inf_score.ForeColor = Color.Yellow;
            Inf_score.Location = new Point(200, 9);
            Inf_score.Name = "Inf_score";
            Inf_score.Size = new Size(77, 22);
            Inf_score.TabIndex = 0;
            Inf_score.Text = "Score: ";
            // 
            // Asteroide
            // 
            Asteroide.BackColor = Color.DarkBlue;
            Asteroide.Image = (Image)resources.GetObject("Asteroide.Image");
            Asteroide.Location = new Point(437, -1);
            Asteroide.Name = "Asteroide";
            Asteroide.Size = new Size(49, 50);
            Asteroide.TabIndex = 1;
            Asteroide.TabStop = false;
            // 
            // Nave
            // 
            Nave.BackColor = Color.DarkBlue;
            Nave.Image = (Image)resources.GetObject("Nave.Image");
            Nave.Location = new Point(-1, -1);
            Nave.Name = "Nave";
            Nave.Size = new Size(49, 50);
            Nave.TabIndex = 2;
            Nave.TabStop = false;
            // 
            // Count_Collision
            // 
            Count_Collision.BackColor = Color.DarkBlue;
            Count_Collision.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Count_Collision.ForeColor = Color.Yellow;
            Count_Collision.Location = new Point(-1, 44);
            Count_Collision.Name = "Count_Collision";
            Count_Collision.Size = new Size(49, 32);
            Count_Collision.TabIndex = 3;
            Count_Collision.Text = "0";
            Count_Collision.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Count_Asteroids
            // 
            Count_Asteroids.BackColor = Color.DarkBlue;
            Count_Asteroids.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Count_Asteroids.ForeColor = Color.Yellow;
            Count_Asteroids.Location = new Point(437, 44);
            Count_Asteroids.Name = "Count_Asteroids";
            Count_Asteroids.Size = new Size(49, 32);
            Count_Asteroids.TabIndex = 4;
            Count_Asteroids.Text = "0";
            Count_Asteroids.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Score
            // 
            Score.AutoSize = true;
            Score.BackColor = Color.DarkBlue;
            Score.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Score.ForeColor = Color.Yellow;
            Score.Location = new Point(266, 9);
            Score.Name = "Score";
            Score.Size = new Size(0, 22);
            Score.TabIndex = 5;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(484, 461);
            Controls.Add(Score);
            Controls.Add(Count_Asteroids);
            Controls.Add(Count_Collision);
            Controls.Add(Nave);
            Controls.Add(Asteroide);
            Controls.Add(Inf_score);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GameScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spaceship Game";
            ((System.ComponentModel.ISupportInitialize)Asteroide).EndInit();
            ((System.ComponentModel.ISupportInitialize)Nave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Inf_score;
        private PictureBox Asteroide;
        private PictureBox Nave;
        private Label Count_Collision;
        private Label Count_Asteroids;
        private Label Score;
    }
}