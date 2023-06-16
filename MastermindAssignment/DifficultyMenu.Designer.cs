namespace MastermindAssignment
{
    partial class DifficultyMenu
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
            helpTitleLabel = new Label();
            secretCodeComboBox = new ComboBox();
            guessComboBox = new ComboBox();
            secretLabel = new Label();
            guessLabel = new Label();
            playButton = new Button();
            quitButton = new Button();
            SuspendLayout();
            // 
            // helpTitleLabel
            // 
            helpTitleLabel.AutoSize = true;
            helpTitleLabel.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            helpTitleLabel.ForeColor = Color.White;
            helpTitleLabel.Location = new Point(126, 9);
            helpTitleLabel.Name = "helpTitleLabel";
            helpTitleLabel.Size = new Size(524, 44);
            helpTitleLabel.TabIndex = 2;
            helpTitleLabel.Text = "Select Your Desired Settings\r\n";
            helpTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // secretCodeComboBox
            // 
            secretCodeComboBox.BackColor = SystemColors.Window;
            secretCodeComboBox.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            secretCodeComboBox.FormattingEnabled = true;
            secretCodeComboBox.Items.AddRange(new object[] { "4", "6", "8" });
            secretCodeComboBox.Location = new Point(497, 87);
            secretCodeComboBox.Name = "secretCodeComboBox";
            secretCodeComboBox.Size = new Size(55, 32);
            secretCodeComboBox.TabIndex = 3;
            secretCodeComboBox.SelectedIndexChanged += secretCodeComboBox_SelectedIndexChanged;
            // 
            // guessComboBox
            // 
            guessComboBox.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            guessComboBox.FormattingEnabled = true;
            guessComboBox.Items.AddRange(new object[] { "8", "10", "12", "14", "16" });
            guessComboBox.Location = new Point(497, 137);
            guessComboBox.Name = "guessComboBox";
            guessComboBox.Size = new Size(55, 32);
            guessComboBox.TabIndex = 4;
            guessComboBox.SelectedIndexChanged += guessComboBox_SelectedIndexChanged;
            // 
            // secretLabel
            // 
            secretLabel.AutoSize = true;
            secretLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            secretLabel.ForeColor = Color.White;
            secretLabel.Location = new Point(227, 87);
            secretLabel.Name = "secretLabel";
            secretLabel.Size = new Size(262, 24);
            secretLabel.TabIndex = 5;
            secretLabel.Text = "Select Secret Code Length";
            // 
            // guessLabel
            // 
            guessLabel.AutoSize = true;
            guessLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            guessLabel.ForeColor = Color.White;
            guessLabel.Location = new Point(225, 137);
            guessLabel.Name = "guessLabel";
            guessLabel.Size = new Size(264, 24);
            guessLabel.TabIndex = 6;
            guessLabel.Text = "Select Number Of Guesses";
            // 
            // playButton
            // 
            playButton.BackColor = Color.MidnightBlue;
            playButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            playButton.FlatAppearance.BorderSize = 0;
            playButton.FlatStyle = FlatStyle.Flat;
            playButton.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            playButton.ForeColor = Color.White;
            playButton.Location = new Point(229, 210);
            playButton.Name = "playButton";
            playButton.Size = new Size(291, 44);
            playButton.TabIndex = 7;
            playButton.Text = "Play Mastermind";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += playButton_Click;
            // 
            // quitButton
            // 
            quitButton.BackColor = Color.MidnightBlue;
            quitButton.FlatAppearance.BorderColor = Color.MidnightBlue;
            quitButton.FlatAppearance.BorderSize = 0;
            quitButton.FlatStyle = FlatStyle.Flat;
            quitButton.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            quitButton.ForeColor = Color.White;
            quitButton.Location = new Point(657, 9);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(70, 44);
            quitButton.TabIndex = 9;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += quitButton_Click;
            // 
            // DifficultyMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 48, 19);
            ClientSize = new Size(739, 266);
            Controls.Add(quitButton);
            Controls.Add(playButton);
            Controls.Add(guessLabel);
            Controls.Add(secretLabel);
            Controls.Add(guessComboBox);
            Controls.Add(secretCodeComboBox);
            Controls.Add(helpTitleLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DifficultyMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Difficulty Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label helpTitleLabel;
        private ComboBox secretCodeComboBox;
        private ComboBox guessComboBox;
        private Label secretLabel;
        private Label guessLabel;
        private Button playButton;
        private Button quitButton;
    }

    partial class CopyOfDifficultyMenu
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
            helpTitleLabel = new Label();
            secretCodeComboBox = new ComboBox();
            guessComboBox = new ComboBox();
            secretLabel = new Label();
            guessLabel = new Label();
            playButton = new Button();
            quitButton = new Button();
            this.SuspendLayout();
            // 
            // helpTitleLabel
            // 
            helpTitleLabel.AutoSize = true;
            helpTitleLabel.Font = new Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            helpTitleLabel.ForeColor = System.Drawing.Color.White;
            helpTitleLabel.Location = new Point(126, 9);
            helpTitleLabel.Name = "helpTitleLabel";
            helpTitleLabel.Size = new Size(524, 44);
            helpTitleLabel.TabIndex = 2;
            helpTitleLabel.Text = "Select Your Desired Settings\r\n";
            helpTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secretCodeComboBox
            // 
            secretCodeComboBox.Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            secretCodeComboBox.FormattingEnabled = true;
            secretCodeComboBox.Items.AddRange(new object[] {
            "4",
            "6",
            "8"});
            secretCodeComboBox.Location = new Point(497, 87);
            secretCodeComboBox.Name = "secretCodeComboBox";
            secretCodeComboBox.Size = new Size(55, 32);
            secretCodeComboBox.TabIndex = 3;
            secretCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.secretCodeComboBox_SelectedIndexChanged);
            // 
            // guessComboBox
            // 
            guessComboBox.Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            guessComboBox.FormattingEnabled = true;
            guessComboBox.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16"});
            guessComboBox.Location = new Point(497, 137);
            guessComboBox.Name = "guessComboBox";
            guessComboBox.Size = new Size(55, 32);
            guessComboBox.TabIndex = 4;
            guessComboBox.SelectedIndexChanged += new System.EventHandler(this.guessComboBox_SelectedIndexChanged);
            // 
            // secretLabel
            // 
            secretLabel.AutoSize = true;
            secretLabel.Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            secretLabel.ForeColor = System.Drawing.Color.White;
            secretLabel.Location = new Point(227, 87);
            secretLabel.Name = "secretLabel";
            secretLabel.Size = new Size(262, 24);
            secretLabel.TabIndex = 5;
            secretLabel.Text = "Select Secret Code Length";
            // 
            // guessLabel
            // 
            guessLabel.AutoSize = true;
            guessLabel.Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            guessLabel.ForeColor = System.Drawing.Color.White;
            guessLabel.Location = new Point(225, 137);
            guessLabel.Name = "guessLabel";
            guessLabel.Size = new Size(264, 24);
            guessLabel.TabIndex = 6;
            guessLabel.Text = "Select Number Of Guesses";
            // 
            // playButton
            // 
            playButton.BackColor = System.Drawing.Color.MidnightBlue;
            playButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            playButton.FlatAppearance.BorderSize = 0;
            playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            playButton.Font = new Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            playButton.ForeColor = System.Drawing.Color.White;
            playButton.Location = new Point(229, 210);
            playButton.Name = "playButton";
            playButton.Size = new Size(291, 44);
            playButton.TabIndex = 7;
            playButton.Text = "Play Mastermind";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // quitButton
            // 
            quitButton.BackColor = System.Drawing.Color.MidnightBlue;
            quitButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            quitButton.FlatAppearance.BorderSize = 0;
            quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            quitButton.Font = new Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            quitButton.ForeColor = System.Drawing.Color.White;
            quitButton.Location = new Point(657, 9);
            quitButton.Name = "quitButton";
            quitButton.Size = new Size(70, 44);
            quitButton.TabIndex = 9;
            quitButton.Text = "Quit";
            quitButton.UseVisualStyleBackColor = false;
            quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // CopyOfDifficultyMenu
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(48)))), ((int)(((byte)(19)))));
            this.ClientSize = new Size(739, 266);
            this.Controls.Add(quitButton);
            this.Controls.Add(playButton);
            this.Controls.Add(guessLabel);
            this.Controls.Add(secretLabel);
            this.Controls.Add(guessComboBox);
            this.Controls.Add(secretCodeComboBox);
            this.Controls.Add(helpTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CopyOfDifficultyMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Difficulty Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label helpTitleLabel;
        private ComboBox secretCodeComboBox;
        private ComboBox guessComboBox;
        private Label secretLabel;
        private Label guessLabel;
        private Button playButton;
        private Button quitButton;
    }
}