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

                OptionsMenu.optionsInstance.optionLabel.Text = "Options";
                OptionsMenu.optionsInstance.helpButton.Image = Properties.Resources.Help;
                OptionsMenu.optionsInstance.aboutButton.Image = Properties.Resources.AboutUs;
                OptionsMenu.optionsInstance.languageButton.Image = Properties.Resources.Languages;
                OptionsMenu.optionsInstance.mainMenuButtonInstance.Image = Properties.Resources.MainMenuButton;

                AboutMenu.aboutInstance.aboutLabel.Text = "About Us";
                AboutMenu.aboutInstance.homeButtonInstance.Text = "Home";
                AboutMenu.aboutInstance.backButton.Text = "Back";

                HelpMenu.helpInstance.helpLabel.Text = "Help!";
                HelpMenu.helpInstance.backButton.Text = "Back";
                HelpMenu.helpInstance.homeButtonInstance.Text = "Home";

                Input.inputInstance.description.Text = "Click on a square below to change its' color";
                Input.inputInstance.top.Text = "Top Side";
                Input.inputInstance.back.Text = "Back Side";
                Input.inputInstance.front.Text = "Front Side";
                Input.inputInstance.left.Text = "Left Side";
                Input.inputInstance.right.Text = "Right Side";
                Input.inputInstance.bottom.Text = "Bottom Side";
                Input.inputInstance.solveButton.Text = "Solve!";
                Input.inputInstance.homeButtonInstance.Text = "Home";

                Output.outputInstance.backButton.Text = "Back";


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

                MainMenu.mainInstance.startButtonInstance.Image = Properties.Resources.commencerbutton;
                MainMenu.mainInstance.optionButtonInstance.Image = Properties.Resources.Option;
                MainMenu.mainInstance.exitButtonInstance.Image = Properties.Resources.exitButtonFrench;

                OptionsMenu.optionsInstance.optionLabel.Text = "Options";
                OptionsMenu.optionsInstance.helpButton.Image = Properties.Resources.helpFrench;
                OptionsMenu.optionsInstance.aboutButton.Image = Properties.Resources.aboutUsFrench;
                OptionsMenu.optionsInstance.languageButton.Image = Properties.Resources.languageFrench;
                OptionsMenu.optionsInstance.mainMenuButtonInstance.Image = Properties.Resources.mainmenuFrench;

                AboutMenu.aboutInstance.aboutLabel.Text = "À propos";
                AboutMenu.aboutInstance.homeButtonInstance.Text = "Accueil";
                AboutMenu.aboutInstance.backButton.Text = "Retour";

                HelpMenu.helpInstance.helpLabel.Text = "Aide!";
                HelpMenu.helpInstance.backButton.Text = "Retour";
                HelpMenu.helpInstance.homeButtonInstance.Text = "Accueil";

                Input.inputInstance.description.Text = "Cliquez sur un carré pour changer sa couleur";
                Input.inputInstance.top.Text = "Dessus";
                Input.inputInstance.back.Text = "Arrière";
                Input.inputInstance.front.Text = "Avant";
                Input.inputInstance.left.Text = "Côté Gauche";
                Input.inputInstance.right.Text = "Côté droit";
                Input.inputInstance.bottom.Text = "Dessous";
                Input.inputInstance.solveButton.Text = "Résoudre";
                Input.inputInstance.homeButtonInstance.Text = "Accueil";

                Output.outputInstance.backButton.Text = "Retour";

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
