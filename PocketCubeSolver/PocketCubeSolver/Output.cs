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
        public static Output outputInstance;
        public Output()
        {
            InitializeComponent();
            outputInstance = this;
        }

        //Opens the input form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Input.inputInstance.Show();
            this.Hide();
            Input.inputInstance.Activate();
        }
    }
}
