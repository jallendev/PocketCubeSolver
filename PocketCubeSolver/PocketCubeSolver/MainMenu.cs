using System;
using System.Windows.Forms;

namespace PocketCubeSolver
{
    public partial class MainMenu : Form
    {
        public static MainMenu mainInstance;
        public static OptionsMenu optionsInstance = new OptionsMenu();
        public static AboutMenu aboutInstance = new AboutMenu();
        public static LanguagesMenu languageInstance = new LanguagesMenu();
        public static HelpMenu helpInstance = new HelpMenu();
        public static Input inputInstance = new Input();
        public static Output outputInstance = new Output();
        

        public Label mainLabel;
        public Label mainLabel2;

        public PictureBox startButtonInstance;
      
        public MainMenu()
        {
            InitializeComponent();
            mainInstance = this;
            mainLabel = menuLabel;
            mainLabel2 = label1;

            startButtonInstance = startButton;


        }

        //Exits the form
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Need a quit command ?
            this.Close();
        }

        //Opens the options menu
        private void option_Click(object sender, EventArgs e)
        {

            OptionsMenu.optionsInstance.Show();
            this.Hide();
            OptionsMenu.optionsInstance.Activate();
        }

        //Opens the Input form
        private void startButton_Click(object sender, EventArgs e)
        {

            Input.inputInstance.Show();
            this.Hide();
            Input.inputInstance.Activate();
        }
    }
}
