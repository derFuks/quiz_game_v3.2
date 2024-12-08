namespace QuizGame_v3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnHint1 = new System.Windows.Forms.Button();
            this.btnHint2 = new System.Windows.Forms.Button();
            this.btnHint3 = new System.Windows.Forms.Button();
            this.btnHint6 = new System.Windows.Forms.Button();
            this.btnHint5 = new System.Windows.Forms.Button();
            this.btnHint4 = new System.Windows.Forms.Button();
            this.btnGameStart = new System.Windows.Forms.Button();
            this.btnGameEnd = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblStreak = new System.Windows.Forms.Label();
            this.BackToDifficulty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(25, 31);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(277, 24);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Text of the question will be here";
            // 
            // btnOption1
            // 
            this.btnOption1.Location = new System.Drawing.Point(29, 95);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(586, 23);
            this.btnOption1.TabIndex = 1;
            this.btnOption1.Text = "Option 1";
            this.btnOption1.UseVisualStyleBackColor = true;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.Location = new System.Drawing.Point(29, 124);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(586, 23);
            this.btnOption2.TabIndex = 2;
            this.btnOption2.Text = "Option 2";
            this.btnOption2.UseVisualStyleBackColor = true;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.Location = new System.Drawing.Point(29, 153);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(586, 23);
            this.btnOption3.TabIndex = 3;
            this.btnOption3.Text = "Option 3";
            this.btnOption3.UseVisualStyleBackColor = true;
            this.btnOption3.Click += new System.EventHandler(this.btnOption3_Click);
            // 
            // btnOption4
            // 
            this.btnOption4.Location = new System.Drawing.Point(29, 182);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(586, 23);
            this.btnOption4.TabIndex = 4;
            this.btnOption4.Text = "Option 4";
            this.btnOption4.UseVisualStyleBackColor = true;
            this.btnOption4.Click += new System.EventHandler(this.btnOption4_Click);
            // 
            // btnHint1
            // 
            this.btnHint1.Location = new System.Drawing.Point(29, 268);
            this.btnHint1.Name = "btnHint1";
            this.btnHint1.Size = new System.Drawing.Size(253, 23);
            this.btnHint1.TabIndex = 5;
            this.btnHint1.Text = "50-50";
            this.btnHint1.UseVisualStyleBackColor = true;
            // 
            // btnHint2
            // 
            this.btnHint2.Location = new System.Drawing.Point(29, 297);
            this.btnHint2.Name = "btnHint2";
            this.btnHint2.Size = new System.Drawing.Size(253, 23);
            this.btnHint2.TabIndex = 6;
            this.btnHint2.Text = "Ask the Audience";
            this.btnHint2.UseVisualStyleBackColor = true;
            // 
            // btnHint3
            // 
            this.btnHint3.Location = new System.Drawing.Point(29, 326);
            this.btnHint3.Name = "btnHint3";
            this.btnHint3.Size = new System.Drawing.Size(253, 23);
            this.btnHint3.TabIndex = 7;
            this.btnHint3.Text = "Call a Stupid Friend";
            this.btnHint3.UseVisualStyleBackColor = true;
            // 
            // btnHint6
            // 
            this.btnHint6.Location = new System.Drawing.Point(362, 326);
            this.btnHint6.Name = "btnHint6";
            this.btnHint6.Size = new System.Drawing.Size(253, 23);
            this.btnHint6.TabIndex = 10;
            this.btnHint6.Text = "Ask ChatGPT";
            this.btnHint6.UseVisualStyleBackColor = true;
            // 
            // btnHint5
            // 
            this.btnHint5.Location = new System.Drawing.Point(362, 297);
            this.btnHint5.Name = "btnHint5";
            this.btnHint5.Size = new System.Drawing.Size(253, 23);
            this.btnHint5.TabIndex = 9;
            this.btnHint5.Text = "Toss a d4 Dice";
            this.btnHint5.UseVisualStyleBackColor = true;
            // 
            // btnHint4
            // 
            this.btnHint4.Location = new System.Drawing.Point(362, 268);
            this.btnHint4.Name = "btnHint4";
            this.btnHint4.Size = new System.Drawing.Size(253, 23);
            this.btnHint4.TabIndex = 8;
            this.btnHint4.Text = "Call Your Lawyer";
            this.btnHint4.UseVisualStyleBackColor = true;
            // 
            // btnGameStart
            // 
            this.btnGameStart.Location = new System.Drawing.Point(29, 389);
            this.btnGameStart.Name = "btnGameStart";
            this.btnGameStart.Size = new System.Drawing.Size(253, 23);
            this.btnGameStart.TabIndex = 11;
            this.btnGameStart.Text = "New game";
            this.btnGameStart.UseVisualStyleBackColor = true;
            this.btnGameStart.Click += new System.EventHandler(this.btnGameStart_Click);
            // 
            // btnGameEnd
            // 
            this.btnGameEnd.Location = new System.Drawing.Point(29, 418);
            this.btnGameEnd.Name = "btnGameEnd";
            this.btnGameEnd.Size = new System.Drawing.Size(253, 23);
            this.btnGameEnd.TabIndex = 12;
            this.btnGameEnd.Text = "End game";
            this.btnGameEnd.UseVisualStyleBackColor = true;
            this.btnGameEnd.Click += new System.EventHandler(this.btnGameEnd_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.YellowGreen;
            this.progressBar1.ForeColor = System.Drawing.Color.IndianRed;
            this.progressBar1.Location = new System.Drawing.Point(362, 389);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(253, 23);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Value = 1;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(362, 417);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(70, 13);
            this.lblScore.TabIndex = 14;
            this.lblScore.Text = "Your score: 0";
            // 
            // lblStreak
            // 
            this.lblStreak.AutoSize = true;
            this.lblStreak.Location = new System.Drawing.Point(362, 430);
            this.lblStreak.Name = "lblStreak";
            this.lblStreak.Size = new System.Drawing.Size(95, 13);
            this.lblStreak.TabIndex = 15;
            this.lblStreak.Text = "Correct answers: 0";
            // 
            // BackToDifficulty
            // 
            this.BackToDifficulty.Location = new System.Drawing.Point(29, 447);
            this.BackToDifficulty.Name = "BackToDifficulty";
            this.BackToDifficulty.Size = new System.Drawing.Size(253, 23);
            this.BackToDifficulty.TabIndex = 16;
            this.BackToDifficulty.Text = "Change difficulty";
            this.BackToDifficulty.UseVisualStyleBackColor = true;
            this.BackToDifficulty.Click += new System.EventHandler(this.BackToDifficulty_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.BackToDifficulty);
            this.Controls.Add(this.lblStreak);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnGameEnd);
            this.Controls.Add(this.btnGameStart);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnHint6);
            this.Controls.Add(this.btnHint5);
            this.Controls.Add(this.btnHint4);
            this.Controls.Add(this.btnHint3);
            this.Controls.Add(this.btnHint2);
            this.Controls.Add(this.btnHint1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnHint1;
        private System.Windows.Forms.Button btnHint2;
        private System.Windows.Forms.Button btnHint3;
        private System.Windows.Forms.Button btnHint6;
        private System.Windows.Forms.Button btnHint5;
        private System.Windows.Forms.Button btnHint4;
        private System.Windows.Forms.Button btnGameStart;
        private System.Windows.Forms.Button btnGameEnd;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblStreak;
        private System.Windows.Forms.Button BackToDifficulty;
    }
}

