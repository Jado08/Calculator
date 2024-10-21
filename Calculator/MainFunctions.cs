using CustomControls.RJControls;
using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainFunctions : Form
    {
        private bool isOperatorClicked = false;  // To track if an operator was clicked
        private bool isEqualsClicked = false;    // To track if equals was clicked
        private bool isNumberClicked = false;    // To track if a number was clicked

        public MainFunctions()
        {
            InitializeComponent();
        }

        // Button: Close Application
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Button: Left Parenthesis
        private void btnLeftParenthesis_Click(object sender, EventArgs e)
        {
            if (isEqualsClicked)
            {
                txtBoxDisplay.Clear();
                txtBoxDisplayRecent.Clear();
                isEqualsClicked = false;
            }

            txtBoxDisplayRecent.Text += "(";
            isOperatorClicked = false;  // Reset operator flag since this is not an operator
        }

        // Button: Right Parenthesis - Just append, don't solve yet
        private void btnRightParenthesis_Click(object sender, EventArgs e)
        {
            txtBoxDisplayRecent.Text += txtBoxDisplay.Text + ")";
            txtBoxDisplay.Clear();  // Clear the display to continue input
            isOperatorClicked = false;  // Reset operator flag
        }

        // Button: Numbers and Dot
        private void NumberButton_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;

            // If equals was clicked, start a new expression
            if (isEqualsClicked)
            {
                txtBoxDisplay.Clear();
                txtBoxDisplayRecent.Clear();
                isEqualsClicked = false;
            }

            // If an operator was clicked, clear the display for the new number input
            if (isOperatorClicked)
            {
                txtBoxDisplay.Clear();
                isOperatorClicked = false;
            }

            txtBoxDisplay.Text += btn.Text;
            isNumberClicked = true;  // A number was clicked
        }

        // Button: Operators (+, -, *, /)
        private void OperationButton_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;

            // Ignore operator clicks if no number was clicked before
            if (!isNumberClicked) return;

            // If equals was clicked, start a new expression after the result
            if (isEqualsClicked)
            {
                isEqualsClicked = false;
            }

            // Prevent consecutive operator clicks
            if (!isOperatorClicked)
            {
                // Append the current number and operator to the recent display
                txtBoxDisplayRecent.Text += txtBoxDisplay.Text + " " + btn.Text + " ";
                isOperatorClicked = true;  // Mark that an operator was clicked
                isNumberClicked = false;   // Reset the number flag until a new number is clicked
            }
        }

        // Button: Equals - Solve the expression
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!isEqualsClicked)
            {
                txtBoxDisplayRecent.Text += txtBoxDisplay.Text;  // Append current number to the expression
                Program.SolveExpression(txtBoxDisplay, txtBoxDisplayRecent);

                // Check if the message "There's no history yet." exists, if so, clear it
                if (txtBoxHistoryList.Text == "There's no history yet.")
                {
                    txtBoxHistoryList.Clear();
                }

                // Add the equation and result to the history
                txtBoxHistoryList.AppendText(txtBoxDisplayRecent.Text + Environment.NewLine);
                txtBoxHistoryList.AppendText(txtBoxDisplay.Text + Environment.NewLine + Environment.NewLine);  // Result on the next line

                isEqualsClicked = true;
                isOperatorClicked = false;
                isNumberClicked = false;
            }
        }

        // Button: AC (Clear All)
        private void btnAC_Click(object sender, EventArgs e)
        {
            txtBoxDisplay.Clear();
            txtBoxDisplayRecent.Clear();
            isOperatorClicked = false;
            isEqualsClicked = false;
            isNumberClicked = false;
        }

        // Button: Backspace (Delete last character)
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtBoxDisplay.Text.Length > 0)
            {
                txtBoxDisplay.Text = txtBoxDisplay.Text.Substring(0, txtBoxDisplay.Text.Length - 1);
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            // Check if there's no history yet
            if (string.IsNullOrWhiteSpace(txtBoxHistoryList.Text))
            {
                txtBoxHistoryList.Text = "There's no history yet.";
            }

            if (pnlFooter.Height == 5)
            {
                pnlFooter.Height = 315;
                pnlFooter.Top -= (315 - 5); // Move it upwards by the difference in height
            }
            else
            {
                pnlFooter.Top += (315 - 5); // Move it back down to its original position
                pnlFooter.Height = 5;
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            txtBoxHistoryList.Clear();
        }
    }
}