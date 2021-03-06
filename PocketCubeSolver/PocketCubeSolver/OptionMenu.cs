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
    public partial class OptionMenu : Form
    {
        public OptionMenu()
        {
            InitializeComponent();
        }

        //Opens the main menu
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Form mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
            mainMenu.Activate();
        }
    }
}
