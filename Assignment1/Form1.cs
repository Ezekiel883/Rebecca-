using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {

        //Assignemnt game test variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions; //I need these for the game to work


        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber); //this section determines which question is being asked. 1 means Q1 and 6 would mean Q6.
//This is the total questions, i can add more questions but i must increase this number
            totalQuestions = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);
            //This will convert it into an interger and save it in the button tag

            if (buttonTag == correctAnswer)
            {
                score++;
   //This statemnt will check that the button tag and correct answer is the same and if this is true it will add to teh score            
            }
//This makes sure that the question number and amount of questions are the same
            if(questionNumber == totalQuestions)
            {
                //this will work out the percentage
                //percentages ahve already been declared as int so i need the math round function to keep it this way
                
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                
                //this will times the score by 100 then divide by the amount of questions i have - 2 right = 20%
                
                MessageBox.Show(
                    "Game Over!" + Environment.NewLine +
                    "You have answered" + score + "questions correctly." + Environment.NewLine +
                    "Congratulations! You Scored" + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
            //This will allow the game to progress provided the correct answer is given
        }

        private void askQuestion(int qnum)
        {
         //This is a custom function for the ask question which takes one argument which allows the game to progress
            switch(qnum)
            {
                case 1:

            pictureBox1.Image = Properties.Resources.tank1;
         // This is the question 
            lblQuestion.Text = "Which main battle tank did challenger two replace?";

                    button1.Text = "Challenger";//These are the possible answeres the user can choose from
                    button2.Text = "Striker";
                    button3.Text = "Panzer";
                    button4.Text = "T-34";

                    correctAnswer = 1;//This is the correct answer and will specify which button is the correct one rather than the actual words

                break;
         //This break will mean that if there is a case and a condition is met it will stop 


                case 2:

                    pictureBox1.Image = Properties.Resources.pilot2;//The image will change for each question to keep the game immersive

                    lblQuestion.Text = "What was the shortest life expectancy of a royal air force pilot during WWII?";

                    button1.Text = "10 Days";
                    button2.Text = "1 Year";
                    button3.Text = "4 Weeks";
                    button4.Text = "2 Months";

                    correctAnswer = 3;

                    break;


                case 3:

                    pictureBox1.Image = Properties.Resources.question3;

                    lblQuestion.Text = "What colour is the sky?";

                    button1.Text = "White";
                    button2.Text = "Blue";
                    button3.Text = "Yellow";
                    button4.Text = "Green";

                    correctAnswer = 2;

                    break;


                case 4:

                    pictureBox1.Image = Properties.Resources.raf4;

                    lblQuestion.Text = "In what county is RAF Benson?";

                    button1.Text = "Warwichshire";
                    button2.Text = "Oxfordshire";
                    button3.Text = "Northamptonshire";
                    button4.Text = "Gloucestershire";

                    correctAnswer = 2;

                    break;


                case 5:

                    pictureBox1.Image = Properties.Resources.spitfire5;

                    lblQuestion.Text = "What was the operational range of the Spitfire?";

                    button1.Text = "300 Miles";
                    button2.Text = "720 Miles";
                    button3.Text = "500 Miles";
                    button4.Text = "980 Miles";

                    correctAnswer = 4;

                    break;


                case 6:

                    pictureBox1.Image = Properties.Resources.raf6;

                    lblQuestion.Text = "What year was the royal air force formed?";

                    button1.Text = "1918";
                    button2.Text = "1939";
                    button3.Text = "1945";
                    button4.Text = "1914";

                    correctAnswer = 1;

                    break;


                case 7:

                    pictureBox1.Image = Properties.Resources.gun7;

                    lblQuestion.Text = "What was the name of the standard riffle used by British soldiers throughout WWI?";

                    button1.Text = "Chauchat M1915";
                    button2.Text = "Lewis MK I";
                    button3.Text = "Short Magazine Lee Enfield";
                    button4.Text = "M1 Garand";

                    correctAnswer = 3;

                    break;


                case 8:

                    pictureBox1.Image = Properties.Resources.flag8;

                    lblQuestion.Text = "At what battle in 1815 did Napoleon surrender to the British?";

                    button1.Text = "Trafalgar";
                    button2.Text = "Waterloo";
                    button3.Text = "Hastings";
                    button4.Text = "Leipzig";

                    correctAnswer = 2;

                    break;


                case 9:

                    pictureBox1.Image = Properties.Resources.president9;

                    lblQuestion.Text = "Which US General in WWII later became the 34th President of the United States of America?";

                    button1.Text = "John F. Kennedy";
                    button2.Text = "Calvin Coolidge";
                    button3.Text = "Herbert Hoover";
                    button4.Text = "Dwight D Eisenhower";

                    correctAnswer = 4;

                    break;


                case 10:

                    pictureBox1.Image = Properties.Resources.last10;

                    lblQuestion.Text = "The Battle of Monte Cassino took place in which country?";

                    button1.Text = "France";
                    button2.Text = "Germany";
                    button3.Text = "Italy";
                    button4.Text = "Englnad";

                    correctAnswer = 3;

                    break;


            }






        }

    }
}
