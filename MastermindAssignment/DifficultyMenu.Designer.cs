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
            this.helpTitleLabel = new System.Windows.Forms.Label();
            this.secretCodeComboBox = new System.Windows.Forms.ComboBox();
            this.guessComboBox = new System.Windows.Forms.ComboBox();
            this.secretLabel = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpTitleLabel
            // 
            this.helpTitleLabel.AutoSize = true;
            this.helpTitleLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpTitleLabel.ForeColor = System.Drawing.Color.White;
            this.helpTitleLabel.Location = new System.Drawing.Point(126, 9);
            this.helpTitleLabel.Name = "helpTitleLabel";
            this.helpTitleLabel.Size = new System.Drawing.Size(524, 44);
            this.helpTitleLabel.TabIndex = 2;
            this.helpTitleLabel.Text = "Select Your Desired Settings\r\n";
            this.helpTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secretCodeComboBox
            // 
            this.secretCodeComboBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secretCodeComboBox.FormattingEnabled = true;
            this.secretCodeComboBox.Items.AddRange(new object[] {
            "4",
            "6",
            "8"});
            this.secretCodeComboBox.Location = new System.Drawing.Point(497, 87);
            this.secretCodeComboBox.Name = "secretCodeComboBox";
            this.secretCodeComboBox.Size = new System.Drawing.Size(55, 32);
            this.secretCodeComboBox.TabIndex = 3;
            this.secretCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.secretCodeComboBox_SelectedIndexChanged);
            // 
            // guessComboBox
            // 
            this.guessComboBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessComboBox.FormattingEnabled = true;
            this.guessComboBox.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16"});
            this.guessComboBox.Location = new System.Drawing.Point(497, 137);
            this.guessComboBox.Name = "guessComboBox";
            this.guessComboBox.Size = new System.Drawing.Size(55, 32);
            this.guessComboBox.TabIndex = 4;
            this.guessComboBox.SelectedIndexChanged += new System.EventHandler(this.guessComboBox_SelectedIndexChanged);
            // 
            // secretLabel
            // 
            this.secretLabel.AutoSize = true;
            this.secretLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secretLabel.ForeColor = System.Drawing.Color.White;
            this.secretLabel.Location = new System.Drawing.Point(227, 87);
            this.secretLabel.Name = "secretLabel";
            this.secretLabel.Size = new System.Drawing.Size(262, 24);
            this.secretLabel.TabIndex = 5;
            this.secretLabel.Text = "Select Secret Code Length";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessLabel.ForeColor = System.Drawing.Color.White;
            this.guessLabel.Location = new System.Drawing.Point(225, 137);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(264, 24);
            this.guessLabel.TabIndex = 6;
            this.guessLabel.Text = "Select Number Of Guesses";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(229, 210);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(291, 44);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "Play Mastermind";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(657, 9);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(70, 44);
            this.quitButton.TabIndex = 9;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // DifficultyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(48)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(739, 266);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.secretLabel);
            this.Controls.Add(this.guessComboBox);
            this.Controls.Add(this.secretCodeComboBox);
            this.Controls.Add(this.helpTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DifficultyMenu";
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
            this.helpTitleLabel = new System.Windows.Forms.Label();
            this.secretCodeComboBox = new System.Windows.Forms.ComboBox();
            this.guessComboBox = new System.Windows.Forms.ComboBox();
            this.secretLabel = new System.Windows.Forms.Label();
            this.guessLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helpTitleLabel
            // 
            this.helpTitleLabel.AutoSize = true;
            this.helpTitleLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpTitleLabel.ForeColor = System.Drawing.Color.White;
            this.helpTitleLabel.Location = new System.Drawing.Point(126, 9);
            this.helpTitleLabel.Name = "helpTitleLabel";
            this.helpTitleLabel.Size = new System.Drawing.Size(524, 44);
            this.helpTitleLabel.TabIndex = 2;
            this.helpTitleLabel.Text = "Select Your Desired Settings\r\n";
            this.helpTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secretCodeComboBox
            // 
            this.secretCodeComboBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secretCodeComboBox.FormattingEnabled = true;
            this.secretCodeComboBox.Items.AddRange(new object[] {
            "4",
            "6",
            "8"});
            this.secretCodeComboBox.Location = new System.Drawing.Point(497, 87);
            this.secretCodeComboBox.Name = "secretCodeComboBox";
            this.secretCodeComboBox.Size = new System.Drawing.Size(55, 32);
            this.secretCodeComboBox.TabIndex = 3;
            this.secretCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.secretCodeComboBox_SelectedIndexChanged);
            // 
            // guessComboBox
            // 
            this.guessComboBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessComboBox.FormattingEnabled = true;
            this.guessComboBox.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16"});
            this.guessComboBox.Location = new System.Drawing.Point(497, 137);
            this.guessComboBox.Name = "guessComboBox";
            this.guessComboBox.Size = new System.Drawing.Size(55, 32);
            this.guessComboBox.TabIndex = 4;
            this.guessComboBox.SelectedIndexChanged += new System.EventHandler(this.guessComboBox_SelectedIndexChanged);
            // 
            // secretLabel
            // 
            this.secretLabel.AutoSize = true;
            this.secretLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secretLabel.ForeColor = System.Drawing.Color.White;
            this.secretLabel.Location = new System.Drawing.Point(227, 87);
            this.secretLabel.Name = "secretLabel";
            this.secretLabel.Size = new System.Drawing.Size(262, 24);
            this.secretLabel.TabIndex = 5;
            this.secretLabel.Text = "Select Secret Code Length";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessLabel.ForeColor = System.Drawing.Color.White;
            this.guessLabel.Location = new System.Drawing.Point(225, 137);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(264, 24);
            this.guessLabel.TabIndex = 6;
            this.guessLabel.Text = "Select Number Of Guesses";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(229, 210);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(291, 44);
            this.playButton.TabIndex = 7;
            this.playButton.Text = "Play Mastermind";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(657, 9);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(70, 44);
            this.quitButton.TabIndex = 9;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // CopyOfDifficultyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(48)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(739, 266);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.secretLabel);
            this.Controls.Add(this.guessComboBox);
            this.Controls.Add(this.secretCodeComboBox);
            this.Controls.Add(this.helpTitleLabel);
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