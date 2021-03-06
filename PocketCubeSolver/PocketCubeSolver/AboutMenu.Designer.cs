
namespace PocketCubeSolver
{
    partial class AboutMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.aboutText = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.gitHubLink = new System.Windows.Forms.LinkLabel();
            this.jayPicture = new System.Windows.Forms.PictureBox();
            this.josephPicture = new System.Windows.Forms.PictureBox();
            this.samsonPicture = new System.Windows.Forms.PictureBox();
            this.gwenPicture = new System.Windows.Forms.PictureBox();
            this.OULogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.jayPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.josephPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samsonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwenPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OULogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "About Us";
            // 
            // aboutText
            // 
            this.aboutText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutText.Location = new System.Drawing.Point(32, 171);
            this.aboutText.Multiline = true;
            this.aboutText.Name = "aboutText";
            this.aboutText.ReadOnly = true;
            this.aboutText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aboutText.Size = new System.Drawing.Size(744, 221);
            this.aboutText.TabIndex = 2;
            this.aboutText.Text = resources.GetString("aboutText.Text");
            this.aboutText.TextChanged += new System.EventHandler(this.aboutText_TextChanged);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(280, 416);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(125, 60);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(426, 416);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(125, 60);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(723, 459);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(53, 17);
            this.VersionLabel.TabIndex = 10;
            this.VersionLabel.Text = "V.1.0.0";
            // 
            // gitHubLink
            // 
            this.gitHubLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gitHubLink.AutoSize = true;
            this.gitHubLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitHubLink.Location = new System.Drawing.Point(26, 398);
            this.gitHubLink.Name = "gitHubLink";
            this.gitHubLink.Size = new System.Drawing.Size(243, 32);
            this.gitHubLink.TabIndex = 11;
            this.gitHubLink.TabStop = true;
            this.gitHubLink.Text = "Github Repository";
            this.gitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitHubLink_LinkClicked);
            // 
            // jayPicture
            // 
            this.jayPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.jayPicture.Image = ((System.Drawing.Image)(resources.GetObject("jayPicture.Image")));
            this.jayPicture.Location = new System.Drawing.Point(654, 9);
            this.jayPicture.MinimumSize = new System.Drawing.Size(110, 94);
            this.jayPicture.Name = "jayPicture";
            this.jayPicture.Size = new System.Drawing.Size(110, 152);
            this.jayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jayPicture.TabIndex = 9;
            this.jayPicture.TabStop = false;
            // 
            // josephPicture
            // 
            this.josephPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.josephPicture.Image = global::PocketCubeSolver.Properties.Resources.Joseph;
            this.josephPicture.Location = new System.Drawing.Point(23, 9);
            this.josephPicture.Name = "josephPicture";
            this.josephPicture.Size = new System.Drawing.Size(128, 152);
            this.josephPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.josephPicture.TabIndex = 8;
            this.josephPicture.TabStop = false;
            // 
            // samsonPicture
            // 
            this.samsonPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.samsonPicture.Image = ((System.Drawing.Image)(resources.GetObject("samsonPicture.Image")));
            this.samsonPicture.Location = new System.Drawing.Point(529, 9);
            this.samsonPicture.Name = "samsonPicture";
            this.samsonPicture.Size = new System.Drawing.Size(119, 152);
            this.samsonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.samsonPicture.TabIndex = 7;
            this.samsonPicture.TabStop = false;
            this.samsonPicture.Click += new System.EventHandler(this.samsonPicture_Click);
            // 
            // gwenPicture
            // 
            this.gwenPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gwenPicture.Image = global::PocketCubeSolver.Properties.Resources.Gwen;
            this.gwenPicture.Location = new System.Drawing.Point(157, 9);
            this.gwenPicture.Name = "gwenPicture";
            this.gwenPicture.Size = new System.Drawing.Size(126, 152);
            this.gwenPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gwenPicture.TabIndex = 6;
            this.gwenPicture.TabStop = false;
            // 
            // OULogo
            // 
            this.OULogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OULogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OULogo.Image = global::PocketCubeSolver.Properties.Resources.OULogo;
            this.OULogo.Location = new System.Drawing.Point(723, 398);
            this.OULogo.MaximumSize = new System.Drawing.Size(200, 200);
            this.OULogo.MinimumSize = new System.Drawing.Size(65, 58);
            this.OULogo.Name = "OULogo";
            this.OULogo.Size = new System.Drawing.Size(65, 58);
            this.OULogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OULogo.TabIndex = 5;
            this.OULogo.TabStop = false;
            // 
            // AboutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.gitHubLink);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.jayPicture);
            this.Controls.Add(this.josephPicture);
            this.Controls.Add(this.samsonPicture);
            this.Controls.Add(this.gwenPicture);
            this.Controls.Add(this.OULogo);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.aboutText);
            this.Controls.Add(this.label1);
            this.Name = "AboutMenu";
            this.Text = "AboutMenu";
            ((System.ComponentModel.ISupportInitialize)(this.jayPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.josephPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samsonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwenPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OULogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aboutText;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.PictureBox OULogo;
        private System.Windows.Forms.PictureBox gwenPicture;
        private System.Windows.Forms.PictureBox samsonPicture;
        private System.Windows.Forms.PictureBox josephPicture;
        private System.Windows.Forms.PictureBox jayPicture;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.LinkLabel gitHubLink;
    }
}