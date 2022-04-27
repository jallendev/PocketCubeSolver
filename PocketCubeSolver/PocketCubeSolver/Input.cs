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
    public partial class Input : Form
    {
        public static Input inputInstance;

        public Label description;
        public Label bottom;
        public Label left;
        public Label right;
        public Label top;
        public Label front;
        public Label back;

        public Button solveButton;
        public Button homeButtonInstance;
        // Colors of the rubix cube
        Color[] colors = new Color[] { Color.White, Color.Blue, Color.Red, Color.Lime, Color.FromArgb(255, 128, 0), Color.Yellow };
        public Input()
        {
            InitializeComponent();
            inputInstance = this;

            description = instructions;
            bottom = labelBottom;
            left = labelLeft;
            right = labelRight;
            top = labelTop;
            front = labelFront;
            back = labelBack;

            solveButton = buttonSolve;
            homeButtonInstance = homeButton;
        }

        // Picks the next color, from the array colors, of cube when clicked on by user
        public Color nextColor(Color currentColor)
        {
            int currColor = 0;
            for (int count = 0; count < colors.Length; count++)
            {
                if (colors[count] == currentColor)
                {
                    currColor = count;
                }
            }
            ++currColor;
            if (currColor >= colors.Length)
                currColor = 0;
            return colors[currColor];
        }

        // Sends the user to the output form by clicking the "Solve" button
        private void buttonSolve_Click(object sender, EventArgs e)
        {
            //Form output = new Output();
            //output.Show();
            //this.Hide();
            //output.Activate();

            Output.outputInstance.Show();
            this.Hide();
            Output.outputInstance.Activate();
        }

        //Event handlers for the panel color changes

        private void bottomTL_Click(object sender, EventArgs e)
        {
            bottomTL.BackColor = nextColor(bottomTL.BackColor);
        }

        private void bottomTR_Click(object sender, EventArgs e)
        {
            bottomTR.BackColor = nextColor(bottomTR.BackColor);
        }

        private void bottomBL_Click(object sender, EventArgs e)
        {
            bottomBL.BackColor = nextColor(bottomBL.BackColor);
        }

        private void bottomBR_Click(object sender, EventArgs e)
        {
            bottomBR.BackColor = nextColor(bottomBR.BackColor);
        }

        private void leftTL_Click(object sender, EventArgs e)
        {
            leftTL.BackColor = nextColor(leftTL.BackColor);
        }

        private void leftTR_Click(object sender, EventArgs e)
        {
            leftTR.BackColor = nextColor(leftTR.BackColor);
        }

        private void leftBL_Click(object sender, EventArgs e)
        {
            leftBL.BackColor = nextColor(leftBL.BackColor);
        }

        private void leftBR_Click(object sender, EventArgs e)
        {
            leftBR.BackColor = nextColor(leftBR.BackColor);
        }

        private void backTL_Click(object sender, EventArgs e)
        {
            backTL.BackColor = nextColor(backTL.BackColor);
        }

        private void backTR_Click(object sender, EventArgs e)
        {
            backTR.BackColor = nextColor(backTR.BackColor);
        }

        private void backBL_Click(object sender, EventArgs e)
        {
            backBL.BackColor = nextColor(backBL.BackColor);
        }

        private void backBR_Click(object sender, EventArgs e)
        {
            backBR.BackColor = nextColor(backBR.BackColor);
        }

        private void topTL_Click(object sender, EventArgs e)
        {
            topTL.BackColor = nextColor(topTL.BackColor);
        }

        private void topTR_Click(object sender, EventArgs e)
        {
            topTR.BackColor = nextColor(topTR.BackColor);
        }

        private void topBL_Click(object sender, EventArgs e)
        {
            topBL.BackColor = nextColor(topBL.BackColor);
        }

        private void topBR_Click(object sender, EventArgs e)
        {
            topBR.BackColor = nextColor(topBR.BackColor);
        }

        private void rightTL_Click(object sender, EventArgs e)
        {
            rightTL.BackColor = nextColor(rightTL.BackColor);
        }

        private void rightTR_Click(object sender, EventArgs e)
        {
            rightTR.BackColor = nextColor(rightTR.BackColor);
        }

        private void rightBL_Click(object sender, EventArgs e)
        {
            rightBL.BackColor = nextColor(rightBL.BackColor);
        }

        private void rightBR_Click(object sender, EventArgs e)
        {
            rightBR.BackColor = nextColor(rightBR.BackColor);
        }

        private void frontTL_Click(object sender, EventArgs e)
        {
            frontTL.BackColor = nextColor(frontTL.BackColor);
        }

        private void frontTR_Click(object sender, EventArgs e)
        {
            frontTR.BackColor = nextColor(frontTR.BackColor);
        }

        private void frontBL_Click(object sender, EventArgs e)
        {
            frontBL.BackColor = nextColor(frontBL.BackColor);
        }

        private void frontBR_Click(object sender, EventArgs e)
        {
            frontBR.BackColor = nextColor(frontBR.BackColor);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            MainMenu.mainInstance.Show();
            this.Hide();
            MainMenu.mainInstance.Activate();
        }

        private void instructions_Click(object sender, EventArgs e)
        {

        }

        private void labelRight_Click(object sender, EventArgs e)
        {

        }

        private void labelLeft_Click(object sender, EventArgs e)
        {

        }
    }
}
