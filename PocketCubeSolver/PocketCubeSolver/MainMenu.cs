using System;
using System.Windows.Forms;

namespace PocketCubeSolver
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Need a quit command ?
            this.Hide();
        }

        private void option_Click(object sender, EventArgs e)
        {
            Form option = new OptionsMenu();
            option.Show();
            this.Hide();
            option.Activate();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form input = new Input();
            input.Show();
            this.Hide();
            input.Activate();
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rubikscube_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
