using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MastermindAssignment
{
    public partial class HelpMenu : Form
    {
        
        public HelpMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Calls the Back method when the backButton is clicked
        /// </summary
        private void backButton_Click(object sender, EventArgs e)
        {
            Back();
        }
        /// <summary>
        /// Creates a new MainMenu Object, which is shown and hides the Help Menu.
        /// </summary>
        protected virtual void Back()
        {
            MainMenu mainMenu = new();
            mainMenu.Show();
            Hide();
        }
        
    }
}
