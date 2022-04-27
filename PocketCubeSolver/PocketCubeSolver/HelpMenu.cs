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
        public TextBox helpText;
        public Button backButton;
        public Button homeButtonInstance;
        public HelpMenu()
        {
            InitializeComponent();
            helpInstance = this;

            helpLabel = label1;
            backButton = BackButton;
            homeButtonInstance = homeButton;
            helpText = instructionsText;
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

        private void HelpMenu_Load(object sender, EventArgs e)
        {

        }

        private void video1Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.video1Link.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=bCn8TajrPqc");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void video2Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.video1Link.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=1Z8-p6szLUY");
        }

        private void video3Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.video1Link.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=7pHnmNeoJkQ");
        }
    }
}
