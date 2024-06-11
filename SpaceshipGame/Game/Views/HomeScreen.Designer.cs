namespace SpaceshipGame
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            Btn_Help = new Button();
            Btn_Jogar = new Button();
            Asteroid1 = new PictureBox();
            Asteroid3 = new PictureBox();
            Asteroid5 = new PictureBox();
            Spaceship = new PictureBox();
            Asteroid2 = new PictureBox();
            Asteroid4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Asteroid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Spaceship).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid4).BeginInit();
            SuspendLayout();
            // 
            // Btn_Help
            // 
            Btn_Help.BackColor = Color.Black;
            Btn_Help.FlatStyle = FlatStyle.Flat;
            Btn_Help.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Help.ForeColor = Color.White;
            Btn_Help.Location = new Point(187, 386);
            Btn_Help.Name = "Btn_Help";
            Btn_Help.Size = new Size(127, 33);
            Btn_Help.TabIndex = 0;
            Btn_Help.Text = "Como Jogar";
            Btn_Help.UseVisualStyleBackColor = false;
            Btn_Help.Click += Btn_Help_Click;
            // 
            // Btn_Jogar
            // 
            Btn_Jogar.BackColor = Color.Black;
            Btn_Jogar.FlatStyle = FlatStyle.Flat;
            Btn_Jogar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Jogar.ForeColor = Color.White;
            Btn_Jogar.Location = new Point(187, 347);
            Btn_Jogar.Name = "Btn_Jogar";
            Btn_Jogar.Size = new Size(127, 33);
            Btn_Jogar.TabIndex = 1;
            Btn_Jogar.Text = "Jogar";
            Btn_Jogar.UseVisualStyleBackColor = false;
            Btn_Jogar.Click += Btn_Jogar_Click;
            // 
            // Asteroid1
            // 
            Asteroid1.BackColor = Color.Transparent;
            Asteroid1.Image = (Image)resources.GetObject("Asteroid1.Image");
            Asteroid1.Location = new Point(35, 12);
            Asteroid1.Name = "Asteroid1";
            Asteroid1.Size = new Size(95, 91);
            Asteroid1.TabIndex = 2;
            Asteroid1.TabStop = false;
            // 
            // Asteroid3
            // 
            Asteroid3.BackColor = Color.Transparent;
            Asteroid3.Image = (Image)resources.GetObject("Asteroid3.Image");
            Asteroid3.Location = new Point(202, 41);
            Asteroid3.Name = "Asteroid3";
            Asteroid3.Size = new Size(95, 91);
            Asteroid3.TabIndex = 3;
            Asteroid3.TabStop = false;
            // 
            // Asteroid5
            // 
            Asteroid5.BackColor = Color.Transparent;
            Asteroid5.Image = (Image)resources.GetObject("Asteroid5.Image");
            Asteroid5.Location = new Point(357, 12);
            Asteroid5.Name = "Asteroid5";
            Asteroid5.Size = new Size(95, 91);
            Asteroid5.TabIndex = 4;
            Asteroid5.TabStop = false;
            // 
            // Spaceship
            // 
            Spaceship.BackColor = Color.Transparent;
            Spaceship.Image = (Image)resources.GetObject("Spaceship.Image");
            Spaceship.Location = new Point(202, 202);
            Spaceship.Name = "Spaceship";
            Spaceship.Size = new Size(95, 91);
            Spaceship.TabIndex = 5;
            Spaceship.TabStop = false;
            // 
            // Asteroid2
            // 
            Asteroid2.BackColor = Color.Transparent;
            Asteroid2.Image = (Image)resources.GetObject("Asteroid2.Image");
            Asteroid2.Location = new Point(74, 124);
            Asteroid2.Name = "Asteroid2";
            Asteroid2.Size = new Size(95, 91);
            Asteroid2.TabIndex = 6;
            Asteroid2.TabStop = false;
            // 
            // Asteroid4
            // 
            Asteroid4.BackColor = Color.Transparent;
            Asteroid4.Image = (Image)resources.GetObject("Asteroid4.Image");
            Asteroid4.Location = new Point(331, 124);
            Asteroid4.Name = "Asteroid4";
            Asteroid4.Size = new Size(95, 91);
            Asteroid4.TabIndex = 7;
            Asteroid4.TabStop = false;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(484, 461);
            Controls.Add(Asteroid4);
            Controls.Add(Asteroid2);
            Controls.Add(Spaceship);
            Controls.Add(Asteroid5);
            Controls.Add(Asteroid3);
            Controls.Add(Asteroid1);
            Controls.Add(Btn_Jogar);
            Controls.Add(Btn_Help);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spaceship Game";
            ((System.ComponentModel.ISupportInitialize)Asteroid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Spaceship).EndInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Help;
        private Button Btn_Jogar;
        private PictureBox Asteroid1;
        private PictureBox Asteroid3;
        private PictureBox Asteroid5;
        private PictureBox Spaceship;
        private PictureBox Asteroid2;
        private PictureBox Asteroid4;
    }
}
