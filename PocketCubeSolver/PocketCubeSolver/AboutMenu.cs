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
        public AboutMenu()
        {
            InitializeComponent();
        }

        private void aboutText_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form optionsMenu = new OptionsMenu();
            optionsMenu.Show();
            this.Hide();
            optionsMenu.Activate();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
            mainMenu.Activate();
        }
    }
}
