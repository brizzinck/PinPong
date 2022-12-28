namespace PinPong
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
            this.BackGround = new System.Windows.Forms.Panel();
            this.Result = new System.Windows.Forms.Label();
            this.GameBall = new System.Windows.Forms.PictureBox();
            this.GamePanel = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LoseLable = new System.Windows.Forms.Label();
            this.BackGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.Controls.Add(this.LoseLable);
            this.BackGround.Controls.Add(this.Result);
            this.BackGround.Controls.Add(this.GameBall);
            this.BackGround.Controls.Add(this.GamePanel);
            this.BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(800, 450);
            this.BackGround.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.Color.Transparent;
            this.Result.Font = new System.Drawing.Font("Arial Black", 30.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(587, 9);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(210, 58);
            this.Result.TabIndex = 2;
            this.Result.Text = "Score: 0";
            // 
            // GameBall
            // 
            this.GameBall.BackColor = System.Drawing.Color.Blue;
            this.GameBall.Location = new System.Drawing.Point(175, 134);
            this.GameBall.Name = "GameBall";
            this.GameBall.Size = new System.Drawing.Size(50, 50);
            this.GameBall.TabIndex = 1;
            this.GameBall.TabStop = false;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Maroon;
            this.GamePanel.Location = new System.Drawing.Point(233, 366);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(337, 50);
            this.GamePanel.TabIndex = 0;
            this.GamePanel.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LoseLable
            // 
            this.LoseLable.AutoSize = true;
            this.LoseLable.BackColor = System.Drawing.Color.Transparent;
            this.LoseLable.Font = new System.Drawing.Font("Arial", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoseLable.Location = new System.Drawing.Point(338, 165);
            this.LoseLable.Name = "LoseLable";
            this.LoseLable.Size = new System.Drawing.Size(213, 88);
            this.LoseLable.TabIndex = 3;
            this.LoseLable.Text = "Lose";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackGround);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.BackGround.ResumeLayout(false);
            this.BackGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel BackGround;
        private PictureBox GameBall;
        private PictureBox GamePanel;
        private System.Windows.Forms.Timer timer;
        private Label Result;
        private Label LoseLable;
    }
}