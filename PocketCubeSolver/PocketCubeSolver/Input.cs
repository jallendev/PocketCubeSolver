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
        char[] state = new SolverClasses.CubeState().positions;

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
            String solution = SolverClasses.Solver.solve(new SolverClasses.CubeState(state));
            foreach (char ch in state)
            {
                Console.Write(ch);
                Console.Write(", ");
            }
            Console.WriteLine(solution);
            Output.outputInstance.setSolution(solutionToList(solution));
            Output.outputInstance.Show();
            this.Hide();
            Output.outputInstance.Activate();
        }

        private char colorToChar(Color color)
        {
            if (color == Color.White)
                return 'w';
            if (color == Color.Blue)
                return 'b';
            if (color == Color.Red)
                return 'r';
            if (color == Color.Lime)
                return 'g';
            if (color == Color.FromArgb(255, 128, 0))
                return 'o';
            if (color == Color.Yellow)
                return 'y';
            return 'f';
        }
        
        private List<int> solutionToList(String seq)
        {
            List<int> solution = new List<int>();
            String[] moves = seq.Split(' ');
            foreach (String move in moves)
            {
                switch (move)
                {
                    case "F":
                        solution.Add(4);
                        break;
                    case "F'":
                        solution.Add(5);
                        break;
                    case "U":
                        solution.Add(0);
                        break;
                    case "U'":
                        solution.Add(1);
                        break;
                    case "R":
                        solution.Add(10);
                        break;
                    case "R'":
                        solution.Add(11);
                        break;
                }
            }
            solution.Add(-1);
            return solution;
        }

        //Event handlers for the panel color changes

        private void bottomTL_Click(object sender, EventArgs e)
        {
            Color next = nextColor(bottomTL.BackColor);
            bottomTL.BackColor = next;
            state[16] = colorToChar(next);
        }

        private void bottomTR_Click(object sender, EventArgs e)
        {
            Color next = nextColor(bottomTR.BackColor);
            bottomTR.BackColor = next;
            state[17] = colorToChar(next);
        }

        private void bottomBL_Click(object sender, EventArgs e)
        {
            Color next = nextColor(bottomBL.BackColor);
            bottomBL.BackColor = next;
            state[19] = colorToChar(next);
        }

        private void bottomBR_Click(object sender, EventArgs e)
        {
            Color next = nextColor(bottomBR.BackColor);
            bottomBR.BackColor = next;
            state[18] = colorToChar(next);
        }

        private void leftTL_Click(object sender, EventArgs e)
        {
            Color next = nextColor(leftTL.BackColor);
            leftTL.BackColor = next;
            state[6] = colorToChar(next);
        }

        private void leftTR_Click(object sender, EventArgs e)
        {
            Color next = nextColor(leftTR.BackColor);
            leftTR.BackColor = next;
            state[7] = colorToChar(next);
        }

        private void leftBL_Click(object sender, EventArgs e)
        {
            Color next = nextColor(leftBL.BackColor);
            leftBL.BackColor = next;
            state[5] = colorToChar(next);
        }

        private void leftBR_Click(object sender, EventArgs e)
        {
            Color next = nextColor(leftBR.BackColor);
            leftBR.BackColor = next;
            state[4] = colorToChar(next);
        }

        private void backTL_Click(object sender, EventArgs e)
        {
            Color next = nextColor(backTL.BackColor);
            backTL.BackColor = next;
            state[22] = colorToChar(next);
        }

        private void backTR_Click(object sender, EventArgs e)
        {
            Color next = nextColor(backTR.BackColor);
            backTR.BackColor = next;
            state[23] = colorToChar(next);
        }

        private void backBL_Click(object sender, EventArgs e)
        {
            Color next = nextColor(backBL.BackColor);
            backBL.BackColor = next;
            state[21] = colorToChar(next);
        }

        private void backBR_Click(object sender, EventArgs e)
        {
            Color next = nextColor(backBR.BackColor);
            backBR.BackColor = next;
            state[20] = colorToChar(next);
        }

        private void topTL_Click(object sender, EventArgs e)
        {
            Color next = nextColor(topTL.BackColor);
            topTL.BackColor = next;
            state[0] = colorToChar(next);
        }

        private void topTR_Click(object sender, EventArgs e)
        {
            Color next = nextColor(topTR.BackColor);
            topTR.BackColor = next;
            state[1] = colorToChar(next);
        }

        private void topBL_Click(object sender, EventArgs e)
        {
            Color next = nextColor(topBL.BackColor);
            topBL.BackColor = next;
            state[3] = colorToChar(next);
        }

        private void topBR_Click(object sender, EventArgs e)
        {
            Color next = nextColor(topBR.BackColor);
            topBR.BackColor = next;
            state[2] = colorToChar(next);
        }

        private void rightTL_Click(object sender, EventArgs e)
        {
            Color next = nextColor(rightTL.BackColor);
            rightTL.BackColor = next;
            state[13] = colorToChar(next);
        }

        private void rightTR_Click(object sender, EventArgs e)
        {
            Color next = nextColor(rightTR.BackColor);
            rightTR.BackColor = next;
            state[14] = colorToChar(next);
        }

        private void rightBL_Click(object sender, EventArgs e)
        {
            Color next = nextColor(rightBL.BackColor);
            rightBL.BackColor = next;
            state[12] = colorToChar(next);
        }

        private void rightBR_Click(object sender, EventArgs e)
        {
            Color next = nextColor(rightBR.BackColor);
            rightBR.BackColor = next;
            state[15] = colorToChar(next);
        }

        private void frontTL_Click(object sender, EventArgs e)
        {
            Color next = nextColor(frontTL.BackColor);
            frontTL.BackColor = next;
            state[8] = colorToChar(next);
        }

        private void frontTR_Click(object sender, EventArgs e)
        {
            Color next = nextColor(frontTR.BackColor);
            frontTR.BackColor = next;
            state[9] = colorToChar(next);
        }

        private void frontBL_Click(object sender, EventArgs e)
        {
            Color next = nextColor(frontBL.BackColor);
            frontBL.BackColor = next;
            state[11] = colorToChar(next);
        }

        private void frontBR_Click(object sender, EventArgs e)
        {
            Color next = nextColor(frontBR.BackColor);
            frontBR.BackColor = next;
            state[10] = colorToChar(next);
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
