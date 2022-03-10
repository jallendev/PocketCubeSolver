
namespace PocketCubeSolver
{
    partial class OptionsMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutUsButton = new System.Windows.Forms.PictureBox();
            this.mainMenuButton = new System.Windows.Forms.PictureBox();
            this.languagesButton = new System.Windows.Forms.PictureBox();
            this.HelpButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutUsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.HelpButton);
            this.panel1.Controls.Add(this.languagesButton);
            this.panel1.Controls.Add(this.mainMenuButton);
            this.panel1.Controls.Add(this.aboutUsButton);
            this.panel1.Location = new System.Drawing.Point(288, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 327);
            this.panel1.TabIndex = 6;
            // 
            // aboutUsButton
            // 
            this.aboutUsButton.Image = global::PocketCubeSolver.Properties.Resources.AboutUs;
            this.aboutUsButton.Location = new System.Drawing.Point(14, 136);
            this.aboutUsButton.Name = "aboutUsButton";
            this.aboutUsButton.Size = new System.Drawing.Size(170, 50);
            this.aboutUsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.aboutUsButton.TabIndex = 0;
            this.aboutUsButton.TabStop = false;
            this.aboutUsButton.Click += new System.EventHandler(this.aboutUsButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Image = global::PocketCubeSolver.Properties.Resources.MainMenuButton;
            this.mainMenuButton.Location = new System.Drawing.Point(14, 248);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(170, 50);
            this.mainMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mainMenuButton.TabIndex = 1;
            this.mainMenuButton.TabStop = false;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // languagesButton
            // 
            this.languagesButton.Image = global::PocketCubeSolver.Properties.Resources.Languages;
            this.languagesButton.Location = new System.Drawing.Point(14, 192);
            this.languagesButton.Name = "languagesButton";
            this.languagesButton.Size = new System.Drawing.Size(170, 50);
            this.languagesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.languagesButton.TabIndex = 2;
            this.languagesButton.TabStop = false;
            this.languagesButton.Click += new System.EventHandler(this.languagesButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Image = global::PocketCubeSolver.Properties.Resources.Help;
            this.HelpButton.Location = new System.Drawing.Point(14, 80);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(170, 50);
            this.HelpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.HelpButton.TabIndex = 3;
            this.HelpButton.TabStop = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Options";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OptionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "OptionsMenu";
            this.Text = "OptionsMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutUsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HelpButton;
        private System.Windows.Forms.PictureBox languagesButton;
        private System.Windows.Forms.PictureBox mainMenuButton;
        private System.Windows.Forms.PictureBox aboutUsButton;
    }
}