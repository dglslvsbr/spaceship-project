namespace SpaceshipGame.Game.Views
{
    partial class HelpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpScreen));
            Asteroid4 = new PictureBox();
            Asteroid2 = new PictureBox();
            Asteroid5 = new PictureBox();
            Asteroid3 = new PictureBox();
            Asteroid1 = new PictureBox();
            Btn_Voltar = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)Asteroid4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid1).BeginInit();
            SuspendLayout();
            // 
            // Asteroid4
            // 
            Asteroid4.BackColor = Color.Transparent;
            Asteroid4.Image = (Image)resources.GetObject("Asteroid4.Image");
            Asteroid4.Location = new Point(329, 122);
            Asteroid4.Name = "Asteroid4";
            Asteroid4.Size = new Size(95, 91);
            Asteroid4.TabIndex = 13;
            Asteroid4.TabStop = false;
            // 
            // Asteroid2
            // 
            Asteroid2.BackColor = Color.Transparent;
            Asteroid2.Image = (Image)resources.GetObject("Asteroid2.Image");
            Asteroid2.Location = new Point(72, 122);
            Asteroid2.Name = "Asteroid2";
            Asteroid2.Size = new Size(95, 91);
            Asteroid2.TabIndex = 12;
            Asteroid2.TabStop = false;
            // 
            // Asteroid5
            // 
            Asteroid5.BackColor = Color.Transparent;
            Asteroid5.Image = (Image)resources.GetObject("Asteroid5.Image");
            Asteroid5.Location = new Point(355, 10);
            Asteroid5.Name = "Asteroid5";
            Asteroid5.Size = new Size(95, 91);
            Asteroid5.TabIndex = 10;
            Asteroid5.TabStop = false;
            // 
            // Asteroid3
            // 
            Asteroid3.BackColor = Color.Transparent;
            Asteroid3.Image = (Image)resources.GetObject("Asteroid3.Image");
            Asteroid3.Location = new Point(200, 39);
            Asteroid3.Name = "Asteroid3";
            Asteroid3.Size = new Size(95, 91);
            Asteroid3.TabIndex = 9;
            Asteroid3.TabStop = false;
            // 
            // Asteroid1
            // 
            Asteroid1.BackColor = Color.Transparent;
            Asteroid1.Image = (Image)resources.GetObject("Asteroid1.Image");
            Asteroid1.Location = new Point(33, 10);
            Asteroid1.Name = "Asteroid1";
            Asteroid1.Size = new Size(95, 91);
            Asteroid1.TabIndex = 8;
            Asteroid1.TabStop = false;
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.Black;
            Btn_Voltar.FlatStyle = FlatStyle.Flat;
            Btn_Voltar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Voltar.ForeColor = Color.White;
            Btn_Voltar.Location = new Point(189, 396);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(127, 33);
            Btn_Voltar.TabIndex = 14;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(182, 220);
            label1.Name = "label1";
            label1.Size = new Size(134, 24);
            label1.TabIndex = 15;
            label1.Text = "Movimentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Khaki;
            label2.Location = new Point(216, 256);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 16;
            label2.Text = "W - Atirar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Khaki;
            label4.Location = new Point(85, 256);
            label4.Name = "label4";
            label4.Size = new Size(106, 19);
            label4.TabIndex = 18;
            label4.Text = "A - Esquerda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Khaki;
            label5.Location = new Point(315, 256);
            label5.Name = "label5";
            label5.Size = new Size(83, 19);
            label5.TabIndex = 19;
            label5.Text = "D - Direita";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 305);
            label3.Name = "label3";
            label3.Size = new Size(106, 24);
            label3.TabIndex = 20;
            label3.Text = "Objetivos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Khaki;
            label6.Location = new Point(12, 338);
            label6.Name = "label6";
            label6.Size = new Size(200, 16);
            label6.TabIndex = 21;
            label6.Text = "• Não colidir com 5 asteróides.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Khaki;
            label7.Location = new Point(12, 366);
            label7.Name = "label7";
            label7.Size = new Size(231, 16);
            label7.TabIndex = 22;
            label7.Text = "• Não deixar 5 asteróides passarem";
            // 
            // HelpScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(484, 461);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_Voltar);
            Controls.Add(Asteroid4);
            Controls.Add(Asteroid2);
            Controls.Add(Asteroid5);
            Controls.Add(Asteroid3);
            Controls.Add(Asteroid1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HelpScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spaceship Game";
            ((System.ComponentModel.ISupportInitialize)Asteroid4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid5).EndInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Asteroid4;
        private PictureBox Asteroid2;
        private PictureBox Asteroid5;
        private PictureBox Asteroid3;
        private PictureBox Asteroid1;
        private Button Btn_Voltar;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label7;
    }
}