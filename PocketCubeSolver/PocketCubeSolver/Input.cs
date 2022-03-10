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
        // Colors of the rubix cube
        Color[] colors = new Color[] { Color.White, Color.Blue, Color.Red, Color.Lime, Color.FromArgb(255, 128, 0), Color.Yellow };
        int[] intColors = new int[] { 2, 3, 5, 7, 11, 13 };
        int[] position = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
        int[] orientation = new int[] {0, 0, 0, 0, 0, 0, 0, 0};
        List<int> solution = new List<int>();

        public Input()
        {
            InitializeComponent();
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
            int status = LoadPermutation();

            foreach (var item in position)
            {
                Console.WriteLine(item.ToString());
            }

            Form output = new Output();
            output.Show();
            this.Hide();
            output.Activate();
        }

        private void whiteFace()
        {
            //inserting cubie 1
        }

        private int LoadPermutation()
        {
            int sum = 0;

            //position 0
            sum += colorToInt(topTR.BackColor);
            sum += colorToInt(backBR.BackColor);
            sum += colorToInt(rightTL.BackColor);

            if (findCubie(sum) == -1)
            {
                return -1;
            }
            else
            {
                position[0] = findCubie(sum);
            }
            sum = 0;

            //position 1
            sum += colorToInt(topTL.BackColor);
            sum += colorToInt(backBL.BackColor);
            sum += colorToInt(leftBR.BackColor);

            if (findCubie(sum) == -1)
            {
                return -1;
            }
            else
            {
                position[1] = findCubie(sum);
            }
            sum = 0;

            //position 2
            sum += colorToInt(topBL.BackColor);
            sum += colorToInt(frontTL.BackColor);
            sum += colorToInt(leftBL.BackColor);

            if (findCubie(sum) == -1)
            {
                return -1;
            }
            else
            {
                position[2] = findCubie(sum);
            }
            sum = 0;

            //position 3
            sum += colorToInt(topBR.BackColor);
            sum += colorToInt(rightBL.BackColor);
            sum += colorToInt(frontTL.BackColor);

            if (findCubie(sum) == -1)
            {
                return -1;
            }
            else
            {
                position[3] = findCubie(sum);
            }
            sum = 0;

            //position 4
            sum += colorToInt(bottomBR.BackColor);
            sum += colorToInt(backTR.BackColor);
            sum += colorToInt(rightTR.BackColor);

            if (findCubie(sum) == -1)
            {
                return -1;
            }
            else
            {
                position[4] = findCubie(sum);
            }
            sum = 0;

            //position 5
            sum += colorToInt(bottomBL.BackColor);
            sum += colorToInt(backTL.BackColor);
            sum += colorToInt(leftTR.BackColor);

            if (findCubie(sum) == -1)
            {
                return -1;
            }
            else
            {
                position[5] = findCubie(sum);
            }
            sum = 0;

            //position 6
            sum += colorToInt(bottomTL.BackColor);
            sum += colorToInt(leftTL.BackColor);
            sum += colorToInt(frontBL.BackColor);

            if (findCubie(sum) == -1)
            {
                return -1;
            }
            else
            {
                position[6] = findCubie(sum);
            }
            sum = 0;

            //position 7
            sum += colorToInt(bottomTR.BackColor);
            sum += colorToInt(rightBR.BackColor);
            sum += colorToInt(frontBR.BackColor);

            if (findCubie(sum) == -1)
            {
                return -1;
            }
            else
            {
                position[7] = findCubie(sum);
            }
            sum = 0;

            return 0;
        }

        private int colorToInt(Color test)
        {
            for (int color = 0; color < colors.Length; ++color){
                if (colors[color].Equals(test))
                {
                    return intColors[color];
                }
            }
            return 100;
        }

        private int findCubie(int sum)
        {
            switch (sum)
            {
                case (10):
                    return 0;
                case (16):
                    return 1;
                case (20):
                    return 2;
                case (14):
                    return 3;
                case (21):
                    return 4;
                case (27):
                    return 5;
                case (31):
                    return 6;
                case (25):
                    return 7;
                default:
                    return -1;
            }
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
    }
}
