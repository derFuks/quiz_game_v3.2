using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuizGame_v3
{
    public partial class Form1 : Form
    {
        private List<Question> questions; // todo: подключить external DB
        private HashSet<int> answeredQuestionIndices;
        private List<Badge> badges;
        private PlayerStats playerStats;
        private int currentQuestionIndex;
        private int score;
        private int correctAnswersInARow;
        private int winCondition;

        private bool used5050 = false;
        private bool usedAudience = false;
        private bool usedFriend = false;
        private bool usedLawyer = false;
        private bool usedDice = false;
        private bool usedChatGPT = false;

        public Form1(int winCondition)
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.winCondition = winCondition;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            playerStats = new PlayerStats();
            answeredQuestionIndices = new HashSet<int>();
            currentQuestionIndex = 0;
            score = 0;
            correctAnswersInARow = 0;

            questions = new List<Question>() {
                new Question("Which SQL statement is used to retrieve data from a database?", new[] { "UPDATE", "INSERT", "DELETE", "SELECT" }, 3),
                new Question("What is the color of Ishan's car?", new[] { "White", "Black", "Blue", "Red" }, 3),
                new Question("In C#, what does the keyword 'int' represent?", new[] { "Intruder", "Interface", "Integer", "Initialization" }, 2),
                new Question("Who wrote the novel 'Crime and Punishment'?", new[] { "Dostoevsky", "Tolstoy", "Emily Brontë", "Stephen King" }, 0),
                new Question("What is the primary purpose of a database index in MySQL?", new[] { "To encrypt data", "To store backup data", "To speed up data retrieval", "To connect databases" }, 2),
                new Question("In the James Bond series, what is Bond's code number?", new[] { "700", "007", "777", "070" }, 1),
                new Question("Name Ishan's favourite wine", new[] { "Zinfandel", "Montepulciano", "Syrah", "Pinot noir" }, 0),
                new Question("Name a guy from 'Game of Thrones'", new[] { "Aragorn, son of Arathorn", "Walter White", "Jon Snow", "Jane Eyre" }, 2),
                new Question("What is the return type of the 'Main' method in C#?", new[] { "int", "void", "string", "bool" }, 1),
                new Question("Who is the author of 'War and Peace'?", new[] { "Aleksandr Solzhenitsyn", "Fyodor Dostoevsky", "Leo Tolstoy", "Mikhail Bulgakov" }, 2),
                new Question("What is the primary feature of the 'WHERE' in SQL?", new[] { "Filtering rows", "Sorting rows", "Filtering grouped data", "Sorting grouped data" }, 0),
                new Question("In C#, what does 'null' represent?", new[] { "Zero", "No value", "Undefined", "Empty array" }, 1),
                new Question("Which database constraint ensures unique values in a column?", new[] { "UNIQUE", "PRIMARY KEY", "FOREIGN KEY", "CHECK" }, 0),
                new Question("Who wrote 'Jane Eyre'?", new[] { "Charlotte Brontë", "Emily Brontë", "Vasya Brontë", "Megan Brontë" }, 0),
                new Question("Which SQL function is used to count the number of rows in a table?", new[] { "TOTAL()", "COUNT()", "GETROWS()", "GETTOTAL()" }, 1),
                new Question("What is a 'deadlock' in database systems?", new[] { "A situation where two transactions block each other", "An error in SQL syntax", "An infinite loop", "A memory leak" }, 0),
                new Question("What would fit a 2 liter can?", new[] { "Microwave oven", "Carburetor", "German Shepherd", "Hamburger" }, 3),
                new Question("What is the purpose of the 'Group By' clause in SQL?", new[] { "To aggregate data", "To sort data", "To filter data", "To join tables" }, 0),
                new Question("Which James Bond movie features the villain Goldfinger?", new[] { "Goldfinger", "Dr. No", "Skyfall", "Casino Royale" }, 0),
                new Question("Which SQL clause is used to remove duplicates from a result set?", new[] { "DISTINCT", "GROUP BY", "UNIQUE", "FILTER" }, 0),
                new Question("Who played Walter White in 'Breaking Bad'?", new[] { "Bryan Cranston", "Aaron Paul", "Dean Norris", "Bob Odenkirk" }, 0),
                new Question("What does the keyword 'static' mean in C#?", new[] { "Is a constant", "Cannot be inherited", "Belongs to the class", "Is a variable" }, 2),
                new Question("Which Stephen King novel features a telekinetic prom queen?", new[] { "It", "Carrie", "The Shining", "Misery" }, 1),
                new Question("What does the 'HAVING' clause in SQL do?", new[] { "Filters rows", "Joins tables", "Sorts data", "Filters grouped data" }, 0),
                new Question("What is the maximum value of an INT in MySQL?", new[] { "2,147,483,647", "1,213,000,044", "4,294,967,295", "9,223,372,036,854,775,807" }, 0),
            };

            badges = new List<Badge>
            {
                new Badge("Beginner", "Nice to meet you!", "images/beginner.png"), // for starting a game
                new Badge("Looser","Failed for the first time","images/looser.png"), // for loosing for the 5th time
                new Badge("Explorer","Nothing will stop you. Keep going!","images/explorer.png"), // for playing for the 3 time
                new Badge("Cyborg","What are you?!","images/cyborg.png"), //for starting a game after 3 failures
                new Badge("Maniac","You are playing over 10 times. Are you ok?","images/maniac.png"), // for playing over 10 times
                new Badge("Cheater","You can't know it all","images/cheater.png"), //for answering 10 questions without loosing
            };
            ShuffleQuestions(); // avoid reapetitions
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < winCondition)
            {
                var question = questions[currentQuestionIndex];
                lblQuestion.Text = question.QuestionText;
                btnOption1.Text = question.Options[0];
                btnOption2.Text = question.Options[1];
                btnOption3.Text = question.Options[2];
                btnOption4.Text = question.Options[3];
                UpdateProgress();
            }
            else
            {
                UpdateProgress();
                EndGame(true);
            }

        }
        private void UpdateProgress()
        {
            int remainingQuestions = winCondition - currentQuestionIndex; // fixing the progressBar1 problem

            progressBar1.Value = (int)((currentQuestionIndex / (float)winCondition) * 100);
            lblScore.Text = $"Your score: {score}";
            lblStreak.Text = $"Correct answers: {correctAnswersInARow}";
        }
        private void CheckAnswer(int selectOptionsIndex)
        {
            var question = questions[currentQuestionIndex];
            if (selectOptionsIndex == question.CorrectOptionIndex)
            {
                correctAnswersInARow++;
                score++;
                Console.WriteLine($"Correct Answers in a Row: {correctAnswersInARow}"); // Debugging
                MessageBox.Show("Correct! Nice job!");

                answeredQuestionIndices.Add(currentQuestionIndex);
                MoveToNextQuestion();
            } else
            {
                MessageBox.Show("Wrong answer! Game over.");
                EndGame();
            }
        }

        private void MoveToNextQuestion()
        {
            do
            {
                currentQuestionIndex++;
            } while (answeredQuestionIndices.Contains(currentQuestionIndex) && currentQuestionIndex < questions.Count);
            DisplayQuestion();
            ResetButtonBorders();
        }

        private void ShuffleQuestions()
        {
            Random random = new Random();
            questions = questions.OrderBy(q => random.Next()).ToList();
        }
        private void EndGame()
        {
            lblQuestion.Text = "Game finished. Click 'Start Game' to play again.";
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
            ResetButtonBorders();
        }


        private void btnOption1_Click(object sender, EventArgs e) => CheckAnswer(0);

        private void btnOption2_Click(object sender, EventArgs e) => CheckAnswer(1);

        private void btnOption3_Click(object sender, EventArgs e) => CheckAnswer(2);

        private void btnOption4_Click(object sender, EventArgs e) => CheckAnswer(3);
        private void EndGame(bool won)
        {
            if (won) 
            {
                MessageBox.Show("Congrats, chelovek! You have completed the game!");
            }
            else
            {
                MessageBox.Show("Game over! Try again!");
            }

            lblQuestion.Text = "Game finished. Click 'Start Game' to play again.";
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }
       private void btnGameStart_Click(object sender, EventArgs e)
        {
            answeredQuestionIndices.Clear();
            currentQuestionIndex = 0;
            score = 0;
            correctAnswersInARow = 0;

            ShuffleQuestions();
            DisplayQuestion();

            btnOption1.Enabled = true;
            btnOption2.Enabled = true;
            btnOption3.Enabled = true;
            btnOption4.Enabled = true;

            btnHint1.Enabled = true;
            btnHint2.Enabled = true;
            btnHint3.Enabled = true;
            btnHint4.Enabled = true;
            btnHint5.Enabled = true;
            btnHint6.Enabled = true;

            Console.WriteLine("New game started");
        }
        private void btnGameEnd_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to end the game?", "End Game", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Console.WriteLine("User clicked btnGameEnd_Click");
                EndGame(false);
            }
        }
        private async void BackToDifficulty_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // temprary hide to close later

            using (var difficultyForm = new DifficultyForm()){
                if(difficultyForm.ShowDialog() == DialogResult.OK)
                {
                    var newGameForm = new Form1(difficultyForm.SelectedWinCondition);
                    newGameForm.ShowDialog();

                    // now close initial Form1
                    this.Close();
                }
                else
                {
                    this.Show(); // return initial Form1 if difficulty hasn't been changed
                }
            }
        }

        private void btnHint1_Click(object sender, EventArgs e)
        {
            if (used5050)
            {
                MessageBox.Show("You've used the 50-50 hint. Try something else.");
                return;
            }
            used5050 = true;
            Random random = new Random();
            var incorrectOptions = new List<int> { 0, 1, 2, 3 }.Where(i => i != questions[currentQuestionIndex].CorrectOptionIndex).ToList();

            for (int i = 0; i <2; i++)
            {
                int indexToRemove = incorrectOptions[random.Next(incorrectOptions.Count)];
                incorrectOptions.Remove(indexToRemove);

                if (indexToRemove == 0) btnOption1.Text = "";
                if (indexToRemove == 1) btnOption2.Text = "";
                if (indexToRemove == 2) btnOption3.Text = "";
                if (indexToRemove == 3) btnOption4.Text = "";
            }
            btnHint1.Enabled = false;
        }

        private void btnHint2_Click(object sender, EventArgs e)
        {
            if (usedAudience)
            {
                MessageBox.Show("You've asked the audience, use your brains and select something else.");
                return;
            }
            usedAudience = true;
            Random random = new Random();
            int audienceChoice = random.Next(1, 100) < 90
                ? questions[currentQuestionIndex].CorrectOptionIndex
                : random.Next(0, 4);
            HighlightOption(audienceChoice);
            MessageBox.Show($"The audience advice you to select option {audienceChoice + 1}.");
            btnHint2.Enabled = false;
        }

        private void btnHint3_Click(object sender, EventArgs e)
        {
            if (usedFriend)
            {
                MessageBox.Show("No frends are available now. Select any other remaining option");
                return;
            }

            usedFriend = true;
            Random random = new Random();
            int friendChoice = random.Next(0, 100) < 50
                ? questions[currentQuestionIndex].CorrectOptionIndex
                : random.Next(0, 4);
            HighlightOption(friendChoice);
            MessageBox.Show($"Your bro suggests option {friendChoice + 1}");
            btnHint3.Enabled = false;
        }

        private void btnHint4_Click(object sender, EventArgs e)
        {
            if (usedLawyer)
            {
                MessageBox.Show("Your lawyer is available nomore. Select any other remaining option");
                return;
            }
            usedLawyer = true;
            Random random = new Random();
            int lawyerChoice = random.Next(0, 2) == 0
                ? questions[currentQuestionIndex].CorrectOptionIndex
                : random.Next(0, 4);
            HighlightOption(lawyerChoice);
            MessageBox.Show($"Your lawyer wishes you well and suggests option {lawyerChoice + 1}.");
            btnHint4.Enabled = false;
        }

        private void btnHint5_Click(object sender, EventArgs e)
        {
            if (usedDice)
            {
                MessageBox.Show("You have already tossed the dice!");
                return;
            }
            usedDice = true;
            Random random = new Random();
            int diceChoice = random.Next(0, 4);
            HighlightOption(diceChoice);
            MessageBox.Show($"The dice points to option {diceChoice +1}. Are your sure you trust the dice?");
            btnHint5.Enabled = false;
        }

        private void btnHint6_Click(object sender, EventArgs e)
        {
            if (usedChatGPT)
            {
                MessageBox.Show("You have already asked ChatGPT!");
                return;
            }

            usedChatGPT = true;
            Random random = new Random();
            int chatGPTChoice = random.Next(0, 100) < 75
                ? questions[currentQuestionIndex].CorrectOptionIndex
                : random.Next(0, 4);
            HighlightOption(chatGPTChoice);
            MessageBox.Show($"ChatGPT says option {chatGPTChoice +1} is the correct one.");
            btnHint6.Enabled = false;
            }

        private void HighlightOption(int optionIndex)
        {
            ResetButtonBorders();

            if (optionIndex == 0) btnOption1.FlatAppearance.BorderColor = Color.SkyBlue;
            if (optionIndex == 1) btnOption2.FlatAppearance.BorderColor = Color.SkyBlue;
            if (optionIndex == 2) btnOption3.FlatAppearance.BorderColor = Color.SkyBlue;
            if (optionIndex == 3) btnOption4.FlatAppearance.BorderColor = Color.SkyBlue;
        }
        private void ResetButtonBorders()
        {
            btnOption1.FlatAppearance.BorderColor = Color.Gray;
            btnOption2.FlatAppearance.BorderColor = Color.Gray;
            btnOption3.FlatAppearance.BorderColor = Color.Gray;
            btnOption4.FlatAppearance.BorderColor = Color.Gray;
        }
    }
}
