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
    public partial class Output : Form
    {
        int x;
        int y;

        public Output()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black);

            if (listBox1.SelectedIndex == 0)
            {
                SolidBrush sb = new SolidBrush(Color.Red);
                g.DrawEllipse(p, x - 50, y - 50, 100, 100);
                g.FillEllipse(sb, x - 50, y - 50, 100, 100);

            }
            if (listBox1.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(Color.Blue);
                g.DrawRectangle(p, x - 50, y - 50, 100, 100);
                g.FillRectangle(sb, x - 50, y - 50, 100, 100);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Point p = new Point(MousePosition.X, MousePosition.Y);
            x = p.X;
            y = p.Y;
            panel1.Invalidate();
        }

        private void Output_Load(object sender, EventArgs e)
        {

        }
    }
}
