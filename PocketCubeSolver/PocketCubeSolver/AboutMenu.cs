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
    public partial class AboutMenu : Form
    {
        public static AboutMenu aboutInstance;

        public Label aboutLabel;
        public Button backButton;
        public Button homeButtonInstance;

        public AboutMenu()
        {
            InitializeComponent();
            aboutInstance = this;

            aboutLabel = label1;
            backButton = BackButton;
            homeButtonInstance = homeButton;
        }

        private void aboutText_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OptionsMenu.optionsInstance.Show();
            this.Hide();
            OptionsMenu.optionsInstance.Activate();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainMenu.mainInstance.Show();
            this.Hide();
            MainMenu.mainInstance.Activate();
        }
    }
}
