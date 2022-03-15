using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketCubeSolver
{
    public partial class OptionsMenu : Form
    {
        public static OptionsMenu optionsInstance;
        
        public OptionsMenu()
        {
            InitializeComponent();
            optionsInstance = this;
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {

            HelpMenu.helpInstance.Show();
            this.Hide();
            HelpMenu.helpInstance.Activate();
        }

        private void aboutUsButton_Click(object sender, EventArgs e)
        {

            AboutMenu.aboutInstance.Show();
            this.Hide();
            AboutMenu.aboutInstance.Activate();
        }

        private void languagesButton_Click(object sender, EventArgs e)
        {
            LanguagesMenu.languageInstance.Show();
            this.Hide();
            LanguagesMenu.languageInstance.Activate();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            
            MainMenu.mainInstance.Show();
            this.Hide();
            MainMenu.mainInstance.Activate();
        }
    }
}
