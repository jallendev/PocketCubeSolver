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

                MainMenu.mainInstance.mainLabel.Text = "2x2x2 Rubik's Cube Solver";
                //MainMenu.mainInstance.mainLabel2.Text = "Solver";

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
                HelpMenu.helpInstance.helpText.Text = "To operate our project, a user simply needs to run the build (instructions to build the project can be found in the readme-build.txt file), and the main menu will appear. From there, the main menu will be created with English as the default language.  The user can click “Play” to start the permutation solver, and click on the 2D 2x2x2 Rubik’s Cube layout to choose the permutation they want to solve. Once the user is satisfied with the permutation to be solved, the user will click the “Solve!” button to display step by step instructions on how to solve that specific permutation. If the permutation is invalid, the user will be prompted to try to enter another permutation. The user can use these instructions to take their physical Rubik’s Cube and solve it! If the user decides to click on the options menu, found in the main menu, they will be able to click on the “About” button to see more about our team, and our main goal. The user can also click the “Help” button to get instructions on how to operate the application. This will include videos on how to solve a Rubik’s cube, general instructions that help the user navigate the application, and an FAQ section. The user can also click on the “language” menu to immediately change the application’s main language, a feature provided to help it become more accessible to non-english speakers. Finally, if the user chooses, they can click on the “Exit” button at any point of the application to close out of the application.";
                HelpMenu.helpInstance.faqTextBox.Text = "Q: How do you select your permutation? \n" +
"A: You will do so by clicking on the squares in the input menu.The colors will cycle through Blue, Red, Green, Orange, Yellow, and White.There are labels that show how the orientation of the cube should be.Simply, click on the squares until it matches your cube. \n" +
"Q: What are the technical terms for solving the cube? \n" + "A: \n" + "F - Front, D - Back, R - Right, L - Left \n" + "A letter alone means a clockwise rotation while reverse turns are marked with an apostrophe (F') and double turns are marked with 2 (F2)." +
"An example algorithm: F R' U2 (turn the front face clockwise, then the right counterclockwise and do a 180° turn of the up face) \n" + "Q: Should I buy my own cube so I can play along? \n" +
"A: All users are encouraged to buy their own 2x2x2 Rubik’s Cube so that they can physically practice solving the permutations.";
                HelpMenu.helpInstance.instructionsLabelInstance.Text = "Instructions: ";
                HelpMenu.helpInstance.instructionalVideosLabel.Text = "Instructional Videos: ";
                HelpMenu.helpInstance.labelVideo1.Text = "How To Solve a 2x2x2 Rubik's Cube";
                HelpMenu.helpInstance.labelVideo2.Text = "2x2x2 Rubik's Cube Algorithms";
                HelpMenu.helpInstance.labelVideo3.Text = "Solve Rubik's Cube Blindfolded";


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

                MainMenu.mainInstance.mainLabel.Text = "2x2x2 Solveur de Rubik's Cube";
                MainMenu.mainInstance.mainLabel.MaximumSize = new Size(500, 560);
                MainMenu.mainInstance.mainLabel.AutoSize = true;
                
                //MainMenu.mainInstance.mainLabel2.Text = "Cube";

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
                HelpMenu.helpInstance.helpText.Text = "Pour faire fonctionner notre projet, un utilisateur doit simplement exécuter le programme (les instructions pour programmer le projet peuvent être trouvées dans le fichier readme-build.txt), et le menu principal apparaîtra. À partir de là, le menu principal sera affiché en anglais comme langue par défaut. L'utilisateur peut cliquer sur \"Commencer\" pour démarrer le solutionneur de permutation, puis cliquer sur la représentation plane du Rubik's Cube de dimension 2x2x2 pour choisir la permutation qu'il souhaite résoudre. Une fois que l'utilisateur est satisfait de la permutation à résoudre, l'utilisateur cliquera sur \"Résoudre!\" pour afficher des instructions étape par étape sur la façon de résoudre cette permutation spécifique. Si la permutation n'est pas valide, l'utilisateur sera invité à essayer d'entrer une autre permutation. L'utilisateur peut utiliser ces instructions pour prendre son Rubik's Cube physique et le résoudre ! Si l'utilisateur décide de cliquer sur le menu des options, qui se trouve dans le menu principal, il pourra cliquer sur le bouton \"À propos\" pour en savoir plus sur notre équipe et notre objectif principal. L'utilisateur peut également cliquer sur le bouton \"Aide\" pour obtenir des instructions sur la façon d'utiliser l'application. Cela comprendra des vidéos sur la façon de résoudre un Rubik's cube, des instructions générales qui aident l'utilisateur à naviguer dans l'application et une section FAQ. L'utilisateur peut également cliquer sur le menu \"Langue\" pour changer immédiatement la langue principale de l'application, une fonctionnalité prévue pour l'aider à devenir plus accessible aux non-anglophones. Enfin, si l'utilisateur le souhaite, il peut cliquer sur le bouton \"Quitter\" à tout moment pour fermer l'application.";
                HelpMenu.helpInstance.faqTextBox.Text = "Q: Comment sélectionner les permutations ? \n" +
                    "A: Pour changer les permutations il suffit de cliquer sur les carrés du formulaire d'entrée. Les couleurs forment une boucle Bleu, Rouge, Vert, Orange, Jaune et Blanc. Il y a des indications montrant l'orientation du cube. Il faut simplement cliquer sur les carrées jusqu'à ce qu'ils correspondent à votre cube \n" +
                    "Q: Quels sont les termes techniques pour résoudre le cube ? \n" + "A: F - face avant, D - face arrière, R - côté droit, L - côté gauche, U - face supérieure  \n"  
                   + " Une lettre seule signifie qu'il faut tourner cette face dans le sens des aiguilles d'une montre alors qu'une apostrophe indique qu'il faut tournée cette face dans le sens inverse. Une double rotation est indiquée par un 2 (F2). \n"
                   + "Un exemple d'algorithme : F R' U2 (tourner la face avant dans le sens horaire, puis tourner le côté droit dans le sens antihoraire. Enfin tourner la face du dessus de 180°. \n" +
                   "Q: Devrais je acheter mon propre cube pour jouer ?  \n" + "A: Tous les utilisateurs sont encouragés à acheter leur propre Rubik's Cube de dimension 2x2x2 pour pouvoir physiquement résoudre le cube \n";
                HelpMenu.helpInstance.instructionsLabelInstance.Text = "Des instructions:";
                HelpMenu.helpInstance.instructionalVideosLabel.Text = "Vidéo d'instruction: ";
                HelpMenu.helpInstance.labelVideo1.Text = "Comment résoudre un Rubik's Cube 2x2x2";
                HelpMenu.helpInstance.labelVideo2.Text = "Algorithmes Rubik's Cube 2x2x2";
                HelpMenu.helpInstance.labelVideo3.Text = "Résoudre un Rubik's Cube les yeux bandés";

                Input.inputInstance.description.Text = "Cliquez sur un carré pour changer sa couleur";
                Input.inputInstance.top.Text = "Dessus";
                Input.inputInstance.back.Text = "Arrière";
                Input.inputInstance.front.Text = "Avant";
                Input.inputInstance.left.Text = "Côté Gauche";
                Input.inputInstance.left.MaximumSize = new Size(89, 50);
                Input.inputInstance.left.AutoSize = true;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
