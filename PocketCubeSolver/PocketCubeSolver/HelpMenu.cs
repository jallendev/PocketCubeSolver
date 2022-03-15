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
        public HelpMenu()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
            mainMenu.Activate();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form optionsMenu = new OptionsMenu();
            optionsMenu.Show();
            this.Hide();
            optionsMenu.Activate();
        }
    }
}
