﻿using System;
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
        public OptionsMenu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsButton_Click(object sender, EventArgs e)
        {

        }

        private void languagesButton_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Form mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
            mainMenu.Activate();
        }
    }
}