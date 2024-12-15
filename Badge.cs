using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame_v3
{
    internal class Badge
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsEarned { get; set; }
        public string ImagePath { get; set; }

        public Badge(string imagePath, string title, string description)
        {
            Title = title;
            Description = description;
            ImagePath = imagePath;
            IsEarned = false;
        }
    }
}
