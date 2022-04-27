
namespace PocketCubeSolver
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.optionButton = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuPanel.AutoSize = true;
            this.menuPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuPanel.Controls.Add(this.pictureBox2);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.optionButton);
            this.menuPanel.Controls.Add(this.startButton);
            this.menuPanel.Controls.Add(this.pictureBox1);
            this.menuPanel.Controls.Add(this.pictureBox3);
            this.menuPanel.Controls.Add(this.versionLabel);
            this.menuPanel.Controls.Add(this.menuLabel);
            this.menuPanel.Location = new System.Drawing.Point(12, 11);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(708, 416);
            this.menuPanel.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PocketCubeSolver.Properties.Resources.RubiksLogo;
            this.pictureBox3.Location = new System.Drawing.Point(638, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(625, 384);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(74, 25);
            this.versionLabel.TabIndex = 8;
            this.versionLabel.Text = "V.1.0.0";
            this.versionLabel.Click += new System.EventHandler(this.versionLabel_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.Black;
            this.menuLabel.Location = new System.Drawing.Point(61, 15);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(560, 60);
            this.menuLabel.TabIndex = 3;
            this.menuLabel.Text = "2x2x2 Rubik\'s Cube Solver";
            this.menuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.exitButton.Image = global::PocketCubeSolver.Properties.Resources.Exit;
            this.exitButton.Location = new System.Drawing.Point(276, 307);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(149, 50);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.exitButton.TabIndex = 2;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // optionButton
            // 
            this.optionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.optionButton.Image = global::PocketCubeSolver.Properties.Resources.Option;
            this.optionButton.Location = new System.Drawing.Point(276, 227);
            this.optionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(149, 50);
            this.optionButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.optionButton.TabIndex = 1;
            this.optionButton.TabStop = false;
            this.optionButton.Click += new System.EventHandler(this.option_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startButton.Image = global::PocketCubeSolver.Properties.Resources.Start;
            this.startButton.Location = new System.Drawing.Point(276, 147);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(149, 50);
            this.startButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.startButton.TabIndex = 0;
            this.startButton.TabStop = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PocketCubeSolver.Properties.Resources.BlankCube;
            this.pictureBox1.Location = new System.Drawing.Point(19, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PocketCubeSolver.Properties.Resources.BlankCube;
            this.pictureBox2.Location = new System.Drawing.Point(479, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 434);
            this.Controls.Add(this.menuPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox optionButton;
        private System.Windows.Forms.PictureBox startButton;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}