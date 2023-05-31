namespace MastermindAssignment
{
    partial class InheritedHelpMenu
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
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.Location = new System.Drawing.Point(182, 629);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(606, 12);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(70, 44);
            this.quitButton.TabIndex = 12;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            // 
            // InheritedHelpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 685);
            this.Name = "InheritedHelpMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button quitButton;
    }
}