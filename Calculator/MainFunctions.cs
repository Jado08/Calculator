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
            this.KeyPress += new KeyPressEventHandler(MainFunctions_KeyPress);
            this.KeyPreview = true;

            // Initialize txtBoxDisplay with "0" on load
            txtBoxDisplay.Text = "0";
        }

        private void MainFunctions_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle number inputs and decimal point
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
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

                // Handle decimal point entry
                if (e.KeyChar == '.')
                {
                    // If the display is empty, automatically start with "0."
                    if (string.IsNullOrEmpty(txtBoxDisplay.Text))
                    {
                        txtBoxDisplay.Text = "0.";
                    }
                    // Only allow one decimal point in the current number
                    else if (!txtBoxDisplay.Text.Contains("."))
                    {
                        txtBoxDisplay.Text += ".";
                    }
                    else
                    {
                        // Prevent entering multiple decimal points
                        e.Handled = true;
                        return;
                    }
                }
                else
                {
                    // If display contains only "0", replace it with the new number
                    if (txtBoxDisplay.Text == "0")
                    {
                        txtBoxDisplay.Text = "";  // Clear the "0" before adding numbers
                    }

                    // Add the digit to the display
                    txtBoxDisplay.Text += e.KeyChar.ToString();
                }

                isNumberClicked = true;  // A number was clicked
            }
            // Handle operators: +, -, *, /
            else if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '/')
            {
                // If the display contains "0." but no further numbers, treat it as "0"
                if (txtBoxDisplay.Text == "0.")
                {
                    txtBoxDisplay.Text = "0";  // Convert "0." to "0" when operator is clicked
                }

                // If operator is clicked after equals, carry forward the result
                if (isEqualsClicked)
                {
                    txtBoxDisplayRecent.Text = txtBoxDisplay.Text + " " + e.KeyChar + " ";
                    isEqualsClicked = false;  // Reset equals flag for further inputs
                }
                // Change operator before entering the second number (via key press)
                else if (isOperatorClicked)
                {
                    // Replace the operator in txtBoxDisplayRecent
                    txtBoxDisplayRecent.Text = txtBoxDisplayRecent.Text.Substring(0, txtBoxDisplayRecent.Text.Length - 2) + e.KeyChar + " ";
                }
                else
                {
                    // Append the current number and operator to the recent display
                    txtBoxDisplayRecent.Text += txtBoxDisplay.Text + " " + e.KeyChar + " ";
                }

                isOperatorClicked = true;  // Mark that an operator was clicked
                isNumberClicked = false;   // Reset the number flag until a new number is clicked
                txtBoxDisplay.Clear();     // Clear the display for the next input
            }
            // Handle Parentheses
            else if (e.KeyChar == '(')
            {
                // If equals was clicked, start a new expression
                if (isEqualsClicked)
                {
                    txtBoxDisplay.Clear();
                    txtBoxDisplayRecent.Clear();
                    isEqualsClicked = false;
                }

                // Append a space before the left parenthesis if there is a number already
                if (!string.IsNullOrEmpty(txtBoxDisplay.Text) && !isOperatorClicked)
                {
                    txtBoxDisplayRecent.Text += txtBoxDisplay.Text + " (";
                    txtBoxDisplay.Clear();  // Prepare for the next number input
                }
                else
                {
                    txtBoxDisplayRecent.Text += "(";  // Add just the parenthesis
                }

                isOperatorClicked = false;  // Reset operator flag since this is not an operator
                isNumberClicked = false;    // Prepare for the next number
            }
            else if (e.KeyChar == ')')
            {
                // Only add the right parenthesis if there's an open parenthesis to match it
                if (txtBoxDisplayRecent.Text.Contains("(") && !txtBoxDisplayRecent.Text.EndsWith("("))
                {
                    txtBoxDisplayRecent.Text += txtBoxDisplay.Text + ")";
                    txtBoxDisplay.Clear();  // Clear the display to continue input
                    isOperatorClicked = false;  // Reset operator flag
                }
            }
            // Handle Equals key (=)
            else if (e.KeyChar == '=')
            {
                btnEquals_Click(sender, e); // Trigger equals button click
            }
            // Handle Enter key (this is optional)
            else if (e.KeyChar == (char)Keys.Enter)
            {
                btnEquals_Click(sender, e); // Trigger equals button click
            }
            // Handle Backspace (Delete last character)
            else if (e.KeyChar == (char)Keys.Back && txtBoxDisplay.Text.Length > 0)
            {
                txtBoxDisplay.Text = txtBoxDisplay.Text.Substring(0, txtBoxDisplay.Text.Length - 1);
            }
            // Handle "AC" (All Clear) key (mapped to 'Esc' or any custom key)
            else if (e.KeyChar == (char)Keys.Escape ) // You can also choose another key for AC
            {
                btnAC_Click(sender, e); // Trigger AC button click
                txtBoxDisplay.Text = "0";  // Reset to 0 on ESC key
            }

            // Prevent sound when the key is pressed
            e.Handled = true;
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

            // If there is a number already, append a space before the parenthesis
            if (!string.IsNullOrEmpty(txtBoxDisplay.Text) && !isOperatorClicked)
            {
                txtBoxDisplayRecent.Text += txtBoxDisplay.Text + " (";
                txtBoxDisplay.Clear();  // Prepare for the next number input
            }
            else
            {
                txtBoxDisplayRecent.Text += "(";  // Add just the parenthesis
            }

            isOperatorClicked = false;  // Reset operator flag since this is not an operator
            isNumberClicked = false;    // Prepare for the next number
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

            // If the display contains only the initial "0", replace it with the new number
            if (txtBoxDisplay.Text == "0")
            {
                txtBoxDisplay.Clear();
            }

            // Handle the decimal point
            if (btn.Text == ".")
            {
                // If the display is empty, start with "0."
                if (string.IsNullOrEmpty(txtBoxDisplay.Text))
                {
                    txtBoxDisplay.Text = "0.";
                }
                // If the display doesn't already contain a decimal point, add it
                else if (!txtBoxDisplay.Text.Contains("."))
                {
                    txtBoxDisplay.Text += ".";
                }
            }
            else
            {
                // Add the number to the display
                txtBoxDisplay.Text += btn.Text;
            }

            isNumberClicked = true;  // A number was clicked
        }


        // Button: Operators (+, -, *, /)
        private void OperationButton_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;

            // If the display contains "0." but no further numbers, treat it as "0"
            if (txtBoxDisplay.Text == "0.")
            {
                txtBoxDisplay.Text = "0";  // Convert "0." to "0" when operator is clicked
            }

            // Ignore operator clicks if no number was clicked before
            if (string.IsNullOrEmpty(txtBoxDisplay.Text))
            {
                txtBoxDisplay.Text = "0";  // Ensure there's a valid "0" when operator is clicked after "."
            }

            // Handle continuous operation after equals
            if (isEqualsClicked)
            {
                // Take the result from the previous operation and append it to txtBoxDisplayRecent
                txtBoxDisplayRecent.Text = txtBoxDisplay.Text + " " + btn.Text + " ";
                isEqualsClicked = false;  // Reset the equals flag for further inputs
            }
            // Change operator before entering second number
            else if (isOperatorClicked)
            {
                // Change the operator in txtBoxDisplayRecent before the second number is entered
                txtBoxDisplayRecent.Text = txtBoxDisplayRecent.Text.Substring(0, txtBoxDisplayRecent.Text.Length - 2) + btn.Text + " ";
            }
            else
            {
                // Normal operator input (first operator after number input)
                txtBoxDisplayRecent.Text += txtBoxDisplay.Text + " " + btn.Text + " ";
            }

            isOperatorClicked = true;  // Mark that an operator was clicked
            isNumberClicked = false;   // Reset the number flag until a new number is clicked
            txtBoxDisplay.Clear();     // Clear the display for the next input
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
            txtBoxDisplay.Text = "0";  // Reset to 0 instead of clearing
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