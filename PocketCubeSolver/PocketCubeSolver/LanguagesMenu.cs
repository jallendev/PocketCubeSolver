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
        
        public LanguagesMenu()
        {
            InitializeComponent();
            
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Form mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
            mainMenu.Activate();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form optionsMenu = new OptionsMenu();
            optionsMenu.Show();
            this.Hide();
            optionsMenu.Activate();
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


            }
            else if (language.Equals("French"))
            {
                label1.Text = "Language: ";
                label2.Text = "Selectionner Langue: ";
                label3.Text = "Français";
                homeButton.Text = "Accueil";
                BackButton.Text = "Retour";

                MainMenu.testInstance.testLabel.Text = "FRENCH";
                MainMenu.testInstance.Show();
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
