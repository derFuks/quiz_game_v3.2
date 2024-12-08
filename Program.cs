using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame_v3._2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                using (var difficultyForm = new DifficultyForm())
                {
                    var result = difficultyForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Application.Run(new Form1(difficultyForm.SelectedWinCondition));
                        break;
                    }
                    else if (result == DialogResult.Retry) {
                        continue; // set difficulty level again
                    } else
                    {
                        break;
                    }
                }
            }

        }
    }
}
