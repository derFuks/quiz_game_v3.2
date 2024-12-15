namespace QuizGame_v3
{
    partial class BadgeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.badgeImage = new System.Windows.Forms.PictureBox();
            this.badgeLabel = new System.Windows.Forms.Label();
            this.badgePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.h1Header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.badgeImage)).BeginInit();
            this.badgePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // badgeImage
            // 
            this.badgeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.badgeImage.Location = new System.Drawing.Point(3, 3);
            this.badgeImage.Name = "badgeImage";
            this.badgeImage.Size = new System.Drawing.Size(100, 100);
            this.badgeImage.TabIndex = 0;
            this.badgeImage.TabStop = false;
            // 
            // badgeLabel
            // 
            this.badgeLabel.AutoSize = true;
            this.badgeLabel.Location = new System.Drawing.Point(109, 0);
            this.badgeLabel.Name = "badgeLabel";
            this.badgeLabel.Size = new System.Drawing.Size(63, 13);
            this.badgeLabel.TabIndex = 1;
            this.badgeLabel.Text = "badgeLabel";
            // 
            // badgePanel
            // 
            this.badgePanel.Controls.Add(this.badgeImage);
            this.badgePanel.Controls.Add(this.badgeLabel);
            this.badgePanel.Location = new System.Drawing.Point(15, 42);
            this.badgePanel.Name = "badgePanel";
            this.badgePanel.Size = new System.Drawing.Size(526, 115);
            this.badgePanel.TabIndex = 2;
            // 
            // h1Header
            // 
            this.h1Header.AutoSize = true;
            this.h1Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h1Header.Location = new System.Drawing.Point(12, 9);
            this.h1Header.Name = "h1Header";
            this.h1Header.Size = new System.Drawing.Size(86, 16);
            this.h1Header.TabIndex = 3;
            this.h1Header.Text = "Your Badges";
            // 
            // BadgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 663);
            this.Controls.Add(this.h1Header);
            this.Controls.Add(this.badgePanel);
            this.Name = "BadgeForm";
            this.Text = "BadgeForm";
            ((System.ComponentModel.ISupportInitialize)(this.badgeImage)).EndInit();
            this.badgePanel.ResumeLayout(false);
            this.badgePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox badgeImage;
        private System.Windows.Forms.Label badgeLabel;
        private System.Windows.Forms.FlowLayoutPanel badgePanel;
        private System.Windows.Forms.Label h1Header;
    }
}