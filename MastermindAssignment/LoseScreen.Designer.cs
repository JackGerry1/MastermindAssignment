namespace MastermindAssignment
{
    partial class LoseScreen
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
            this.loseTitleLabel = new System.Windows.Forms.Label();
            this.loseLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loseTitleLabel
            // 
            this.loseTitleLabel.AutoSize = true;
            this.loseTitleLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loseTitleLabel.ForeColor = System.Drawing.Color.White;
            this.loseTitleLabel.Location = new System.Drawing.Point(190, 9);
            this.loseTitleLabel.Name = "loseTitleLabel";
            this.loseTitleLabel.Size = new System.Drawing.Size(310, 56);
            this.loseTitleLabel.TabIndex = 3;
            this.loseTitleLabel.Text = "Lose Screen\r\n";
            this.loseTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loseLabel
            // 
            this.loseLabel.AutoSize = true;
            this.loseLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loseLabel.ForeColor = System.Drawing.Color.White;
            this.loseLabel.Location = new System.Drawing.Point(46, 77);
            this.loseLabel.Name = "loseLabel";
            this.loseLabel.Size = new System.Drawing.Size(586, 72);
            this.loseLabel.TabIndex = 4;
            this.loseLabel.Text = "Unfortunately you didn\'t guess the code, \r\nwould you wish to play again?\r\n";
            this.loseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.playAgainButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.playAgainButton.FlatAppearance.BorderSize = 0;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgainButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playAgainButton.ForeColor = System.Drawing.Color.White;
            this.playAgainButton.Location = new System.Drawing.Point(240, 170);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(192, 44);
            this.playAgainButton.TabIndex = 9;
            this.playAgainButton.Text = "Play Again\r\n";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(240, 235);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(192, 44);
            this.quitButton.TabIndex = 10;
            this.quitButton.Text = "Quit Game\r\n";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // LoseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(48)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(664, 314);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.loseLabel);
            this.Controls.Add(this.loseTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lose Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label loseTitleLabel;
        private Label loseLabel;
        private Button playAgainButton;
        private Button quitButton;
    }
}