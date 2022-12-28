using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinPong
{
    public partial class Form1 : Form
    {
        private int _speedVertical = 2;
        private int _speedHorizontal = 2;
        private int _score = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            GamePanel.Top = BackGround.Bottom - (BackGround.Bottom / 10);
            LoseLable.Visible = false;
            LoseLable.Left = (BackGround.Width / 2) - (LoseLable.Width / 2);
            LoseLable.Top = (BackGround.Height / 2) - (LoseLable.Height / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
            {
                Close();
            }
            if (e.KeyCode == Keys.Space)
            {
                GameBall.Top = 50;
                GameBall.Left = 70;
                _speedHorizontal = 2;
                _score = 0;
                LoseLable.Visible = false;
                timer.Enabled = true;
                Result.Text = "Score: 0";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GamePanel.Left = Cursor.Position.X - (GamePanel.Width / 2);
            GameBall.Left += _speedHorizontal;
            GameBall.Top += _speedVertical;
            if (GameBall.Left <= BackGround.Left)
                _speedHorizontal *= -1;
            if (GameBall.Right >= BackGround.Right)
                _speedHorizontal *= -1;
            if (GameBall.Top <= BackGround.Top)
                _speedVertical *= -1;
            if (GameBall.Bottom >= BackGround.Bottom)
            {
                timer.Enabled = false;
                LoseLable.Visible = true;
            }
            if (GameBall.Bottom >= GamePanel.Top && 
                GameBall.Bottom <= GamePanel.Bottom && 
                GameBall.Left >= GamePanel.Left && 
                GameBall.Right <= GamePanel.Right)
            {
                _speedHorizontal += 1;
                _speedVertical += 1;
                _speedVertical *= -1;
                _score++;
                Result.Text = "Score: " + _score.ToString();
                Random randColor = new Random();
                BackGround.BackColor = Color.FromArgb(
                    randColor.Next(150, 255), 
                    randColor.Next(150, 255), 
                    randColor.Next(150, 255));
            }
        }
    }
}
