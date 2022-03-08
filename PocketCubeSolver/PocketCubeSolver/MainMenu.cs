﻿using System;
using System.Windows.Forms;

namespace PocketCubeSolver
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //Exits the form
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Need a quit command ?
            this.Hide();
        }

        //Opens the options menu
        private void option_Click(object sender, EventArgs e)
        {
            Form option = new OptionsMenu();
            option.Show();
            this.Hide();
            option.Activate();
        }

        //Opens the Input form
        private void startButton_Click(object sender, EventArgs e)
        {
            Form input = new Input();
            input.Show();
            this.Hide();
            input.Activate();
        }
    }
}
