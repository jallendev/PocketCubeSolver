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
                AboutMenu.aboutInstance.aboutDescription.Text = "Our team was formed during the Spring 2022 semester at the University of Oklahoma while taking the class Human Computer Interaction (CS 4063), instructed by Christopher Weaver. The team includes computer science students Joseph Allen, Gwen Delestre, Samson Olivero, and Jay Shoumaker. Our goal for this project was to create a 2x2x2 Rubik’s Cube permutation solver that educates complex mathematical algorithms in a fun way while also encouraging retention of the concepts. Through this, we created a UI that allows users to insert different permutations, using a flat 2D model of a 2x2x2 cube, and click “Solve!” to display a series of images that offer a step-by-step solution to the inputted permutation. We also wanted to increase our range of audience, as we originally had a native Spanish and French speaking student in our group. Thus, we implemented a Language feature that allows users to select their desired language between French, Spanish, and English. Unfortunately, before we could implement the series of Spanish menus, our group member that spoke Spanish had left the group. As a result, only parts of the Spanish Language feature had been created. Finally, our team is excited to implement newer features in the future, including a 3D model of the Rubik’s cube as well as corresponding animations. In this process, we have learned and created a project that we are proud to demonstrate, and we hope you enjoy our application. Happy Cube Solving!";
                AboutMenu.aboutInstance.github.Text = "Github Repository";

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
                AboutMenu.aboutInstance.aboutDescription.Text = "Notre équipe s'est formée pendant le semestre de Printemps 2022 à l'Université d'Oklahoma pendant que nous suivions le cours d'Interaction Homme-Machine (CS 4063) de M. Christopher Weaver." +
                    "Cette équipe comprend les étudiants en Informatique Joseph Allen, Gwen Delestre, Samson Olivero et Jay Shoumaker. Notre but pour ce projet était de créer un solutionneur de Rubik's Cube de taille 2x2x2 qui instruit des algorithmes mathématiques complexes tout en étant amusant et en permettant d'apprendre les différentes façon de résoudre le cube. " +
                    "Nous avons donc créer une interface utilisateur qui permette aux utilisateurs d'entrer différente permutations en utilisant une vue plane du cube de dimension 2x2x2." +
                    "En cliquant sur \"Résoudre\", une série d'images apparaît avec la solution étape par étape. Nous avons aussi voulu élargir notre audience d'utilisateur car nous avions, au début de notre projet, une équipe composer d'un étudiant hispanophone et d'une étudiante francophone." +
                    "Ainsi nous avons implémenté une fonctionnalité permettant de changer la langue de l'application entre Français, Espagnol et Anglais. Malheureusement, l'hispanophone a quitté notre groupe avant que nous puissions traduire l'application en Espagnol. Par conséquent, seulement une partie de nos fonctionnalités est disponible en Espagnol. Enfin, notre équipe est ravie de mettre en œuvre de nouvelles fonctionnalités à l'avenir, notamment un modèle 3D du Rubik's Cube ainsi que les animations correspondantes. Dans ce processus nous avons appris et créer un projet que nous sommes fière de montrer et nous espérons que vous apprécierez l'application. Bonne résolution de cube";
                AboutMenu.aboutInstance.github.Text = "Dépôt Github";

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
