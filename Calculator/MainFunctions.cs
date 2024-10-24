using CustomControls.RJControls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainFunctions : Form
    {
        private bool isOperatorClicked = false;
        private bool isEqualsClicked = false;
        private bool isNumberClicked = false;
        private string secondOperand = string.Empty;
        private string firstOperand = string.Empty;
        private string currentOperator = string.Empty;

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
            // Check if the key is a number or decimal point
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                HandleNumberInput(e);
            }
            else if ("+-*/".Contains(e.KeyChar.ToString()))
            {
                HandleOperatorInput(e);
            }
            else if (e.KeyChar == '(')
            {
                HandleLeftParenthesis();
            }
            else if (e.KeyChar == ')')
            {
                HandleRightParenthesis();
            }
            else if (e.KeyChar == '=' || e.KeyChar == (char)Keys.Enter)
            {
                btnEquals_Click(sender, e);
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                HandleBackspace();
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                btnAC_Click(sender, e);
            }

            // Prevent sound when the key is pressed
            e.Handled = true;
        }

        // Consolidated Number Input Logic (For Both Buttons and Keyboard)
        private void ProcessNumberInput(string input)
        {
            // Handle dot input specifically
            if (input == ".")
            {
                if (isOperatorClicked)
                {
                    txtBoxDisplay.Text = "0.";
                    isOperatorClicked = false;
                }
                else if (string.IsNullOrEmpty(txtBoxDisplay.Text) || txtBoxDisplay.Text == "0")
                {
                    txtBoxDisplay.Text = "0.";
                }
                else if (!txtBoxDisplay.Text.Contains("."))
                {
                    txtBoxDisplay.Text += ".";
                }
                return;
            }

            // Clear display if equals was clicked previously
            if (isEqualsClicked)
            {
                txtBoxDisplay.Clear();
                txtBoxDisplayRecent.Clear();
                isEqualsClicked = false;
            }

            // If an operator was clicked previously, prepare for second operand
            if (isOperatorClicked)
            {
                txtBoxDisplay.Clear();
                isOperatorClicked = false;
            }

            // Append number to display
            if (txtBoxDisplay.Text == "0")
            {
                txtBoxDisplay.Text = input; // Replace "0" with the new number
            }
            else
            {
                txtBoxDisplay.Text += input; // Append the new number
            }

            isNumberClicked = true;  // Mark that a number was clicked
        }

        // Consolidated Operator Input Logic (For Both Buttons and Keyboard)
        private void ProcessOperatorInput(string input)
        {
            // If display contains "0." but no further numbers, treat it as "0"
            if (txtBoxDisplay.Text == "0.")
            {
                txtBoxDisplay.Text = "0";
            }

            // Prevent input if no number was entered
            if (string.IsNullOrEmpty(txtBoxDisplay.Text))
            {
                return; // Ignore operator if no number was entered
            }

            // Handle continuous operation after equals
            if (isEqualsClicked)
            {
                txtBoxDisplayRecent.Text = txtBoxDisplay.Text + " " + input + " ";
                isEqualsClicked = false;
            }
            // Change operator before entering second number
            else if (isOperatorClicked)
            {
                // Change the operator in the recent expression
                txtBoxDisplayRecent.Text = txtBoxDisplayRecent.Text.Substring(0, txtBoxDisplayRecent.Text.Length - 2) + input + " ";
            }
            else
            {
                // Normal operator input (first operator after number input)
                txtBoxDisplayRecent.Text += txtBoxDisplay.Text + " " + input + " ";
            }

            isOperatorClicked = true;  // Mark that an operator was clicked
            isNumberClicked = false;   // Reset number flag to prepare for second number input

            // Do not clear the display to retain the current number
        }

        private void HandleNumberInput(KeyPressEventArgs e)
        {
            ProcessNumberInput(e.KeyChar.ToString());
            e.Handled = true; // Prevent default handling
        }

        private void HandleOperatorInput(KeyPressEventArgs e)
        {
            ProcessOperatorInput(e.KeyChar.ToString());
            e.Handled = true; // Prevent default handling
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            ProcessNumberInput(btn.Text); // Use the common processing method
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            ProcessOperatorInput(btn.Text); // Use the common processing method
        }

        private void HandleBackspace()
        {
            if (txtBoxDisplay.Text.Length > 0)
            {
                txtBoxDisplay.Text = txtBoxDisplay.Text.Substring(0, txtBoxDisplay.Text.Length - 1);
            }
        }

        private void HandleLeftParenthesis()
        {
            if (isEqualsClicked)
            {
                txtBoxDisplay.Clear();
                txtBoxDisplayRecent.Clear();
                isEqualsClicked = false;
            }

            // Clear the display if it's "0" to prevent "0("
            if (txtBoxDisplay.Text == "0")
            {
                txtBoxDisplay.Clear();
            }

            txtBoxDisplayRecent.Text += "(";  // Add just the parenthesis

            if (!string.IsNullOrEmpty(txtBoxDisplay.Text) && !isOperatorClicked)
            {
                txtBoxDisplayRecent.Text = txtBoxDisplayRecent.Text.TrimEnd('(') + txtBoxDisplay.Text + " (";
                txtBoxDisplay.Clear();  // Prepare for the next number input
            }

            isOperatorClicked = false;  // Reset operator flag since this is not an operator
        }

        private void HandleRightParenthesis()
        {
            if (txtBoxDisplayRecent.Text.Contains("(") && !txtBoxDisplayRecent.Text.EndsWith("("))
            {
                txtBoxDisplayRecent.Text += txtBoxDisplay.Text + ")";
                txtBoxDisplay.Clear();  // Clear the display to continue input
                isOperatorClicked = false;  // Reset operator flag
            }
        }

        private void btnLeftParenthesis_Click(object sender, EventArgs e)
        {
            if (isEqualsClicked)
            {
                txtBoxDisplay.Clear();
                txtBoxDisplayRecent.Clear();
                isEqualsClicked = false;
            }

            // If the display is currently "0", clear it before adding "("
            if (txtBoxDisplay.Text == "0")
            {
                txtBoxDisplay.Clear(); // Clear the "0" before adding "("
            }

            // Now, add the left parenthesis directly to txtBoxDisplayRecent
            txtBoxDisplayRecent.Text += "(";

            // If there is a number already, append it before the parenthesis
            if (!string.IsNullOrEmpty(txtBoxDisplay.Text))
            {
                txtBoxDisplayRecent.Text = txtBoxDisplayRecent.Text.TrimEnd('(') + txtBoxDisplay.Text + " ("; // Move the text to the right place
                txtBoxDisplay.Clear();  // Prepare for the next number input
            }

            isOperatorClicked = false;  // Reset operator flag since this is not an operator
            isNumberClicked = false;    // Prepare for the next number
        }

        private void btnRightParenthesis_Click_1(object sender, EventArgs e)
        {
            txtBoxDisplayRecent.Text += txtBoxDisplay.Text + ")";
            txtBoxDisplay.Clear();  // Clear the display to continue input
            isOperatorClicked = false;  // Reset operator flag
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtBoxDisplay.Text.Length > 0)
            {
                txtBoxDisplay.Text = txtBoxDisplay.Text.Substring(0, txtBoxDisplay.Text.Length - 1);
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!isEqualsClicked)
            {
                // If firstOperand is empty, set the current txtBoxDisplay value as the first operand
                if (string.IsNullOrEmpty(firstOperand))
                {
                    firstOperand = txtBoxDisplay.Text; // Store the first operand
                }

                // Append the first operand to the recent expression if equals is clicked with an operator
                if (!string.IsNullOrEmpty(txtBoxDisplay.Text))
                {
                    txtBoxDisplayRecent.Text += txtBoxDisplay.Text;
                }

                // Check if the last input is an operator
                string expression = txtBoxDisplayRecent.Text;
                if (expression.Length > 0)
                {
                    char lastChar = expression[expression.Length - 1];

                    // If the last character is an operator, append the first operand as the second operand
                    if ("+-*/".Contains(lastChar))
                    {
                        txtBoxDisplayRecent.Text += $"{firstOperand} ";  // Use formatted string to avoid double space
                    }
                }

                // Auto-complete unbalanced parentheses if needed
                if (!SolvingExpression.AreParenthesesBalanced(expression))
                {
                    int openCount = expression.Split('(').Length - 1;
                    int closeCount = expression.Split(')').Length - 1;
                    while (openCount > closeCount)
                    {
                        txtBoxDisplayRecent.Text += ")";  // Auto-complete parentheses
                        closeCount++;
                    }
                }

                // Solve the expression and check for division by zero
                bool divisionByZero = SolvingExpression.SolveExpression(txtBoxDisplay, txtBoxDisplayRecent);

                // Clear the history message if it exists
                if (txtBoxHistoryList.Text == "There's no history yet.")
                {
                    txtBoxHistoryList.Clear();
                }

                // Add the equation and result to the history
                txtBoxHistoryList.AppendText(txtBoxDisplayRecent.Text + Environment.NewLine);
                txtBoxHistoryList.AppendText(txtBoxDisplay.Text + Environment.NewLine + Environment.NewLine);  // Result on the next line

                isEqualsClicked = true;  // Set equals clicked to true
                isOperatorClicked = false;  // Reset operator flag
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtBoxDisplay.Text = "0";  // Reset to 0 instead of clearing
            txtBoxDisplayRecent.Clear();
            isOperatorClicked = false;
            isEqualsClicked = false;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}