using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuizGame_v3
{
    public partial class BadgeForm : Form
    {
        public BadgeForm()
        {
            InitializeComponent();
            this.Text = "Your Badges";
        }
        public void AddBadge(string imagePath, string title, string description)
        {
            PictureBox badgeImage = new PictureBox
            {
                ImageLocation = imagePath,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(100, 100),
                Margin = new Padding(10)
            };

            Label badgeLabel = new Label
            {
                Text = $"{title}\n{description}",
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Arial", 10),
                Margin = new Padding(10)

            };

            FlowLayoutPanel badgePanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10)
            };

            badgePanel.Controls.Add(badgeImage);
            badgePanel.Controls.Add(badgeLabel);
            this.Controls.Add(badgePanel);
        }
    }
}
