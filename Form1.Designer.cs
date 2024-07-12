namespace HelicopterFlyingGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pillar1 = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.pillar3 = new System.Windows.Forms.PictureBox();
            this.pillar4 = new System.Windows.Forms.PictureBox();
            this.Helicopter = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lb_score = new System.Windows.Forms.Label();
            this.lb_gameOver = new System.Windows.Forms.Label();
            this.lb_startgame = new System.Windows.Forms.Label();
            this.lb_best = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Helicopter)).BeginInit();
            this.SuspendLayout();
            // 
            // pillar1
            // 
            this.pillar1.BackColor = System.Drawing.Color.Lime;
            this.pillar1.Location = new System.Drawing.Point(141, 256);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(27, 141);
            this.pillar1.TabIndex = 0;
            this.pillar1.TabStop = false;
            this.pillar1.Tag = "pillar";
            // 
            // pillar2
            // 
            this.pillar2.BackColor = System.Drawing.Color.Lime;
            this.pillar2.Location = new System.Drawing.Point(701, 78);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(24, 141);
            this.pillar2.TabIndex = 0;
            this.pillar2.TabStop = false;
            this.pillar2.Tag = "pillar";
            // 
            // pillar3
            // 
            this.pillar3.BackColor = System.Drawing.Color.Lime;
            this.pillar3.Location = new System.Drawing.Point(-3, 0);
            this.pillar3.Name = "pillar3";
            this.pillar3.Size = new System.Drawing.Size(804, 16);
            this.pillar3.TabIndex = 0;
            this.pillar3.TabStop = false;
            this.pillar3.Tag = "border";
            // 
            // pillar4
            // 
            this.pillar4.BackColor = System.Drawing.Color.Lime;
            this.pillar4.Location = new System.Drawing.Point(-3, 434);
            this.pillar4.Name = "pillar4";
            this.pillar4.Size = new System.Drawing.Size(804, 16);
            this.pillar4.TabIndex = 0;
            this.pillar4.TabStop = false;
            this.pillar4.Tag = "border";
            // 
            // Helicopter
            // 
            this.Helicopter.Image = ((System.Drawing.Image)(resources.GetObject("Helicopter.Image")));
            this.Helicopter.Location = new System.Drawing.Point(47, 103);
            this.Helicopter.Name = "Helicopter";
            this.Helicopter.Size = new System.Drawing.Size(100, 54);
            this.Helicopter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Helicopter.TabIndex = 1;
            this.Helicopter.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimeEvent);
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_score.Location = new System.Drawing.Point(-3, 19);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(88, 25);
            this.lb_score.TabIndex = 2;
            this.lb_score.Text = "Score : 0";
            // 
            // lb_gameOver
            // 
            this.lb_gameOver.AutoSize = true;
            this.lb_gameOver.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_gameOver.Location = new System.Drawing.Point(141, 330);
            this.lb_gameOver.Name = "lb_gameOver";
            this.lb_gameOver.Size = new System.Drawing.Size(0, 25);
            this.lb_gameOver.TabIndex = 2;
            this.lb_gameOver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lb_startgame
            // 
            this.lb_startgame.AutoSize = true;
            this.lb_startgame.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_startgame.Location = new System.Drawing.Point(215, 256);
            this.lb_startgame.Name = "lb_startgame";
            this.lb_startgame.Size = new System.Drawing.Size(0, 25);
            this.lb_startgame.TabIndex = 2;
            this.lb_startgame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_best
            // 
            this.lb_best.AutoSize = true;
            this.lb_best.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_best.Location = new System.Drawing.Point(671, 19);
            this.lb_best.Name = "lb_best";
            this.lb_best.Size = new System.Drawing.Size(64, 25);
            this.lb_best.TabIndex = 2;
            this.lb_best.Text = "Best : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_startgame);
            this.Controls.Add(this.lb_gameOver);
            this.Controls.Add(this.lb_best);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.Helicopter);
            this.Controls.Add(this.pillar4);
            this.Controls.Add(this.pillar3);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.FormLoad);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseIsDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Helicopter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pillar1;
        private PictureBox pillar2;
        private PictureBox pillar3;
        private PictureBox pillar4;
        private PictureBox Helicopter;
        private System.Windows.Forms.Timer GameTimer;
        private Label lb_score;
        private Label lb_gameOver;
        private Label lb_startgame;
        private Label lb_best;
    }
}