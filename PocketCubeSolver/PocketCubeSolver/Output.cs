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
        int pos, newpos = 0;
        public Output()
        {
            InitializeComponent();

            for (int i = pos; i < solution.Count() || i - pos >= 4; i++)
            {
                if (i - pos == 0)
                {
                    label1.Text = ("Step " + (i + 1));
                    pictureBox1.Image = choosePhoto(i);
                }
                if (i - pos == 1)
                {
                    label2.Text = ("Step " + (i + 1));
                    pictureBox2.Image = choosePhoto(i);
                }
                if (i - pos == 2)
                {
                    label3.Text = ("Step " + (i + 1));
                    pictureBox2.Image = choosePhoto(i);
                }
                if (i - pos == 3)
                {
                    label4.Text = ("Step " + (i + 1));
                    pictureBox2.Image = choosePhoto(i);
                }
                newpos = i;
            }
            pos = newpos;
        }

        public Bitmap choosePhoto(int movetype)
        {
            if (movetype == 0) return new Bitmap(PocketCubeSolver.Properties.Resources.Step0);
            if (movetype == 1) return new Bitmap(PocketCubeSolver.Properties.Resources.Step1);
            if (movetype == 2) return new Bitmap(PocketCubeSolver.Properties.Resources.Step2);
            if (movetype == 3) return new Bitmap(PocketCubeSolver.Properties.Resources.Step3);
            if (movetype == 4) return new Bitmap(PocketCubeSolver.Properties.Resources.Step4);
            if (movetype == 5) return new Bitmap(PocketCubeSolver.Properties.Resources.Step5);
            if (movetype == 6) return new Bitmap(PocketCubeSolver.Properties.Resources.Step6);
            if (movetype == 7) return new Bitmap(PocketCubeSolver.Properties.Resources.Step7);
            if (movetype == 8) return new Bitmap(PocketCubeSolver.Properties.Resources.Step8);
            if (movetype == 9) return new Bitmap(PocketCubeSolver.Properties.Resources.Step9);
            if (movetype == 10) return new Bitmap(PocketCubeSolver.Properties.Resources.Step10);
            if (movetype == 11) return new Bitmap(PocketCubeSolver.Properties.Resources.Step11);
            return null;
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
            pos += 1;
            for (int i = pos; i < solution.Count() || i - pos >= 4; i++)
            {
                if (i - pos == 0)
                {
                    label1.Text = ("Step " + (i + 1));
                    pictureBox1.Image = choosePhoto(i);
                }
                if (i - pos == 1) 
                { 
                    label2.Text = ("Step " + (i + 1));
                    pictureBox2.Image = choosePhoto(i);
                }
                if (i - pos == 2) 
                { 
                    label3.Text = ("Step " + (i + 1));
                    pictureBox3.Image = choosePhoto(i);
                }
                if (i - pos == 3) 
                {
                    label4.Text = ("Step " + (i + 1));
                    pictureBox4.Image = choosePhoto(i);
                }
                newpos = i;
            }
            pos = newpos;
        }
    }
}
