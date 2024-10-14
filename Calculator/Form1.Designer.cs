namespace Calculator
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBoxDisplayRecent = new System.Windows.Forms.TextBox();
            this.txtBoxDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCalculator = new System.Windows.Forms.Label();
            this.btnZero = new CustomControls.RJControls.RJButton();
            this.btnDot = new CustomControls.RJControls.RJButton();
            this.btnEqual = new CustomControls.RJControls.RJButton();
            this.btnAdd = new CustomControls.RJControls.RJButton();
            this.btnThree = new CustomControls.RJControls.RJButton();
            this.btnTwo = new CustomControls.RJControls.RJButton();
            this.btnOne = new CustomControls.RJControls.RJButton();
            this.btnSubtract = new CustomControls.RJControls.RJButton();
            this.btnSix = new CustomControls.RJControls.RJButton();
            this.btnFive = new CustomControls.RJControls.RJButton();
            this.btnFour = new CustomControls.RJControls.RJButton();
            this.btnMultiply = new CustomControls.RJControls.RJButton();
            this.btnNine = new CustomControls.RJControls.RJButton();
            this.btnEight = new CustomControls.RJControls.RJButton();
            this.btnSeven = new CustomControls.RJControls.RJButton();
            this.btnDivide = new CustomControls.RJControls.RJButton();
            this.btnAC = new CustomControls.RJControls.RJButton();
            this.btnPlusMinus = new CustomControls.RJControls.RJButton();
            this.btnPercentage = new CustomControls.RJControls.RJButton();
            this.btnBackspace = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCalculator);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(302, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxDisplayRecent
            // 
            this.txtBoxDisplayRecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.txtBoxDisplayRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDisplayRecent.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxDisplayRecent.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtBoxDisplayRecent.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxDisplayRecent.Location = new System.Drawing.Point(0, 42);
            this.txtBoxDisplayRecent.Multiline = true;
            this.txtBoxDisplayRecent.Name = "txtBoxDisplayRecent";
            this.txtBoxDisplayRecent.Size = new System.Drawing.Size(339, 29);
            this.txtBoxDisplayRecent.TabIndex = 1;
            this.txtBoxDisplayRecent.Text = "45 + 64 =   ";
            this.txtBoxDisplayRecent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxDisplay
            // 
            this.txtBoxDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.txtBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxDisplay.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.txtBoxDisplay.ForeColor = System.Drawing.Color.Black;
            this.txtBoxDisplay.Location = new System.Drawing.Point(0, 71);
            this.txtBoxDisplay.Multiline = true;
            this.txtBoxDisplay.Name = "txtBoxDisplay";
            this.txtBoxDisplay.Size = new System.Drawing.Size(339, 55);
            this.txtBoxDisplay.TabIndex = 2;
            this.txtBoxDisplay.Text = "109  ";
            this.txtBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnZero.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnZero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnZero.BorderRadius = 20;
            this.btnZero.BorderSize = 0;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnZero.ForeColor = System.Drawing.Color.Black;
            this.btnZero.Location = new System.Drawing.Point(9, 434);
            this.btnZero.Margin = new System.Windows.Forms.Padding(0);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 60);
            this.btnZero.TabIndex = 22;
            this.btnZero.Text = "0";
            this.btnZero.TextColor = System.Drawing.Color.Black;
            this.btnZero.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnDot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnDot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnDot.BorderRadius = 20;
            this.btnDot.BorderSize = 0;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDot.ForeColor = System.Drawing.Color.Black;
            this.btnDot.Location = new System.Drawing.Point(91, 434);
            this.btnDot.Margin = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(75, 60);
            this.btnDot.TabIndex = 21;
            this.btnDot.Text = ".";
            this.btnDot.TextColor = System.Drawing.Color.Black;
            this.btnDot.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnEqual.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnEqual.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnEqual.BorderRadius = 20;
            this.btnEqual.BorderSize = 0;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEqual.ForeColor = System.Drawing.Color.Black;
            this.btnEqual.Location = new System.Drawing.Point(173, 434);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(0);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 60);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.TextColor = System.Drawing.Color.Black;
            this.btnEqual.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(255, 434);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 60);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "+";
            this.btnAdd.TextColor = System.Drawing.Color.Black;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnThree.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnThree.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnThree.BorderRadius = 20;
            this.btnThree.BorderSize = 0;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnThree.ForeColor = System.Drawing.Color.Black;
            this.btnThree.Location = new System.Drawing.Point(173, 361);
            this.btnThree.Margin = new System.Windows.Forms.Padding(0);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(75, 60);
            this.btnThree.TabIndex = 18;
            this.btnThree.Text = "3";
            this.btnThree.TextColor = System.Drawing.Color.Black;
            this.btnThree.UseVisualStyleBackColor = false;
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnTwo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnTwo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnTwo.BorderRadius = 20;
            this.btnTwo.BorderSize = 0;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTwo.ForeColor = System.Drawing.Color.Black;
            this.btnTwo.Location = new System.Drawing.Point(91, 361);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(75, 60);
            this.btnTwo.TabIndex = 17;
            this.btnTwo.Text = "2";
            this.btnTwo.TextColor = System.Drawing.Color.Black;
            this.btnTwo.UseVisualStyleBackColor = false;
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnOne.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnOne.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnOne.BorderRadius = 20;
            this.btnOne.BorderSize = 0;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOne.ForeColor = System.Drawing.Color.Black;
            this.btnOne.Location = new System.Drawing.Point(9, 361);
            this.btnOne.Margin = new System.Windows.Forms.Padding(0);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(75, 60);
            this.btnOne.TabIndex = 16;
            this.btnOne.Text = "1";
            this.btnOne.TextColor = System.Drawing.Color.Black;
            this.btnOne.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnSubtract.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnSubtract.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnSubtract.BorderRadius = 20;
            this.btnSubtract.BorderSize = 0;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSubtract.ForeColor = System.Drawing.Color.Black;
            this.btnSubtract.Location = new System.Drawing.Point(255, 361);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 60);
            this.btnSubtract.TabIndex = 15;
            this.btnSubtract.Text = "-";
            this.btnSubtract.TextColor = System.Drawing.Color.Black;
            this.btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnSix.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnSix.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnSix.BorderRadius = 20;
            this.btnSix.BorderSize = 0;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSix.ForeColor = System.Drawing.Color.Black;
            this.btnSix.Location = new System.Drawing.Point(173, 287);
            this.btnSix.Margin = new System.Windows.Forms.Padding(0);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(75, 60);
            this.btnSix.TabIndex = 14;
            this.btnSix.Text = "6";
            this.btnSix.TextColor = System.Drawing.Color.Black;
            this.btnSix.UseVisualStyleBackColor = false;
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnFive.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnFive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnFive.BorderRadius = 20;
            this.btnFive.BorderSize = 0;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFive.ForeColor = System.Drawing.Color.Black;
            this.btnFive.Location = new System.Drawing.Point(91, 287);
            this.btnFive.Margin = new System.Windows.Forms.Padding(0);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(75, 60);
            this.btnFive.TabIndex = 13;
            this.btnFive.Text = "5";
            this.btnFive.TextColor = System.Drawing.Color.Black;
            this.btnFive.UseVisualStyleBackColor = false;
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnFour.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnFour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnFour.BorderRadius = 20;
            this.btnFour.BorderSize = 0;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFour.ForeColor = System.Drawing.Color.Black;
            this.btnFour.Location = new System.Drawing.Point(9, 287);
            this.btnFour.Margin = new System.Windows.Forms.Padding(0);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(75, 60);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "4";
            this.btnFour.TextColor = System.Drawing.Color.Black;
            this.btnFour.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnMultiply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnMultiply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnMultiply.BorderRadius = 20;
            this.btnMultiply.BorderSize = 0;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnMultiply.ForeColor = System.Drawing.Color.Black;
            this.btnMultiply.Location = new System.Drawing.Point(255, 287);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 60);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "×";
            this.btnMultiply.TextColor = System.Drawing.Color.Black;
            this.btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnNine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnNine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnNine.BorderRadius = 20;
            this.btnNine.BorderSize = 0;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNine.ForeColor = System.Drawing.Color.Black;
            this.btnNine.Location = new System.Drawing.Point(173, 213);
            this.btnNine.Margin = new System.Windows.Forms.Padding(0);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(75, 60);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.TextColor = System.Drawing.Color.Black;
            this.btnNine.UseVisualStyleBackColor = false;
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnEight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnEight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnEight.BorderRadius = 20;
            this.btnEight.BorderSize = 0;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnEight.ForeColor = System.Drawing.Color.Black;
            this.btnEight.Location = new System.Drawing.Point(91, 213);
            this.btnEight.Margin = new System.Windows.Forms.Padding(0);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(75, 60);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.TextColor = System.Drawing.Color.Black;
            this.btnEight.UseVisualStyleBackColor = false;
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnSeven.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnSeven.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnSeven.BorderRadius = 20;
            this.btnSeven.BorderSize = 0;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSeven.ForeColor = System.Drawing.Color.Black;
            this.btnSeven.Location = new System.Drawing.Point(9, 213);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(75, 60);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.TextColor = System.Drawing.Color.Black;
            this.btnSeven.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnDivide.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnDivide.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnDivide.BorderRadius = 20;
            this.btnDivide.BorderSize = 0;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDivide.ForeColor = System.Drawing.Color.Black;
            this.btnDivide.Location = new System.Drawing.Point(255, 213);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 60);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "÷";
            this.btnDivide.TextColor = System.Drawing.Color.Black;
            this.btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnAC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnAC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnAC.BorderRadius = 20;
            this.btnAC.BorderSize = 0;
            this.btnAC.FlatAppearance.BorderSize = 0;
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAC.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAC.ForeColor = System.Drawing.Color.Black;
            this.btnAC.Location = new System.Drawing.Point(173, 139);
            this.btnAC.Margin = new System.Windows.Forms.Padding(0);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(75, 60);
            this.btnAC.TabIndex = 6;
            this.btnAC.Text = "AC";
            this.btnAC.TextColor = System.Drawing.Color.Black;
            this.btnAC.UseVisualStyleBackColor = false;
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnPlusMinus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnPlusMinus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnPlusMinus.BorderRadius = 20;
            this.btnPlusMinus.BorderSize = 0;
            this.btnPlusMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusMinus.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPlusMinus.ForeColor = System.Drawing.Color.Black;
            this.btnPlusMinus.Location = new System.Drawing.Point(91, 139);
            this.btnPlusMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(75, 60);
            this.btnPlusMinus.TabIndex = 5;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.TextColor = System.Drawing.Color.Black;
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnPercentage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnPercentage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnPercentage.BorderRadius = 20;
            this.btnPercentage.BorderSize = 0;
            this.btnPercentage.FlatAppearance.BorderSize = 0;
            this.btnPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercentage.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPercentage.ForeColor = System.Drawing.Color.Black;
            this.btnPercentage.Location = new System.Drawing.Point(9, 139);
            this.btnPercentage.Margin = new System.Windows.Forms.Padding(0);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(75, 60);
            this.btnPercentage.TabIndex = 4;
            this.btnPercentage.Text = "%";
            this.btnPercentage.TextColor = System.Drawing.Color.Black;
            this.btnPercentage.UseVisualStyleBackColor = false;
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnBackspace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnBackspace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(241)))), ((int)(((byte)(238)))));
            this.btnBackspace.BorderRadius = 20;
            this.btnBackspace.BorderSize = 0;
            this.btnBackspace.FlatAppearance.BorderSize = 0;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Tahoma", 22F);
            this.btnBackspace.ForeColor = System.Drawing.Color.Black;
            this.btnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackspace.Image")));
            this.btnBackspace.Location = new System.Drawing.Point(255, 139);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(75, 60);
            this.btnBackspace.TabIndex = 3;
            this.btnBackspace.TextColor = System.Drawing.Color.Black;
            this.btnBackspace.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(339, 506);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnPercentage);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.txtBoxDisplay);
            this.Controls.Add(this.txtBoxDisplayRecent);
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
        private CustomControls.RJControls.RJButton btnBackspace;
        private System.Windows.Forms.TextBox txtBoxDisplay;
        private CustomControls.RJControls.RJButton btnPercentage;
        private CustomControls.RJControls.RJButton btnPlusMinus;
        private CustomControls.RJControls.RJButton btnAC;
        private CustomControls.RJControls.RJButton btnNine;
        private CustomControls.RJControls.RJButton btnEight;
        private CustomControls.RJControls.RJButton btnSeven;
        private CustomControls.RJControls.RJButton btnDivide;
        private CustomControls.RJControls.RJButton btnSix;
        private CustomControls.RJControls.RJButton btnFive;
        private CustomControls.RJControls.RJButton btnFour;
        private CustomControls.RJControls.RJButton btnMultiply;
        private CustomControls.RJControls.RJButton btnThree;
        private CustomControls.RJControls.RJButton btnTwo;
        private CustomControls.RJControls.RJButton btnOne;
        private CustomControls.RJControls.RJButton btnSubtract;
        private CustomControls.RJControls.RJButton btnAdd;
        private CustomControls.RJControls.RJButton btnEqual;
        private CustomControls.RJControls.RJButton btnDot;
        private CustomControls.RJControls.RJButton btnZero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCalculator;
    }
}

