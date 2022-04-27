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
    public partial class HelpMenu : Form
    {
        public static HelpMenu helpInstance;

        public Label helpLabel;
        public Button backButton;
        public Button homeButtonInstance;
        public HelpMenu()
        {
            InitializeComponent();
            helpInstance = this;

            helpLabel = label1;
            backButton = BackButton;
            homeButtonInstance = homeButton;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainMenu.mainInstance.Show();
            this.Hide();
            MainMenu.mainInstance.Activate();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OptionsMenu.optionsInstance.Show();
            this.Hide();
            OptionsMenu.optionsInstance.Activate();
        }
    }
}
