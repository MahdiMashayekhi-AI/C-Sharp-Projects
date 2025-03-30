using System;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int spead = 10;
        int score = 0;
        int topDown = 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            picFlappy.Top += topDown;
            picDown.Left -= spead;
            picTop.Left -= spead;


            if (picDown.Left < -150)
            {
                picDown.Left = 800;
                score++;
            }

            if (picTop.Left < -180)
            {
                picTop.Left = 950;
                score++;
            }

            lblScore.Text = score.ToString();

            if (score < 10)
                spead = 15;
            else if (score < 30)
                spead = 20;
            else
                spead = 30;


            if (picFlappy.Bounds.IntersectsWith(picDown.Bounds) ||
                picFlappy.Bounds.IntersectsWith(picTop.Bounds) ||
                picFlappy.Bounds.IntersectsWith(picGround.Bounds) || 
                picFlappy.Bounds.IntersectsWith(picGround1.Bounds) ||
                picFlappy.Bounds.IntersectsWith(picGround2.Bounds) || picFlappy.Top < +5
                )
            {
                timer1.Stop();
                lblTextScore.Text = "Game over!";
                lblScore.Text = string.Empty;
                DialogResult result = MessageBox.Show("Do you want to again?","Game over!",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Ok, have good day!", "Goodbay");
                    this.Close();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                topDown = -15; 
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                topDown = +15;
            }
        }
    }
}
