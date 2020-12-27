using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace project_TP2
{
    //TODO :  find a solution for this ERROR
    public partial class game : Form
    {
        List<String> labelList = new List<String>();
        List<TextBox> textboxList = new List<TextBox>();
        int correct;
        Boolean anim = true;
        Boolean endOfGame = false;
        public game()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void game_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            val1.Text = random.Next(1, 10).ToString();
            val2.Text = random.Next(1, 10).ToString();
            val3.Text = random.Next(1, 10).ToString();
            val4.Text = random.Next(1, 10).ToString();
            labelList.Add(val1.Text);
            labelList.Add(val2.Text);
            labelList.Add(val3.Text);
            labelList.Add(val4.Text);
        }

        public void resetColorsAndValues()
        {
            v1.BackColor = Color.White; v1.Text = "";
            v2.BackColor = Color.White; v2.Text = "";
            v3.BackColor = Color.White; v3.Text = "";
            v4.BackColor = Color.White; v4.Text = "";
        }
        public void randomise()
        {
            Random random = new Random();
            val1.Text = random.Next(1, 10).ToString();
            val2.Text = random.Next(1, 10).ToString();
            val3.Text = random.Next(1, 10).ToString();
            val4.Text = random.Next(1, 10).ToString();
            labelList[0] = val1.Text;
            labelList[1] = val2.Text;
            labelList[2] = val3.Text;
            labelList[3] = val4.Text;
            numberOfTry.Text = "0";
            resetColorsAndValues();
            correct = 0;
        }
        private void newGame_Click(object sender, EventArgs e)
        {
            randomise();
            endOfGame = false;
            val1Box.BackColor = Color.White;
            val2Box.BackColor = Color.White;
            val3Box.BackColor = Color.White;
            val4Box.BackColor = Color.White;
        }

        private void hideResult_Click(object sender, EventArgs e)
        {
            val1.Text = "-";
            val2.Text = "-";
            val3.Text = "-";
            val4.Text = "-";
        }

        private void showResult_Click(object sender, EventArgs e)
        {
            val1.Text = labelList[0];
            val2.Text = labelList[1];
            val3.Text = labelList[2];
            val4.Text = labelList[3];
        }

        private void tryAgain_Click(object sender, EventArgs e)
        {
            if (v1.Text != labelList[0])
                v1.Text = "";
            if (v2.Text != labelList[1])
                v2.Text = "";
            if (v3.Text != labelList[2])
                v3.Text = "";
            if (v4.Text != labelList[3])
                v4.Text = "";
        }

        private void Verify_Click(object sender, EventArgs e)
        {
            correct = 0;
            textboxList.Clear();
            textboxList.Add(v1);
            textboxList.Add(v2);
            textboxList.Add(v3);
            textboxList.Add(v4);
            //TODO :  check if they content a value or not

            for (int i = 0; i < 4; i++)
            {
                if (textboxList[i].Text == labelList[i])
                {
                    textboxList[i].BackColor = Color.Green;
                    correct++;
                }else if (test(textboxList[i]))
                {
                    textboxList[i].BackColor = Color.Yellow;
                }
                else if (test(textboxList[i]) == false)
                {
                    textboxList[i].BackColor = Color.Red;
                }
            }
            numberOfTry.Text = (int.Parse(numberOfTry.Text) + 1).ToString();
             if ((int.Parse(numberOfTry.Text) > 3) && (correct != 4))
            {
                MessageBox.Show("Game Over");
                endOfGame = false;
                Form1 f = new Form1();
                this.Visible = false;
                f.Show();
            }
            if (correct == 4)
            {
                MessageBox.Show("Bien Jouer!");
                resetColorsAndValues();
                numberOfTry.Text = "0";
                endOfGame = true;
            }
        }
        public Boolean test(TextBox t)
        {
            for (int i = 0; i < textboxList.Count; i++)
            {
                if (t.Text == labelList[i])
                    return true;
            }
           return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (endOfGame)
            {
                if (anim)
                {
                    val1Box.BackColor = Color.Red;
                    val2Box.BackColor = Color.Red;
                    val3Box.BackColor = Color.Red;
                    val4Box.BackColor = Color.Red;
                    anim = false;
                }
                else
                {
                    val1Box.BackColor = Color.Yellow;
                    val2Box.BackColor = Color.Yellow;
                    val3Box.BackColor = Color.Yellow;
                    val4Box.BackColor = Color.Yellow;
                    anim = true;
             }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Visible = false;
        }
    }
}

