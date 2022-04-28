
namespace PocketCubeSolver
{
    partial class Input
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
            this.instructions = new System.Windows.Forms.Label();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.bottomTL = new System.Windows.Forms.Panel();
            this.bottomBL = new System.Windows.Forms.Panel();
            this.bottomTR = new System.Windows.Forms.Panel();
            this.bottomBR = new System.Windows.Forms.Panel();
            this.backBL = new System.Windows.Forms.Panel();
            this.backBR = new System.Windows.Forms.Panel();
            this.backTR = new System.Windows.Forms.Panel();
            this.backTL = new System.Windows.Forms.Panel();
            this.leftBL = new System.Windows.Forms.Panel();
            this.leftBR = new System.Windows.Forms.Panel();
            this.leftTR = new System.Windows.Forms.Panel();
            this.leftTL = new System.Windows.Forms.Panel();
            this.topBL = new System.Windows.Forms.Panel();
            this.topBR = new System.Windows.Forms.Panel();
            this.topTR = new System.Windows.Forms.Panel();
            this.topTL = new System.Windows.Forms.Panel();
            this.frontBL = new System.Windows.Forms.Panel();
            this.frontBR = new System.Windows.Forms.Panel();
            this.frontTR = new System.Windows.Forms.Panel();
            this.frontTL = new System.Windows.Forms.Panel();
            this.rightBL = new System.Windows.Forms.Panel();
            this.rightBR = new System.Windows.Forms.Panel();
            this.rightTR = new System.Windows.Forms.Panel();
            this.rightTL = new System.Windows.Forms.Panel();
            this.labelBottom = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelFront = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructions
            // 
            this.instructions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instructions.AutoSize = true;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(88, 7);
            this.instructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(435, 25);
            this.instructions.TabIndex = 0;
            this.instructions.Text = "Click on a square below to change its\' color.";
            this.instructions.Click += new System.EventHandler(this.instructions_Click);
            // 
            // buttonSolve
            // 
            this.buttonSolve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSolve.Location = new System.Drawing.Point(9, 393);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(112, 49);
            this.buttonSolve.TabIndex = 1;
            this.buttonSolve.Text = "Solve!";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // bottomTL
            // 
            this.bottomTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bottomTL.BackColor = System.Drawing.Color.Yellow;
            this.bottomTL.Location = new System.Drawing.Point(252, 46);
            this.bottomTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bottomTL.Name = "bottomTL";
            this.bottomTL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bottomTL.Size = new System.Drawing.Size(38, 41);
            this.bottomTL.TabIndex = 2;
            this.bottomTL.Click += new System.EventHandler(this.bottomTL_Click);
            // 
            // bottomBL
            // 
            this.bottomBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bottomBL.BackColor = System.Drawing.Color.Yellow;
            this.bottomBL.Location = new System.Drawing.Point(252, 90);
            this.bottomBL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bottomBL.Name = "bottomBL";
            this.bottomBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bottomBL.Size = new System.Drawing.Size(38, 41);
            this.bottomBL.TabIndex = 3;
            this.bottomBL.Click += new System.EventHandler(this.bottomBL_Click);
            // 
            // bottomTR
            // 
            this.bottomTR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bottomTR.BackColor = System.Drawing.Color.Yellow;
            this.bottomTR.Location = new System.Drawing.Point(294, 46);
            this.bottomTR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bottomTR.Name = "bottomTR";
            this.bottomTR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bottomTR.Size = new System.Drawing.Size(38, 41);
            this.bottomTR.TabIndex = 3;
            this.bottomTR.Click += new System.EventHandler(this.bottomTR_Click);
            // 
            // bottomBR
            // 
            this.bottomBR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bottomBR.BackColor = System.Drawing.Color.Yellow;
            this.bottomBR.Location = new System.Drawing.Point(294, 90);
            this.bottomBR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bottomBR.Name = "bottomBR";
            this.bottomBR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bottomBR.Size = new System.Drawing.Size(38, 41);
            this.bottomBR.TabIndex = 3;
            this.bottomBR.Click += new System.EventHandler(this.bottomBR_Click);
            // 
            // backBL
            // 
            this.backBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backBL.BackColor = System.Drawing.Color.Blue;
            this.backBL.Location = new System.Drawing.Point(252, 178);
            this.backBL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBL.Name = "backBL";
            this.backBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.backBL.Size = new System.Drawing.Size(38, 41);
            this.backBL.TabIndex = 6;
            this.backBL.Click += new System.EventHandler(this.backBL_Click);
            // 
            // backBR
            // 
            this.backBR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backBR.BackColor = System.Drawing.Color.Blue;
            this.backBR.Location = new System.Drawing.Point(294, 178);
            this.backBR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBR.Name = "backBR";
            this.backBR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.backBR.Size = new System.Drawing.Size(38, 41);
            this.backBR.TabIndex = 7;
            this.backBR.Click += new System.EventHandler(this.backBR_Click);
            // 
            // backTR
            // 
            this.backTR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backTR.BackColor = System.Drawing.Color.Blue;
            this.backTR.Location = new System.Drawing.Point(294, 134);
            this.backTR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backTR.Name = "backTR";
            this.backTR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.backTR.Size = new System.Drawing.Size(38, 41);
            this.backTR.TabIndex = 8;
            this.backTR.Click += new System.EventHandler(this.backTR_Click);
            // 
            // backTL
            // 
            this.backTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.backTL.BackColor = System.Drawing.Color.Blue;
            this.backTL.Location = new System.Drawing.Point(252, 134);
            this.backTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backTL.Name = "backTL";
            this.backTL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.backTL.Size = new System.Drawing.Size(38, 41);
            this.backTL.TabIndex = 5;
            this.backTL.Click += new System.EventHandler(this.backTL_Click);
            // 
            // leftBL
            // 
            this.leftBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leftBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.leftBL.Location = new System.Drawing.Point(168, 178);
            this.leftBL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftBL.Name = "leftBL";
            this.leftBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.leftBL.Size = new System.Drawing.Size(38, 41);
            this.leftBL.TabIndex = 6;
            this.leftBL.Click += new System.EventHandler(this.leftBL_Click);
            // 
            // leftBR
            // 
            this.leftBR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leftBR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.leftBR.Location = new System.Drawing.Point(210, 178);
            this.leftBR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftBR.Name = "leftBR";
            this.leftBR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.leftBR.Size = new System.Drawing.Size(38, 41);
            this.leftBR.TabIndex = 7;
            this.leftBR.Click += new System.EventHandler(this.leftBR_Click);
            // 
            // leftTR
            // 
            this.leftTR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leftTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.leftTR.Location = new System.Drawing.Point(210, 134);
            this.leftTR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftTR.Name = "leftTR";
            this.leftTR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.leftTR.Size = new System.Drawing.Size(38, 41);
            this.leftTR.TabIndex = 8;
            this.leftTR.Click += new System.EventHandler(this.leftTR_Click);
            // 
            // leftTL
            // 
            this.leftTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leftTL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.leftTL.Location = new System.Drawing.Point(168, 134);
            this.leftTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftTL.Name = "leftTL";
            this.leftTL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.leftTL.Size = new System.Drawing.Size(38, 41);
            this.leftTL.TabIndex = 5;
            this.leftTL.Click += new System.EventHandler(this.leftTL_Click);
            // 
            // topBL
            // 
            this.topBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topBL.BackColor = System.Drawing.Color.White;
            this.topBL.Location = new System.Drawing.Point(252, 266);
            this.topBL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topBL.Name = "topBL";
            this.topBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topBL.Size = new System.Drawing.Size(38, 41);
            this.topBL.TabIndex = 10;
            this.topBL.Click += new System.EventHandler(this.topBL_Click);
            // 
            // topBR
            // 
            this.topBR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topBR.BackColor = System.Drawing.Color.White;
            this.topBR.Location = new System.Drawing.Point(294, 266);
            this.topBR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topBR.Name = "topBR";
            this.topBR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topBR.Size = new System.Drawing.Size(38, 41);
            this.topBR.TabIndex = 11;
            this.topBR.Click += new System.EventHandler(this.topBR_Click);
            // 
            // topTR
            // 
            this.topTR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topTR.BackColor = System.Drawing.Color.White;
            this.topTR.Location = new System.Drawing.Point(294, 222);
            this.topTR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topTR.Name = "topTR";
            this.topTR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topTR.Size = new System.Drawing.Size(38, 41);
            this.topTR.TabIndex = 12;
            this.topTR.Click += new System.EventHandler(this.topTR_Click);
            // 
            // topTL
            // 
            this.topTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topTL.BackColor = System.Drawing.Color.White;
            this.topTL.Location = new System.Drawing.Point(252, 222);
            this.topTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.topTL.Name = "topTL";
            this.topTL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topTL.Size = new System.Drawing.Size(38, 41);
            this.topTL.TabIndex = 9;
            this.topTL.Click += new System.EventHandler(this.topTL_Click);
            // 
            // frontBL
            // 
            this.frontBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.frontBL.BackColor = System.Drawing.Color.Lime;
            this.frontBL.Location = new System.Drawing.Point(252, 353);
            this.frontBL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frontBL.Name = "frontBL";
            this.frontBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frontBL.Size = new System.Drawing.Size(38, 41);
            this.frontBL.TabIndex = 10;
            this.frontBL.Click += new System.EventHandler(this.frontBL_Click);
            // 
            // frontBR
            // 
            this.frontBR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.frontBR.BackColor = System.Drawing.Color.Lime;
            this.frontBR.Location = new System.Drawing.Point(294, 353);
            this.frontBR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frontBR.Name = "frontBR";
            this.frontBR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frontBR.Size = new System.Drawing.Size(38, 41);
            this.frontBR.TabIndex = 11;
            this.frontBR.Click += new System.EventHandler(this.frontBR_Click);
            // 
            // frontTR
            // 
            this.frontTR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.frontTR.BackColor = System.Drawing.Color.Lime;
            this.frontTR.Location = new System.Drawing.Point(294, 310);
            this.frontTR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frontTR.Name = "frontTR";
            this.frontTR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frontTR.Size = new System.Drawing.Size(38, 41);
            this.frontTR.TabIndex = 12;
            this.frontTR.Click += new System.EventHandler(this.frontTR_Click);
            // 
            // frontTL
            // 
            this.frontTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.frontTL.BackColor = System.Drawing.Color.Lime;
            this.frontTL.Location = new System.Drawing.Point(252, 310);
            this.frontTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frontTL.Name = "frontTL";
            this.frontTL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frontTL.Size = new System.Drawing.Size(38, 41);
            this.frontTL.TabIndex = 9;
            this.frontTL.Click += new System.EventHandler(this.frontTL_Click);
            // 
            // rightBL
            // 
            this.rightBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rightBL.BackColor = System.Drawing.Color.Red;
            this.rightBL.Location = new System.Drawing.Point(336, 266);
            this.rightBL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightBL.Name = "rightBL";
            this.rightBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rightBL.Size = new System.Drawing.Size(38, 41);
            this.rightBL.TabIndex = 10;
            this.rightBL.Click += new System.EventHandler(this.rightBL_Click);
            // 
            // rightBR
            // 
            this.rightBR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rightBR.BackColor = System.Drawing.Color.Red;
            this.rightBR.Location = new System.Drawing.Point(376, 266);
            this.rightBR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightBR.Name = "rightBR";
            this.rightBR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rightBR.Size = new System.Drawing.Size(38, 41);
            this.rightBR.TabIndex = 11;
            this.rightBR.Click += new System.EventHandler(this.rightBR_Click);
            // 
            // rightTR
            // 
            this.rightTR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rightTR.BackColor = System.Drawing.Color.Red;
            this.rightTR.Location = new System.Drawing.Point(376, 222);
            this.rightTR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightTR.Name = "rightTR";
            this.rightTR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rightTR.Size = new System.Drawing.Size(38, 41);
            this.rightTR.TabIndex = 12;
            this.rightTR.Click += new System.EventHandler(this.rightTR_Click);
            // 
            // rightTL
            // 
            this.rightTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rightTL.BackColor = System.Drawing.Color.Red;
            this.rightTL.Location = new System.Drawing.Point(336, 222);
            this.rightTL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightTL.Name = "rightTL";
            this.rightTL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rightTL.Size = new System.Drawing.Size(38, 41);
            this.rightTL.TabIndex = 9;
            this.rightTL.Click += new System.EventHandler(this.rightTL_Click);
            // 
            // labelBottom
            // 
            this.labelBottom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBottom.AutoSize = true;
            this.labelBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBottom.Location = new System.Drawing.Point(332, 79);
            this.labelBottom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBottom.Name = "labelBottom";
            this.labelBottom.Size = new System.Drawing.Size(97, 20);
            this.labelBottom.TabIndex = 13;
            this.labelBottom.Text = "Bottom Side";
            // 
            // labelLeft
            // 
            this.labelLeft.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLeft.AutoSize = true;
            this.labelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeft.Location = new System.Drawing.Point(79, 169);
            this.labelLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(73, 20);
            this.labelLeft.TabIndex = 14;
            this.labelLeft.Text = "Left Side";
            this.labelLeft.Click += new System.EventHandler(this.labelLeft_Click);
            // 
            // labelBack
            // 
            this.labelBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBack.AutoSize = true;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.Location = new System.Drawing.Point(336, 169);
            this.labelBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(81, 20);
            this.labelBack.TabIndex = 15;
            this.labelBack.Text = "Back Side";
            // 
            // labelTop
            // 
            this.labelTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTop.AutoSize = true;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(172, 254);
            this.labelTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(72, 20);
            this.labelTop.TabIndex = 16;
            this.labelTop.Text = "Top Side";
            // 
            // labelRight
            // 
            this.labelRight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRight.AutoSize = true;
            this.labelRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRight.Location = new System.Drawing.Point(418, 254);
            this.labelRight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(83, 20);
            this.labelRight.TabIndex = 17;
            this.labelRight.Text = "Right Side";
            this.labelRight.Click += new System.EventHandler(this.labelRight_Click);
            // 
            // labelFront
            // 
            this.labelFront.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFront.AutoSize = true;
            this.labelFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFront.Location = new System.Drawing.Point(164, 345);
            this.labelFront.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFront.Name = "labelFront";
            this.labelFront.Size = new System.Drawing.Size(83, 20);
            this.labelFront.TabIndex = 18;
            this.labelFront.Text = "Front Side";
            // 
            // homeButton
            // 
            this.homeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(428, 393);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(112, 49);
            this.homeButton.TabIndex = 19;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(549, 451);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.topTL);
            this.Controls.Add(this.topBR);
            this.Controls.Add(this.bottomBR);
            this.Controls.Add(this.leftBR);
            this.Controls.Add(this.leftBL);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.labelFront);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelBottom);
            this.Controls.Add(this.rightBL);
            this.Controls.Add(this.frontBL);
            this.Controls.Add(this.rightBR);
            this.Controls.Add(this.topBL);
            this.Controls.Add(this.rightTR);
            this.Controls.Add(this.frontBR);
            this.Controls.Add(this.rightTL);
            this.Controls.Add(this.frontTR);
            this.Controls.Add(this.frontTL);
            this.Controls.Add(this.backBL);
            this.Controls.Add(this.topTR);
            this.Controls.Add(this.bottomBL);
            this.Controls.Add(this.leftTR);
            this.Controls.Add(this.leftTL);
            this.Controls.Add(this.backBR);
            this.Controls.Add(this.backTR);
            this.Controls.Add(this.bottomTR);
            this.Controls.Add(this.backTL);
            this.Controls.Add(this.bottomTL);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.instructions);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Input";
            this.Text = "Solution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Panel bottomTL;
        private System.Windows.Forms.Panel bottomBL;
        private System.Windows.Forms.Panel bottomTR;
        private System.Windows.Forms.Panel bottomBR;
        private System.Windows.Forms.Panel backBL;
        private System.Windows.Forms.Panel backBR;
        private System.Windows.Forms.Panel backTR;
        private System.Windows.Forms.Panel backTL;
        private System.Windows.Forms.Panel leftBL;
        private System.Windows.Forms.Panel leftBR;
        private System.Windows.Forms.Panel leftTR;
        private System.Windows.Forms.Panel leftTL;
        private System.Windows.Forms.Panel topBL;
        private System.Windows.Forms.Panel topBR;
        private System.Windows.Forms.Panel topTR;
        private System.Windows.Forms.Panel topTL;
        private System.Windows.Forms.Panel frontBL;
        private System.Windows.Forms.Panel frontBR;
        private System.Windows.Forms.Panel frontTR;
        private System.Windows.Forms.Panel frontTL;
        private System.Windows.Forms.Panel rightBL;
        private System.Windows.Forms.Panel rightBR;
        private System.Windows.Forms.Panel rightTR;
        private System.Windows.Forms.Panel rightTL;
        private System.Windows.Forms.Label labelBottom;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelFront;
        private System.Windows.Forms.Button homeButton;
    }
}

