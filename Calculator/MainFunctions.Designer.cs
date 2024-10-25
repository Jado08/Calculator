namespace Calculator
{
    partial class MainFunctions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFunctions));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblCalculator = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBoxDisplayRecent = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.txtBoxHistoryList = new System.Windows.Forms.TextBox();
            this.btnClearHistory = new CustomControls.RJControls.RJButton();
            this.btnHistory = new CustomControls.RJControls.RJButton();
            this.btnLeftParenthesis = new CustomControls.RJControls.RJButton();
            this.btnEquals = new CustomControls.RJControls.RJButton();
            this.btnAddition = new CustomControls.RJControls.RJButton();
            this.btnSubtract = new CustomControls.RJControls.RJButton();
            this.btnMultiply = new CustomControls.RJControls.RJButton();
            this.btnDivide = new CustomControls.RJControls.RJButton();
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
            this.btnBackspace = new CustomControls.RJControls.RJButton();
            this.btnAC = new CustomControls.RJControls.RJButton();
            this.btnRightParenthesis = new CustomControls.RJControls.RJButton();
            this.ellipseForm1 = new Calculator.EllipseForm();
            this.ellipseFormPnlFooter = new Calculator.EllipseForm();
            this.txtBoxDisplay = new System.Windows.Forms.TextBox();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(143)))), ((int)(((byte)(10)))));
            this.pnlHeader.Controls.Add(this.lblCalculator);
            this.pnlHeader.Controls.Add(this.button1);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(318, 42);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblCalculator
            // 
            this.lblCalculator.AutoSize = true;
            this.lblCalculator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculator.Location = new System.Drawing.Point(29, 14);
            this.lblCalculator.Name = "lblCalculator";
            this.lblCalculator.Size = new System.Drawing.Size(98, 25);
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
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(280, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxDisplayRecent
            // 
            this.txtBoxDisplayRecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtBoxDisplayRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDisplayRecent.Enabled = false;
            this.txtBoxDisplayRecent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBoxDisplayRecent.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxDisplayRecent.Location = new System.Drawing.Point(3, 84);
            this.txtBoxDisplayRecent.Multiline = true;
            this.txtBoxDisplayRecent.Name = "txtBoxDisplayRecent";
            this.txtBoxDisplayRecent.Size = new System.Drawing.Size(302, 24);
            this.txtBoxDisplayRecent.TabIndex = 1;
            this.txtBoxDisplayRecent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.txtBoxHistoryList);
            this.pnlFooter.Controls.Add(this.btnClearHistory);
            this.pnlFooter.Location = new System.Drawing.Point(3, 523);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(315, 5);
            this.pnlFooter.TabIndex = 0;
            // 
            // txtBoxHistoryList
            // 
            this.txtBoxHistoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtBoxHistoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxHistoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxHistoryList.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBoxHistoryList.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxHistoryList.Location = new System.Drawing.Point(0, 0);
            this.txtBoxHistoryList.Margin = new System.Windows.Forms.Padding(0);
            this.txtBoxHistoryList.Multiline = true;
            this.txtBoxHistoryList.Name = "txtBoxHistoryList";
            this.txtBoxHistoryList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxHistoryList.Size = new System.Drawing.Size(315, 0);
            this.txtBoxHistoryList.TabIndex = 49;
            this.txtBoxHistoryList.TabStop = false;
            this.txtBoxHistoryList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnClearHistory.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClearHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnClearHistory.BorderRadius = 27;
            this.btnClearHistory.BorderSize = 0;
            this.btnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearHistory.FlatAppearance.BorderSize = 0;
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnClearHistory.ForeColor = System.Drawing.Color.Black;
            this.btnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnClearHistory.Image")));
            this.btnClearHistory.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnClearHistory.Location = new System.Drawing.Point(0, -32);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(315, 37);
            this.btnClearHistory.TabIndex = 46;
            this.btnClearHistory.TextColor = System.Drawing.Color.Black;
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnHistory.BorderRadius = 27;
            this.btnHistory.BorderSize = 0;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(258, 42);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(47, 42);
            this.btnHistory.TabIndex = 45;
            this.btnHistory.TextColor = System.Drawing.Color.Black;
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnLeftParenthesis
            // 
            this.btnLeftParenthesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(173)))), ((int)(((byte)(41)))));
            this.btnLeftParenthesis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(173)))), ((int)(((byte)(41)))));
            this.btnLeftParenthesis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnLeftParenthesis.BorderRadius = 34;
            this.btnLeftParenthesis.BorderSize = 0;
            this.btnLeftParenthesis.FlatAppearance.BorderSize = 0;
            this.btnLeftParenthesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftParenthesis.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnLeftParenthesis.ForeColor = System.Drawing.Color.Black;
            this.btnLeftParenthesis.Location = new System.Drawing.Point(9, 174);
            this.btnLeftParenthesis.Margin = new System.Windows.Forms.Padding(0);
            this.btnLeftParenthesis.Name = "btnLeftParenthesis";
            this.btnLeftParenthesis.Size = new System.Drawing.Size(68, 68);
            this.btnLeftParenthesis.TabIndex = 44;
            this.btnLeftParenthesis.TabStop = false;
            this.btnLeftParenthesis.Text = "(";
            this.btnLeftParenthesis.TextColor = System.Drawing.Color.Black;
            this.btnLeftParenthesis.UseVisualStyleBackColor = false;
            this.btnLeftParenthesis.Click += new System.EventHandler(this.btnLeftParenthesis_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(130)))), ((int)(((byte)(9)))));
            this.btnEquals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(130)))), ((int)(((byte)(9)))));
            this.btnEquals.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnEquals.BorderRadius = 34;
            this.btnEquals.BorderSize = 0;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.Black;
            this.btnEquals.Location = new System.Drawing.Point(161, 455);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(68, 68);
            this.btnEquals.TabIndex = 43;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "=";
            this.btnEquals.TextColor = System.Drawing.Color.Black;
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnAddition.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnAddition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnAddition.BorderRadius = 34;
            this.btnAddition.BorderSize = 0;
            this.btnAddition.FlatAppearance.BorderSize = 0;
            this.btnAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddition.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnAddition.ForeColor = System.Drawing.Color.Black;
            this.btnAddition.Location = new System.Drawing.Point(237, 455);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(68, 68);
            this.btnAddition.TabIndex = 42;
            this.btnAddition.TabStop = false;
            this.btnAddition.Text = "+";
            this.btnAddition.TextColor = System.Drawing.Color.Black;
            this.btnAddition.UseVisualStyleBackColor = false;
            this.btnAddition.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnSubtract.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnSubtract.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnSubtract.BorderRadius = 34;
            this.btnSubtract.BorderSize = 0;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnSubtract.ForeColor = System.Drawing.Color.Black;
            this.btnSubtract.Location = new System.Drawing.Point(237, 385);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(68, 68);
            this.btnSubtract.TabIndex = 41;
            this.btnSubtract.TabStop = false;
            this.btnSubtract.Text = "-";
            this.btnSubtract.TextColor = System.Drawing.Color.Black;
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnMultiply.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnMultiply.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnMultiply.BorderRadius = 34;
            this.btnMultiply.BorderSize = 0;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnMultiply.ForeColor = System.Drawing.Color.Black;
            this.btnMultiply.Location = new System.Drawing.Point(237, 314);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(0);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(68, 68);
            this.btnMultiply.TabIndex = 40;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "*";
            this.btnMultiply.TextColor = System.Drawing.Color.Black;
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnDivide.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(181)))), ((int)(((byte)(60)))));
            this.btnDivide.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnDivide.BorderRadius = 34;
            this.btnDivide.BorderSize = 0;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.btnDivide.ForeColor = System.Drawing.Color.Black;
            this.btnDivide.Location = new System.Drawing.Point(237, 244);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(0);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(68, 68);
            this.btnDivide.TabIndex = 39;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.TextColor = System.Drawing.Color.Black;
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnDot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnDot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnDot.BorderRadius = 34;
            this.btnDot.BorderSize = 0;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnDot.ForeColor = System.Drawing.Color.Black;
            this.btnDot.Location = new System.Drawing.Point(85, 456);
            this.btnDot.Margin = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(68, 68);
            this.btnDot.TabIndex = 37;
            this.btnDot.TabStop = false;
            this.btnDot.Text = "0";
            this.btnDot.TextColor = System.Drawing.Color.Black;
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnZero.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnZero.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnZero.BorderRadius = 34;
            this.btnZero.BorderSize = 0;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.Black;
            this.btnZero.Location = new System.Drawing.Point(9, 455);
            this.btnZero.Margin = new System.Windows.Forms.Padding(0);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(68, 68);
            this.btnZero.TabIndex = 36;
            this.btnZero.TabStop = false;
            this.btnZero.Text = ".";
            this.btnZero.TextColor = System.Drawing.Color.Black;
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnThree.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnThree.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnThree.BorderRadius = 34;
            this.btnThree.BorderSize = 0;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnThree.ForeColor = System.Drawing.Color.Black;
            this.btnThree.Location = new System.Drawing.Point(161, 385);
            this.btnThree.Margin = new System.Windows.Forms.Padding(0);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(68, 68);
            this.btnThree.TabIndex = 35;
            this.btnThree.TabStop = false;
            this.btnThree.Text = "3";
            this.btnThree.TextColor = System.Drawing.Color.Black;
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnTwo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnTwo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnTwo.BorderRadius = 34;
            this.btnTwo.BorderSize = 0;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnTwo.ForeColor = System.Drawing.Color.Black;
            this.btnTwo.Location = new System.Drawing.Point(85, 386);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(0);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(68, 68);
            this.btnTwo.TabIndex = 34;
            this.btnTwo.TabStop = false;
            this.btnTwo.Text = "2";
            this.btnTwo.TextColor = System.Drawing.Color.Black;
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnOne.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnOne.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnOne.BorderRadius = 34;
            this.btnOne.BorderSize = 0;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnOne.ForeColor = System.Drawing.Color.Black;
            this.btnOne.Location = new System.Drawing.Point(9, 385);
            this.btnOne.Margin = new System.Windows.Forms.Padding(0);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(68, 68);
            this.btnOne.TabIndex = 33;
            this.btnOne.TabStop = false;
            this.btnOne.Text = "1";
            this.btnOne.TextColor = System.Drawing.Color.Black;
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnSix.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnSix.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnSix.BorderRadius = 34;
            this.btnSix.BorderSize = 0;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSix.ForeColor = System.Drawing.Color.Black;
            this.btnSix.Location = new System.Drawing.Point(161, 314);
            this.btnSix.Margin = new System.Windows.Forms.Padding(0);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(68, 68);
            this.btnSix.TabIndex = 32;
            this.btnSix.TabStop = false;
            this.btnSix.Text = "6";
            this.btnSix.TextColor = System.Drawing.Color.Black;
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnFive.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnFive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnFive.BorderRadius = 34;
            this.btnFive.BorderSize = 0;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnFive.ForeColor = System.Drawing.Color.Black;
            this.btnFive.Location = new System.Drawing.Point(85, 314);
            this.btnFive.Margin = new System.Windows.Forms.Padding(0);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(68, 68);
            this.btnFive.TabIndex = 31;
            this.btnFive.TabStop = false;
            this.btnFive.Text = "5";
            this.btnFive.TextColor = System.Drawing.Color.Black;
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnFour.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnFour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnFour.BorderRadius = 34;
            this.btnFour.BorderSize = 0;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnFour.ForeColor = System.Drawing.Color.Black;
            this.btnFour.Location = new System.Drawing.Point(9, 314);
            this.btnFour.Margin = new System.Windows.Forms.Padding(0);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(68, 68);
            this.btnFour.TabIndex = 30;
            this.btnFour.TabStop = false;
            this.btnFour.Text = "4";
            this.btnFour.TextColor = System.Drawing.Color.Black;
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnNine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnNine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnNine.BorderRadius = 34;
            this.btnNine.BorderSize = 0;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnNine.ForeColor = System.Drawing.Color.Black;
            this.btnNine.Location = new System.Drawing.Point(161, 244);
            this.btnNine.Margin = new System.Windows.Forms.Padding(0);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(68, 68);
            this.btnNine.TabIndex = 29;
            this.btnNine.TabStop = false;
            this.btnNine.Text = "9";
            this.btnNine.TextColor = System.Drawing.Color.Black;
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnEight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnEight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnEight.BorderRadius = 34;
            this.btnEight.BorderSize = 0;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnEight.ForeColor = System.Drawing.Color.Black;
            this.btnEight.Location = new System.Drawing.Point(85, 244);
            this.btnEight.Margin = new System.Windows.Forms.Padding(0);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(68, 68);
            this.btnEight.TabIndex = 28;
            this.btnEight.TabStop = false;
            this.btnEight.Text = "8";
            this.btnEight.TextColor = System.Drawing.Color.Black;
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnSeven.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(197)))));
            this.btnSeven.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnSeven.BorderRadius = 34;
            this.btnSeven.BorderSize = 0;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.Color.Black;
            this.btnSeven.Location = new System.Drawing.Point(9, 244);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(0);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(68, 68);
            this.btnSeven.TabIndex = 27;
            this.btnSeven.TabStop = false;
            this.btnSeven.Text = "7";
            this.btnSeven.TextColor = System.Drawing.Color.Black;
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(173)))), ((int)(((byte)(41)))));
            this.btnBackspace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(173)))), ((int)(((byte)(41)))));
            this.btnBackspace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnBackspace.BorderRadius = 34;
            this.btnBackspace.BorderSize = 0;
            this.btnBackspace.FlatAppearance.BorderSize = 0;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnBackspace.ForeColor = System.Drawing.Color.Black;
            this.btnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackspace.Image")));
            this.btnBackspace.Location = new System.Drawing.Point(237, 174);
            this.btnBackspace.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(68, 68);
            this.btnBackspace.TabIndex = 26;
            this.btnBackspace.TabStop = false;
            this.btnBackspace.TextColor = System.Drawing.Color.Black;
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnAC
            // 
            this.btnAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(173)))), ((int)(((byte)(41)))));
            this.btnAC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(173)))), ((int)(((byte)(41)))));
            this.btnAC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnAC.BorderRadius = 34;
            this.btnAC.BorderSize = 0;
            this.btnAC.FlatAppearance.BorderSize = 0;
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAC.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnAC.ForeColor = System.Drawing.Color.Black;
            this.btnAC.Location = new System.Drawing.Point(161, 174);
            this.btnAC.Margin = new System.Windows.Forms.Padding(0);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(68, 68);
            this.btnAC.TabIndex = 25;
            this.btnAC.TabStop = false;
            this.btnAC.Text = "AC";
            this.btnAC.TextColor = System.Drawing.Color.Black;
            this.btnAC.UseVisualStyleBackColor = false;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnRightParenthesis
            // 
            this.btnRightParenthesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(173)))), ((int)(((byte)(41)))));
            this.btnRightParenthesis.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(173)))), ((int)(((byte)(41)))));
            this.btnRightParenthesis.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(212)))), ((int)(((byte)(203)))));
            this.btnRightParenthesis.BorderRadius = 34;
            this.btnRightParenthesis.BorderSize = 0;
            this.btnRightParenthesis.FlatAppearance.BorderSize = 0;
            this.btnRightParenthesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightParenthesis.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnRightParenthesis.ForeColor = System.Drawing.Color.Black;
            this.btnRightParenthesis.Location = new System.Drawing.Point(85, 174);
            this.btnRightParenthesis.Margin = new System.Windows.Forms.Padding(0);
            this.btnRightParenthesis.Name = "btnRightParenthesis";
            this.btnRightParenthesis.Size = new System.Drawing.Size(68, 68);
            this.btnRightParenthesis.TabIndex = 24;
            this.btnRightParenthesis.TabStop = false;
            this.btnRightParenthesis.Text = ")";
            this.btnRightParenthesis.TextColor = System.Drawing.Color.Black;
            this.btnRightParenthesis.UseVisualStyleBackColor = false;
            this.btnRightParenthesis.Click += new System.EventHandler(this.btnRightParenthesis_Click_1);
            // 
            // ellipseForm1
            // 
            this.ellipseForm1.CornerRadius = 25;
            this.ellipseForm1.targetControl = this;
            // 
            // ellipseFormPnlFooter
            // 
            this.ellipseFormPnlFooter.CornerRadius = 25;
            this.ellipseFormPnlFooter.targetControl = this.pnlFooter;
            // 
            // txtBoxDisplay
            // 
            this.txtBoxDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDisplay.Enabled = false;
            this.txtBoxDisplay.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.txtBoxDisplay.ForeColor = System.Drawing.Color.Black;
            this.txtBoxDisplay.Location = new System.Drawing.Point(3, 114);
            this.txtBoxDisplay.Multiline = true;
            this.txtBoxDisplay.Name = "txtBoxDisplay";
            this.txtBoxDisplay.Size = new System.Drawing.Size(302, 56);
            this.txtBoxDisplay.TabIndex = 2;
            this.txtBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainFunctions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(318, 537);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnLeftParenthesis);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
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
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.btnRightParenthesis);
            this.Controls.Add(this.txtBoxDisplayRecent);
            this.Controls.Add(this.txtBoxDisplay);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFunctions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBoxDisplayRecent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCalculator;
        private CustomControls.RJControls.RJButton btnRightParenthesis;
        private CustomControls.RJControls.RJButton btnAC;
        private CustomControls.RJControls.RJButton btnBackspace;
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
        private CustomControls.RJControls.RJButton btnDivide;
        private CustomControls.RJControls.RJButton btnMultiply;
        private CustomControls.RJControls.RJButton btnSubtract;
        private CustomControls.RJControls.RJButton btnAddition;
        private CustomControls.RJControls.RJButton btnEquals;
        private CustomControls.RJControls.RJButton btnLeftParenthesis;
        private EllipseForm ellipseForm1;
        private CustomControls.RJControls.RJButton btnHistory;
        private System.Windows.Forms.Panel pnlFooter;
        private CustomControls.RJControls.RJButton btnClearHistory;
        private System.Windows.Forms.TextBox txtBoxHistoryList;
        private EllipseForm ellipseFormPnlFooter;
        private System.Windows.Forms.TextBox txtBoxDisplay;
    }
}

