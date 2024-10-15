﻿namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCalculator = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBoxDisplayRecent = new System.Windows.Forms.TextBox();
            this.txtBoxDisplay = new System.Windows.Forms.TextBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.btnEquals = new CustomControls.RJControls.RJButton();
            this.btnAddition = new CustomControls.RJControls.RJButton();
            this.btnSubtract = new CustomControls.RJControls.RJButton();
            this.btnMultiply = new CustomControls.RJControls.RJButton();
            this.btnDot = new CustomControls.RJControls.RJButton();
            this.btnZero = new CustomControls.RJControls.RJButton();
            this.btnThree = new CustomControls.RJControls.RJButton();
            this.btnTwo = new CustomControls.RJControls.RJButton();
            this.btnOne = new CustomControls.RJControls.RJButton();
            this.btnSix = new CustomControls.RJControls.RJButton();
            this.btnFive = new CustomControls.RJControls.RJButton();
            this.btnFour = new CustomControls.RJControls.RJButton();
            this.btnNine = new CustomControls.RJControls.RJButton();
            this.btnEight = new CustomControls.RJControls.RJButton();
            this.btnSeven = new CustomControls.RJControls.RJButton();
            this.btnDivide = new CustomControls.RJControls.RJButton();
            this.btnBackspace = new CustomControls.RJControls.RJButton();
            this.btnRightParenthesis = new CustomControls.RJControls.RJButton();
            this.Screen = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblCalculator);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 42);
            this.panel1.TabIndex = 0;
            // 
            // lblCalculator
            // 
            this.lblCalculator.AutoSize = true;
            this.lblCalculator.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblCalculator.Location = new System.Drawing.Point(29, 13);
            this.lblCalculator.Name = "lblCalculator";
            this.lblCalculator.Size = new System.Drawing.Size(87, 22);
            this.lblCalculator.TabIndex = 2;
            this.lblCalculator.Text = "Calculator";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(277, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxDisplayRecent
            // 
            this.txtBoxDisplayRecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtBoxDisplayRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDisplayRecent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDisplayRecent.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxDisplayRecent.Location = new System.Drawing.Point(27, 93);
            this.txtBoxDisplayRecent.Multiline = true;
            this.txtBoxDisplayRecent.Name = "txtBoxDisplayRecent";
            this.txtBoxDisplayRecent.Size = new System.Drawing.Size(263, 29);
            this.txtBoxDisplayRecent.TabIndex = 1;
            this.txtBoxDisplayRecent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxDisplay
            // 
            this.txtBoxDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.txtBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDisplay.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDisplay.ForeColor = System.Drawing.Color.Black;
            this.txtBoxDisplay.Location = new System.Drawing.Point(27, 128);
            this.txtBoxDisplay.Multiline = true;
            this.txtBoxDisplay.Name = "txtBoxDisplay";
            this.txtBoxDisplay.Size = new System.Drawing.Size(263, 55);
            this.txtBoxDisplay.TabIndex = 2;
            this.txtBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.rjButton1.BorderRadius = 27;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(26, 215);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(0);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(54, 56);
            this.rjButton1.TabIndex = 44;
            this.rjButton1.Text = "(";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.rjButton2.BorderRadius = 27;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(165, 463);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(0);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(54, 56);
            this.rjButton2.TabIndex = 43;
            this.rjButton2.Text = "=";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEquals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEquals.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnEquals.BorderRadius = 27;
            this.btnEquals.BorderSize = 0;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEquals.ForeColor = System.Drawing.Color.Black;
            this.btnEquals.Location = new System.Drawing.Point(235, 463);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(54, 56);
            this.btnEquals.TabIndex = 42;
            this.btnEquals.Text = "=";
            this.btnEquals.TextColor = System.Drawing.Color.Black;
            this.btnEquals.UseVisualStyleBackColor = false;
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAddition.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAddition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnAddition.BorderRadius = 27;
            this.btnAddition.BorderSize = 0;
            this.btnAddition.FlatAppearance.BorderSize = 0;
            this.btnAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddition.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddition.ForeColor = System.Drawing.Color.Black;
            this.btnAddition.Location = new System.Drawing.Point(235, 401);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(54, 56);
            this.btnAddition.TabIndex = 41;
            this.btnAddition.Text = "+";
            this.btnAddition.TextColor = System.Drawing.Color.Black;
            this.btnAddition.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnSubtract.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnSubtract.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnSubtract.BorderRadius = 27;
            this.btnSubtract.BorderSize = 0;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSubtract.ForeColor = System.Drawing.Color.Black;
            this.btnSubtract.Location = new System.Drawing.Point(235, 339);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(54, 56);
            this.btnSubtract.TabIndex = 40;
            this.btnSubtract.Text = "-";
            this.btnSubtract.TextColor = System.Drawing.Color.Black;
            this.btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnMultiply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnMultiply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnMultiply.BorderRadius = 27;
            this.btnMultiply.BorderSize = 0;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnMultiply.ForeColor = System.Drawing.Color.Black;
            this.btnMultiply.Location = new System.Drawing.Point(235, 277);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(54, 56);
            this.btnMultiply.TabIndex = 39;
            this.btnMultiply.Text = "*";
            this.btnMultiply.TextColor = System.Drawing.Color.Black;
            this.btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnDot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnDot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnDot.BorderRadius = 27;
            this.btnDot.BorderSize = 1;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDot.ForeColor = System.Drawing.Color.Black;
            this.btnDot.Location = new System.Drawing.Point(95, 463);
            this.btnDot.Margin = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(54, 56);
            this.btnDot.TabIndex = 37;
            this.btnDot.Text = ".";
            this.btnDot.TextColor = System.Drawing.Color.Black;
            this.btnDot.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnZero.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnZero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnZero.BorderRadius = 27;
            this.btnZero.BorderSize = 1;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnZero.ForeColor = System.Drawing.Color.Black;
            this.btnZero.Location = new System.Drawing.Point(26, 463);
            this.btnZero.Margin = new System.Windows.Forms.Padding(0);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(54, 56);
            this.btnZero.TabIndex = 36;
            this.btnZero.Text = "0";
            this.btnZero.TextColor = System.Drawing.Color.Black;
            this.btnZero.UseVisualStyleBackColor = false;
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnThree.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnThree.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnThree.BorderRadius = 27;
            this.btnThree.BorderSize = 1;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThree.ForeColor = System.Drawing.Color.Black;
            this.btnThree.Location = new System.Drawing.Point(165, 401);
            this.btnThree.Margin = new System.Windows.Forms.Padding(0);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(54, 56);
            this.btnThree.TabIndex = 35;
            this.btnThree.Text = "3";
            this.btnThree.TextColor = System.Drawing.Color.Black;
            this.btnThree.UseVisualStyleBackColor = false;
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnTwo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnTwo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnTwo.BorderRadius = 27;
            this.btnTwo.BorderSize = 1;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTwo.ForeColor = System.Drawing.Color.Black;
            this.btnTwo.Location = new System.Drawing.Point(95, 401);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(54, 56);
            this.btnTwo.TabIndex = 34;
            this.btnTwo.Text = "2";
            this.btnTwo.TextColor = System.Drawing.Color.Black;
            this.btnTwo.UseVisualStyleBackColor = false;
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnOne.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnOne.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnOne.BorderRadius = 27;
            this.btnOne.BorderSize = 1;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOne.ForeColor = System.Drawing.Color.Black;
            this.btnOne.Location = new System.Drawing.Point(26, 401);
            this.btnOne.Margin = new System.Windows.Forms.Padding(0);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(54, 56);
            this.btnOne.TabIndex = 33;
            this.btnOne.Text = "1";
            this.btnOne.TextColor = System.Drawing.Color.Black;
            this.btnOne.UseVisualStyleBackColor = false;
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnSix.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnSix.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnSix.BorderRadius = 27;
            this.btnSix.BorderSize = 1;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSix.ForeColor = System.Drawing.Color.Black;
            this.btnSix.Location = new System.Drawing.Point(165, 339);
            this.btnSix.Margin = new System.Windows.Forms.Padding(0);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(54, 56);
            this.btnSix.TabIndex = 32;
            this.btnSix.Text = "6";
            this.btnSix.TextColor = System.Drawing.Color.Black;
            this.btnSix.UseVisualStyleBackColor = false;
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnFive.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnFive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnFive.BorderRadius = 27;
            this.btnFive.BorderSize = 1;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFive.ForeColor = System.Drawing.Color.Black;
            this.btnFive.Location = new System.Drawing.Point(95, 339);
            this.btnFive.Margin = new System.Windows.Forms.Padding(0);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(54, 56);
            this.btnFive.TabIndex = 31;
            this.btnFive.Text = "5";
            this.btnFive.TextColor = System.Drawing.Color.Black;
            this.btnFive.UseVisualStyleBackColor = false;
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnFour.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnFour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnFour.BorderRadius = 27;
            this.btnFour.BorderSize = 1;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFour.ForeColor = System.Drawing.Color.Black;
            this.btnFour.Location = new System.Drawing.Point(26, 339);
            this.btnFour.Margin = new System.Windows.Forms.Padding(0);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(54, 56);
            this.btnFour.TabIndex = 30;
            this.btnFour.Text = "4";
            this.btnFour.TextColor = System.Drawing.Color.Black;
            this.btnFour.UseVisualStyleBackColor = false;
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnNine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnNine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnNine.BorderRadius = 27;
            this.btnNine.BorderSize = 1;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNine.ForeColor = System.Drawing.Color.Black;
            this.btnNine.Location = new System.Drawing.Point(165, 277);
            this.btnNine.Margin = new System.Windows.Forms.Padding(0);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(54, 56);
            this.btnNine.TabIndex = 29;
            this.btnNine.Text = "9";
            this.btnNine.TextColor = System.Drawing.Color.Black;
            this.btnNine.UseVisualStyleBackColor = false;
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnEight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnEight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnEight.BorderRadius = 27;
            this.btnEight.BorderSize = 1;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEight.ForeColor = System.Drawing.Color.Black;
            this.btnEight.Location = new System.Drawing.Point(95, 277);
            this.btnEight.Margin = new System.Windows.Forms.Padding(0);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(54, 56);
            this.btnEight.TabIndex = 28;
            this.btnEight.Text = "8";
            this.btnEight.TextColor = System.Drawing.Color.Black;
            this.btnEight.UseVisualStyleBackColor = false;
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnSeven.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.btnSeven.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnSeven.BorderRadius = 27;
            this.btnSeven.BorderSize = 1;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSeven.ForeColor = System.Drawing.Color.Black;
            this.btnSeven.Location = new System.Drawing.Point(26, 277);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(54, 56);
            this.btnSeven.TabIndex = 27;
            this.btnSeven.Text = "7";
            this.btnSeven.TextColor = System.Drawing.Color.Black;
            this.btnSeven.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnDivide.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnDivide.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnDivide.BorderRadius = 27;
            this.btnDivide.BorderSize = 0;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDivide.ForeColor = System.Drawing.Color.Black;
            this.btnDivide.Location = new System.Drawing.Point(235, 215);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(54, 56);
            this.btnDivide.TabIndex = 26;
            this.btnDivide.Text = "/";
            this.btnDivide.TextColor = System.Drawing.Color.Black;
            this.btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnBackspace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnBackspace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnBackspace.BorderRadius = 27;
            this.btnBackspace.BorderSize = 0;
            this.btnBackspace.FlatAppearance.BorderSize = 0;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnBackspace.ForeColor = System.Drawing.Color.Black;
            this.btnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackspace.Image")));
            this.btnBackspace.Location = new System.Drawing.Point(165, 215);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(54, 56);
            this.btnBackspace.TabIndex = 25;
            this.btnBackspace.TextColor = System.Drawing.Color.Black;
            this.btnBackspace.UseVisualStyleBackColor = false;
            // 
            // btnRightParenthesis
            // 
            this.btnRightParenthesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnRightParenthesis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnRightParenthesis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnRightParenthesis.BorderRadius = 27;
            this.btnRightParenthesis.BorderSize = 0;
            this.btnRightParenthesis.FlatAppearance.BorderSize = 0;
            this.btnRightParenthesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightParenthesis.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnRightParenthesis.ForeColor = System.Drawing.Color.Black;
            this.btnRightParenthesis.Location = new System.Drawing.Point(95, 215);
            this.btnRightParenthesis.Margin = new System.Windows.Forms.Padding(0);
            this.btnRightParenthesis.Name = "btnRightParenthesis";
            this.btnRightParenthesis.Size = new System.Drawing.Size(54, 56);
            this.btnRightParenthesis.TabIndex = 24;
            this.btnRightParenthesis.Text = ")";
            this.btnRightParenthesis.TextColor = System.Drawing.Color.Black;
            this.btnRightParenthesis.UseVisualStyleBackColor = false;
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Screen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.Screen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Screen.BorderRadius = 20;
            this.Screen.BorderSize = 3;
            this.Screen.FlatAppearance.BorderSize = 0;
            this.Screen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Screen.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Screen.ForeColor = System.Drawing.Color.Black;
            this.Screen.Location = new System.Drawing.Point(9, 44);
            this.Screen.Margin = new System.Windows.Forms.Padding(0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(299, 157);
            this.Screen.TabIndex = 23;
            this.Screen.TextColor = System.Drawing.Color.Black;
            this.Screen.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(318, 536);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnRightParenthesis);
            this.Controls.Add(this.txtBoxDisplayRecent);
            this.Controls.Add(this.txtBoxDisplay);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBoxDisplayRecent;
        private System.Windows.Forms.TextBox txtBoxDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCalculator;
        private CustomControls.RJControls.RJButton Screen;
        private CustomControls.RJControls.RJButton btnRightParenthesis;
        private CustomControls.RJControls.RJButton btnBackspace;
        private CustomControls.RJControls.RJButton btnDivide;
        private CustomControls.RJControls.RJButton btnSeven;
        private CustomControls.RJControls.RJButton btnEight;
        private CustomControls.RJControls.RJButton btnNine;
        private CustomControls.RJControls.RJButton btnFour;
        private CustomControls.RJControls.RJButton btnFive;
        private CustomControls.RJControls.RJButton btnSix;
        private CustomControls.RJControls.RJButton btnThree;
        private CustomControls.RJControls.RJButton btnTwo;
        private CustomControls.RJControls.RJButton btnOne;
        private CustomControls.RJControls.RJButton btnZero;
        private CustomControls.RJControls.RJButton btnDot;
        private CustomControls.RJControls.RJButton btnMultiply;
        private CustomControls.RJControls.RJButton btnSubtract;
        private CustomControls.RJControls.RJButton btnAddition;
        private CustomControls.RJControls.RJButton btnEquals;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}

