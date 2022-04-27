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
    public partial class LanguagesMenu : Form
    {
        public static LanguagesMenu languageInstance;
        
        public LanguagesMenu()
        {
            InitializeComponent();
            languageInstance = this;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {

            MainMenu.mainInstance.Show();
            this.Hide();
            MainMenu.mainInstance.Activate();
           
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OptionsMenu.optionsInstance.Show();
            this.Hide();
            OptionsMenu.optionsInstance.Activate();
        }

        private void languageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = languageBox.Text;

            String language = languageBox.Text;

            if (language.Equals("English"))
            {
                label1.Text = "Language: ";
                label2.Text = "Select Language: ";
                label3.Text = "English";
                homeButton.Text = "Home";
                BackButton.Text = "Back";

                MainMenu.mainInstance.mainLabel.Text = "2x2 Rubik's Cube";
                MainMenu.mainInstance.mainLabel2.Text = "Solver";

                MainMenu.mainInstance.startButtonInstance.Image = Properties.Resources.Start;
                MainMenu.mainInstance.optionButtonInstance.Image = Properties.Resources.Option;
                MainMenu.mainInstance.exitButtonInstance.Image = Properties.Resources.Exit;
             

            }
            else if (language.Equals("French"))
            {
                label1.Text = "Language: ";
                label2.Text = "Selectionner Langue: ";
                label3.Text = "Français";
                homeButton.Text = "Accueil";
                BackButton.Text = "Retour";

                MainMenu.mainInstance.mainLabel.Text = "Solveur de Rubik's";
                MainMenu.mainInstance.mainLabel2.Text = "Cube";

                MainMenu.mainInstance.startButtonInstance.Image = Properties.Resources.frenchStartButton;
                MainMenu.mainInstance.optionButtonInstance.Image = Properties.Resources.Option;
                MainMenu.mainInstance.exitButtonInstance.Image = Properties.Resources.exitButtonFrench;
                //MainMenu.mainInstance.Show();
            }
            else if (language.Equals("Spanish"))
            {
                label1.Text = "Idioma: ";
                label2.Text = "Seleccionar Idioma: ";
                label3.Text = "Español";
                homeButton.Text = "Casa";
                BackButton.Text = "Regresa";


            }

        }


        private void LanguagesMenu_Load(object sender, EventArgs e)
        {
            //languageBox.SelectedIndex = 1;
        }
    }
}
