using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC_103_ROSAL___MAKASAYAN
{
    public partial class Difficult : Form
    {

        int correctAnswer;
        int questionNumber;
        int score;
        int percentage;
        int totalQuestions;
        int incorrectAnswers;
        List<int> askedQuestions;
        public int numOfHearts;

        public Difficult()
        {
            InitializeComponent();
            totalQuestions = 20;
            label2.Text = "Score: 0";
            label2.ForeColor = Color.White;
            askedQuestions = new List<int>();
            RestartQuiz();
        }

        private void ClickAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
                label2.Text = "Score: " + score;
            }
            else
            {
                DecrementHearts();
            }

            if (incorrectAnswers >= 3)
            {
                var result = MessageBox.Show("You lose!" + Environment.NewLine +
                                             "You have answered incorrectly 3 times." + Environment.NewLine +
                                             "Would you like to try again?", "Game Over",
                                             MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    RestartQuiz();
                }
                else
                {
                    OpenMind_Testcs();
                }

                return;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);

                if (incorrectAnswers == 0)
                {
                    MessageBox.Show("Congratulations, you win!" + Environment.NewLine +
                                    "You have answered all questions correctly." + Environment.NewLine +
                                    "Your total score is " + score + " out of " + totalQuestions + ".");
                }
                else if (incorrectAnswers <= 2)
                {
                    MessageBox.Show("Almost there!" + Environment.NewLine +
                                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                                    "Your total percentage is " + percentage + " %." + Environment.NewLine +
                                    "Click OK to play again.");
                }
                else
                {
                    MessageBox.Show("Quiz Ended" + Environment.NewLine +
                                    "You have answered " + score + " questions correctly" + Environment.NewLine +
                                    "Your total percentage is " + percentage + " %" + Environment.NewLine +
                                    "Click OK to play again.");
                }

                RestartQuiz();
            }
            else
            {
                askQuestion();
            }
        }

        private void RestartQuiz()
        {
            questionNumber = 0;
            score = 0;
            incorrectAnswers = 0;
            askedQuestions.Clear();
            label2.Text = "Score: " + score;

            // Reset hearts
            numOfHearts = 3;
            heart1.Image = Properties.Resources.heart;
            heart2.Image = Properties.Resources.heart;
            heart3.Image = Properties.Resources.heart;
            heart1.Visible = true;
            heart2.Visible = true;
            heart3.Visible = true;


            askQuestion();
        }

        private void DecrementHearts()
        {
            incorrectAnswers++;

            switch (incorrectAnswers)
            {
                case 1:
                    heart3.Visible = false;
                    break;
                case 2:
                    heart2.Visible = false;
                    break;
                case 3:
                    heart1.Visible = false;
                    break;
            }
        }

        private void OpenMind_Testcs()
        {
            Mind_Testcs mainForm = new Mind_Testcs();
            mainForm.Show();
            this.Hide();
        }

        private void askQuestion()
        {
            Random rand = new Random();
            int nextQuestion;

            // Find a question that hasn't been asked yet
            do
            {
                nextQuestion = rand.Next(1, totalQuestions + 1);
            } while (askedQuestions.Contains(nextQuestion));

            askedQuestions.Add(nextQuestion); // Add the question to the list of asked questions
            questionNumber++;

            switch (nextQuestion)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 2;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 2;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 2;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 1;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 2;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 1;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources._7;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 1;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources._8;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 1;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources._9;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 2;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources._10;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 1;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources._11;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "54";
                    correctAnswer = 1;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources._12;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 2;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 13:
                    pictureBox1.Image = Properties.Resources._13;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 1;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 14:
                    pictureBox1.Image = Properties.Resources._14;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 2;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources._15;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 2;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 16:
                    pictureBox1.Image = Properties.Resources._16;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 2;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 17:
                    pictureBox1.Image = Properties.Resources._17;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 1;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 18:
                    pictureBox1.Image = Properties.Resources._18;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 2;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 19:
                    pictureBox1.Image = Properties.Resources._19;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 2;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;

                case 20:
                    pictureBox1.Image = Properties.Resources._20;
                    lblQuestion.Text = "Answer the Math Equation:";
                    btn1.Text = "True";
                    btn2.Text = "False";
                    correctAnswer = 2;
                    btn1.Tag = 1;
                    btn2.Tag = 2;
                    break;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Mind_Testcs mainForm = new Mind_Testcs();

            // Show Form1
            mainForm.Show();

            // Close the current form
            this.Hide();

            // Ask a new question in the difficult form
            askQuestion();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Reset the score to zero
            score = 0;
            label2.Text = "Score: " + score; // Update score label to reflect the reset
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            // Reset the score to zero
            score = 0;
            label2.Text = "Score: " + score; // Update score label to reflect the reset
        }

     
    }
}
