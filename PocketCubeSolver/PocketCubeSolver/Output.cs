using System;
using System.Collections;
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
    public partial class Output : Form
    {
        List<int> solution;
        List<int> photos;
        int pos = 0;
        public Output()
        {
            InitializeComponent();
            for (int i = pos; i < solution.Count() || i - pos >= 4; i++)
            {
                photos.Add(choosePhoto(i));
            }
            showPhotos();
        }

        public int choosePhoto(int i)
        {
            int movetype = solution.BinarySearch(i);
            return movetype;
        }

        public void showPhotos()
        {
            pictureBox1.Image = PocketCubeSolver.Properties.Resources.Step3Arrows;
            pictureBox2.Image = PocketCubeSolver.Properties.Resources.Step3Arrows;
            pictureBox3.Image = PocketCubeSolver.Properties.Resources.Step3Arrows;
            pictureBox4.Image = PocketCubeSolver.Properties.Resources.Step3Arrows;
        }

        //Opens the input form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form input = new Input();
            input.Show();
            this.Hide();
            input.Activate();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            photos.Clear();
            pos += 1;
            for (int i = pos; i < solution.Count() || i - pos >= 4; i++)
            {
                photos.Add(choosePhoto(i));
                if (i - pos == 0) label1.Text = ("Step " + i);
                if (i - pos == 1) label2.Text = ("Step " + i);
                if (i - pos == 2) label3.Text = ("Step " + i);
                if (i - pos == 3) label4.Text = ("Step " + i);
            }
            showPhotos();
        }
    }
}
