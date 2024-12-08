using System;
using System.Windows.Forms;

namespace QuizGame_v3
{
    public partial class DifficultyForm : Form
    {
        public int SelectedWinCondition { get; private set; }

        // Поля для RadioButton
        private RadioButton rBtnEasy;
        private RadioButton rBtnHard;
        private RadioButton rBtnHell;

        public DifficultyForm()
        {
            this.Load += DifficultyForm_Load;
        }

        private void DifficultyForm_Load(object sender, EventArgs e)
        {
            this.Text = "Select Difficulty";
            this.ClientSize = new System.Drawing.Size(300, 200);

            Label lblWelcome = new Label
            {
                Text = "Welcome to the Quiz Game! Select your difficulty level:",
                AutoSize = true,
                Location = new System.Drawing.Point(10, 10)
            };
            this.Controls.Add(lblWelcome);

            // RadioButton как полей класса
            rBtnEasy = new RadioButton
            {
                Text = "Easy",
                Location = new System.Drawing.Point(10, 50),
                AutoSize = true
            };
            this.Controls.Add(rBtnEasy);

            rBtnHard = new RadioButton
            {
                Text = "Hard",
                Location = new System.Drawing.Point(10, 80),
                AutoSize = true
            };
            this.Controls.Add(rBtnHard);

            rBtnHell = new RadioButton
            {
                Text = "Hell",
                Location = new System.Drawing.Point(10, 110),
                AutoSize = true
            };
            this.Controls.Add(rBtnHell);

            Button btnConfirm = new Button
            {
                Text = "Confirm",
                Location = new System.Drawing.Point(10, 150),
                Width = 100
            };
            btnConfirm.Click += btnConfirm_Click;
            this.Controls.Add(btnConfirm);

            Button btnBackToDifficulty = new Button
            {
                Text = "Change Difficulty",
                Location = new System.Drawing.Point(120, 150),
                Width = 150
            };

            this.Controls.Add(btnBackToDifficulty);

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (rBtnEasy.Checked)
            {
                SelectedWinCondition = 10;
            }
            else if (rBtnHard.Checked)
            {
                SelectedWinCondition = 20;
            }
            else if (rBtnHell.Checked)
            {
                SelectedWinCondition = int.MaxValue;
            }
            else
            {
                MessageBox.Show("Please select a difficulty level.");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void BackToDifficulty_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            this.Close();
        }

    }
}
