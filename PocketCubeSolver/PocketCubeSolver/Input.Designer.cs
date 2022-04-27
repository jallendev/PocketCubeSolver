
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
            this.instructions.AutoSize = true;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.instructions.Location = new System.Drawing.Point(109, 26);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(507, 29);
            this.instructions.TabIndex = 0;
            this.instructions.Text = "Click on a square below to change its\' color.";
            // 
            // buttonSolve
            // 
            this.buttonSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSolve.Location = new System.Drawing.Point(205, 389);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(95, 43);
            this.buttonSolve.TabIndex = 1;
            this.buttonSolve.Text = "Solve!";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // bottomTL
            // 
            this.bottomTL.BackColor = System.Drawing.Color.White;
            this.bottomTL.Location = new System.Drawing.Point(307, 85);
            this.bottomTL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottomTL.Name = "bottomTL";
            this.bottomTL.Size = new System.Drawing.Size(29, 30);
            this.bottomTL.TabIndex = 2;
            this.bottomTL.Click += new System.EventHandler(this.bottomTL_Click);
            // 
            // bottomBL
            // 
            this.bottomBL.BackColor = System.Drawing.Color.White;
            this.bottomBL.Location = new System.Drawing.Point(307, 121);
            this.bottomBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottomBL.Name = "bottomBL";
            this.bottomBL.Size = new System.Drawing.Size(29, 30);
            this.bottomBL.TabIndex = 3;
            this.bottomBL.Click += new System.EventHandler(this.bottomBL_Click);
            // 
            // bottomTR
            // 
            this.bottomTR.BackColor = System.Drawing.Color.White;
            this.bottomTR.Location = new System.Drawing.Point(343, 85);
            this.bottomTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottomTR.Name = "bottomTR";
            this.bottomTR.Size = new System.Drawing.Size(29, 30);
            this.bottomTR.TabIndex = 3;
            this.bottomTR.Click += new System.EventHandler(this.bottomTR_Click);
            // 
            // bottomBR
            // 
            this.bottomBR.BackColor = System.Drawing.Color.Yellow;
            this.bottomBR.Location = new System.Drawing.Point(343, 121);
            this.bottomBR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottomBR.Name = "bottomBR";
            this.bottomBR.Size = new System.Drawing.Size(29, 30);
            this.bottomBR.TabIndex = 3;
            this.bottomBR.Click += new System.EventHandler(this.bottomBR_Click);
            // 
            // backBL
            // 
            this.backBL.BackColor = System.Drawing.Color.Red;
            this.backBL.Location = new System.Drawing.Point(307, 193);
            this.backBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBL.Name = "backBL";
            this.backBL.Size = new System.Drawing.Size(29, 30);
            this.backBL.TabIndex = 6;
            this.backBL.Click += new System.EventHandler(this.backBL_Click);
            // 
            // backBR
            // 
            this.backBR.BackColor = System.Drawing.Color.Blue;
            this.backBR.Location = new System.Drawing.Point(343, 193);
            this.backBR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBR.Name = "backBR";
            this.backBR.Size = new System.Drawing.Size(29, 30);
            this.backBR.TabIndex = 7;
            this.backBR.Click += new System.EventHandler(this.backBR_Click);
            // 
            // backTR
            // 
            this.backTR.BackColor = System.Drawing.Color.Blue;
            this.backTR.Location = new System.Drawing.Point(343, 158);
            this.backTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backTR.Name = "backTR";
            this.backTR.Size = new System.Drawing.Size(29, 30);
            this.backTR.TabIndex = 8;
            this.backTR.Click += new System.EventHandler(this.backTR_Click);
            // 
            // backTL
            // 
            this.backTL.BackColor = System.Drawing.Color.Red;
            this.backTL.Location = new System.Drawing.Point(307, 158);
            this.backTL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backTL.Name = "backTL";
            this.backTL.Size = new System.Drawing.Size(29, 30);
            this.backTL.TabIndex = 5;
            this.backTL.Click += new System.EventHandler(this.backTL_Click);
            // 
            // leftBL
            // 
            this.leftBL.BackColor = System.Drawing.Color.Blue;
            this.leftBL.Location = new System.Drawing.Point(235, 193);
            this.leftBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftBL.Name = "leftBL";
            this.leftBL.Size = new System.Drawing.Size(29, 30);
            this.leftBL.TabIndex = 6;
            this.leftBL.Click += new System.EventHandler(this.leftBL_Click);
            // 
            // leftBR
            // 
            this.leftBR.BackColor = System.Drawing.Color.Red;
            this.leftBR.Location = new System.Drawing.Point(271, 193);
            this.leftBR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftBR.Name = "leftBR";
            this.leftBR.Size = new System.Drawing.Size(29, 30);
            this.leftBR.TabIndex = 7;
            this.leftBR.Click += new System.EventHandler(this.leftBR_Click);
            // 
            // leftTR
            // 
            this.leftTR.BackColor = System.Drawing.Color.Red;
            this.leftTR.Location = new System.Drawing.Point(271, 158);
            this.leftTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftTR.Name = "leftTR";
            this.leftTR.Size = new System.Drawing.Size(29, 30);
            this.leftTR.TabIndex = 8;
            this.leftTR.Click += new System.EventHandler(this.leftTR_Click);
            // 
            // leftTL
            // 
            this.leftTL.BackColor = System.Drawing.Color.Red;
            this.leftTL.Location = new System.Drawing.Point(235, 158);
            this.leftTL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftTL.Name = "leftTL";
            this.leftTL.Size = new System.Drawing.Size(29, 30);
            this.leftTL.TabIndex = 5;
            this.leftTL.Click += new System.EventHandler(this.leftTL_Click);
            // 
            // topBL
            // 
            this.topBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.topBL.Location = new System.Drawing.Point(307, 265);
            this.topBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topBL.Name = "topBL";
            this.topBL.Size = new System.Drawing.Size(29, 30);
            this.topBL.TabIndex = 10;
            this.topBL.Click += new System.EventHandler(this.topBL_Click);
            // 
            // topBR
            // 
            this.topBR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.topBR.Location = new System.Drawing.Point(343, 265);
            this.topBR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topBR.Name = "topBR";
            this.topBR.Size = new System.Drawing.Size(29, 30);
            this.topBR.TabIndex = 11;
            this.topBR.Click += new System.EventHandler(this.topBR_Click);
            // 
            // topTR
            // 
            this.topTR.BackColor = System.Drawing.Color.White;
            this.topTR.Location = new System.Drawing.Point(343, 229);
            this.topTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topTR.Name = "topTR";
            this.topTR.Size = new System.Drawing.Size(29, 30);
            this.topTR.TabIndex = 12;
            this.topTR.Click += new System.EventHandler(this.topTR_Click);
            // 
            // topTL
            // 
            this.topTL.BackColor = System.Drawing.Color.Yellow;
            this.topTL.Location = new System.Drawing.Point(307, 229);
            this.topTL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topTL.Name = "topTL";
            this.topTL.Size = new System.Drawing.Size(29, 30);
            this.topTL.TabIndex = 9;
            this.topTL.Click += new System.EventHandler(this.topTL_Click);
            // 
            // frontBL
            // 
            this.frontBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.frontBL.Location = new System.Drawing.Point(307, 337);
            this.frontBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frontBL.Name = "frontBL";
            this.frontBL.Size = new System.Drawing.Size(29, 30);
            this.frontBL.TabIndex = 10;
            this.frontBL.Click += new System.EventHandler(this.frontBL_Click);
            // 
            // frontBR
            // 
            this.frontBR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.frontBR.Location = new System.Drawing.Point(343, 337);
            this.frontBR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frontBR.Name = "frontBR";
            this.frontBR.Size = new System.Drawing.Size(29, 30);
            this.frontBR.TabIndex = 11;
            this.frontBR.Click += new System.EventHandler(this.frontBR_Click);
            // 
            // frontTR
            // 
            this.frontTR.BackColor = System.Drawing.Color.Yellow;
            this.frontTR.Location = new System.Drawing.Point(343, 302);
            this.frontTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frontTR.Name = "frontTR";
            this.frontTR.Size = new System.Drawing.Size(29, 30);
            this.frontTR.TabIndex = 12;
            this.frontTR.Click += new System.EventHandler(this.frontTR_Click);
            // 
            // frontTL
            // 
            this.frontTL.BackColor = System.Drawing.Color.Yellow;
            this.frontTL.Location = new System.Drawing.Point(307, 302);
            this.frontTL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frontTL.Name = "frontTL";
            this.frontTL.Size = new System.Drawing.Size(29, 30);
            this.frontTL.TabIndex = 9;
            this.frontTL.Click += new System.EventHandler(this.frontTL_Click);
            // 
            // rightBL
            // 
            this.rightBL.BackColor = System.Drawing.Color.Lime;
            this.rightBL.Location = new System.Drawing.Point(379, 265);
            this.rightBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightBL.Name = "rightBL";
            this.rightBL.Size = new System.Drawing.Size(29, 30);
            this.rightBL.TabIndex = 10;
            this.rightBL.Click += new System.EventHandler(this.rightBL_Click);
            // 
            // rightBR
            // 
            this.rightBR.BackColor = System.Drawing.Color.Blue;
            this.rightBR.Location = new System.Drawing.Point(415, 265);
            this.rightBR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightBR.Name = "rightBR";
            this.rightBR.Size = new System.Drawing.Size(29, 30);
            this.rightBR.TabIndex = 11;
            this.rightBR.Click += new System.EventHandler(this.rightBR_Click);
            // 
            // rightTR
            // 
            this.rightTR.BackColor = System.Drawing.Color.Red;
            this.rightTR.Location = new System.Drawing.Point(415, 229);
            this.rightTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightTR.Name = "rightTR";
            this.rightTR.Size = new System.Drawing.Size(29, 30);
            this.rightTR.TabIndex = 12;
            this.rightTR.Click += new System.EventHandler(this.rightTR_Click);
            // 
            // rightTL
            // 
            this.rightTL.BackColor = System.Drawing.Color.Red;
            this.rightTL.Location = new System.Drawing.Point(379, 229);
            this.rightTL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightTL.Name = "rightTL";
            this.rightTL.Size = new System.Drawing.Size(29, 30);
            this.rightTL.TabIndex = 9;
            this.rightTL.Click += new System.EventHandler(this.rightTL_Click);
            // 
            // labelBottom
            // 
            this.labelBottom.AutoSize = true;
            this.labelBottom.Location = new System.Drawing.Point(379, 98);
            this.labelBottom.Name = "labelBottom";
            this.labelBottom.Size = new System.Drawing.Size(84, 17);
            this.labelBottom.TabIndex = 13;
            this.labelBottom.Text = "Bottom Side";
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Location = new System.Drawing.Point(211, 134);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(64, 17);
            this.labelLeft.TabIndex = 14;
            this.labelLeft.Text = "Left Side";
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Location = new System.Drawing.Point(379, 170);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(71, 17);
            this.labelBack.TabIndex = 15;
            this.labelBack.Text = "Back Side";
            // 
            // labelTop
            // 
            this.labelTop.AutoSize = true;
            this.labelTop.Location = new System.Drawing.Point(236, 265);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(65, 17);
            this.labelTop.TabIndex = 16;
            this.labelTop.Text = "Top Side";
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Location = new System.Drawing.Point(451, 265);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(73, 17);
            this.labelRight.TabIndex = 17;
            this.labelRight.Text = "Right Side";
            // 
            // labelFront
            // 
            this.labelFront.AutoSize = true;
            this.labelFront.Location = new System.Drawing.Point(228, 337);
            this.labelFront.Name = "labelFront";
            this.labelFront.Size = new System.Drawing.Size(73, 17);
            this.labelFront.TabIndex = 18;
            this.labelFront.Text = "Front Side";
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.Location = new System.Drawing.Point(379, 389);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(95, 43);
            this.homeButton.TabIndex = 19;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 500);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.labelFront);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelTop);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.labelBottom);
            this.Controls.Add(this.rightBL);
            this.Controls.Add(this.frontBL);
            this.Controls.Add(this.rightBR);
            this.Controls.Add(this.topBL);
            this.Controls.Add(this.rightTR);
            this.Controls.Add(this.frontBR);
            this.Controls.Add(this.rightTL);
            this.Controls.Add(this.leftBL);
            this.Controls.Add(this.frontTR);
            this.Controls.Add(this.topBR);
            this.Controls.Add(this.frontTL);
            this.Controls.Add(this.backBL);
            this.Controls.Add(this.topTR);
            this.Controls.Add(this.leftBR);
            this.Controls.Add(this.topTL);
            this.Controls.Add(this.bottomBL);
            this.Controls.Add(this.leftTR);
            this.Controls.Add(this.leftTL);
            this.Controls.Add(this.backBR);
            this.Controls.Add(this.bottomBR);
            this.Controls.Add(this.backTR);
            this.Controls.Add(this.bottomTR);
            this.Controls.Add(this.backTL);
            this.Controls.Add(this.bottomTL);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.instructions);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

