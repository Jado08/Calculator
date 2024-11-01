using CustomControls.RJControls;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;

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
        private bool hasError = false;

        public MainFunctions()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(MainFunctions_KeyPress);
            this.KeyPreview = true;

            lblDisplay.Text = "0";
        }

        // mainfunctions for keypress ---------------------------------------------------------|
        private void MainFunctions_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            else if (e.KeyChar == 'h')
            {
                btnHistory_Click(sender, e);
            }

            e.Handled = true;
        }

        //refractor: NumberButton_Click and HandleNumberInput ----------------------------------|
        private void ProcessNumberInput(string input)
        {
            if (input == ".")
            {
                if (isOperatorClicked)
                {
                    lblDisplay.Text = "0.";
                    isOperatorClicked = false;
                }
                else if (string.IsNullOrEmpty(lblDisplay.Text) || lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "0.";
                }
                else if (!lblDisplay.Text.Contains("."))
                {
                    lblDisplay.Text += ".";
                }
                return;
            }

            if (isEqualsClicked)
            {
                lblDisplay.Text = "";
                txtBoxDisplayRecent.Clear();
                isEqualsClicked = false;
            }

            if (isOperatorClicked)
            {
                lblDisplay.Text = "";
                isOperatorClicked = false;
            }

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = input;
            }
            else
            {
                lblDisplay.Text += input;
            }

            isNumberClicked = true;
        }
        private void HandleNumberInput(KeyPressEventArgs e)
        {
            ProcessNumberInput(e.KeyChar.ToString());
            e.Handled = true;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            ProcessNumberInput(btn.Text);
        }

        //refractor: OperationButton_Click and HandleOperatorInput -----------------------------|
        private void ProcessOperatorInput(string input)
        {
            if (hasError) return; // Block input on error
            if (lblDisplay.Text == "0.")
            {
                lblDisplay.Text = "0";
            }

            if (string.IsNullOrEmpty(lblDisplay.Text))
            {
                return;
            }

            if (isEqualsClicked)
            {
                txtBoxDisplayRecent.Text = lblDisplay.Text + " " + input + " ";
                isEqualsClicked = false;
            }
            else if (isOperatorClicked)
            {
                txtBoxDisplayRecent.Text = txtBoxDisplayRecent.Text.Substring(0, txtBoxDisplayRecent.Text.Length - 2) + input + " ";
            }
            else
            {
                txtBoxDisplayRecent.Text += lblDisplay.Text + " " + input + " ";
            }

            isOperatorClicked = true;
            isNumberClicked = false;
        }
        private void HandleOperatorInput(KeyPressEventArgs e)
        {
            if (hasError) return; // Block input on error
            ProcessOperatorInput(e.KeyChar.ToString());
            e.Handled = true;
        }
        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (hasError) return; // Block input on error
            RJButton btn = sender as RJButton;
            ProcessOperatorInput(btn.Text);
        }

        //refractor: HandleBackspace and HandLeftParenthesis -----------------------------------|
        private void PerformBackspace()
        {
            if (lblDisplay.Text.Length > 0)
            {
                lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
            }

            // Reset lblDisplay to "0" if it becomes empty
            if (string.IsNullOrEmpty(lblDisplay.Text))
            {
                lblDisplay.Text = "0";

                // Clear txtBoxDisplayRecent when lblDisplay is reset to "0"
                txtBoxDisplayRecent.Clear();
            }
        }
        private void HandleBackspace()
        {
            PerformBackspace();
        }
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            PerformBackspace();
        }

        //refractor: HandleLeftParenthesis and btnLeftParenthesis_Click ------------------------|
        private void InsertLeftParenthesis()
        {
            if (hasError) return; // Block input on error

            if (isEqualsClicked)
            {
                lblDisplay.Text = "";
                txtBoxDisplayRecent.Clear();
                isEqualsClicked = false;
            }

            // Clear '0' in display
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }

            // Check the last character of the recent display text
            string expression = txtBoxDisplayRecent.Text;
            if (expression.Length > 0)
            {
                char lastChar = expression[expression.Length - 1];

                // Only allow adding '(' if the last character is an operator, empty, or a closing parenthesis
                if ("+-*/".Contains(lastChar) || lastChar == '(' || expression == "")
                {
                    txtBoxDisplayRecent.Text += "(";
                }
                else
                {
                    // If the last character is a number, just add the parenthesis after that
                    txtBoxDisplayRecent.Text += "(";
                }
            }
            else
            {
                // If the expression is empty, just add the parenthesis
                txtBoxDisplayRecent.Text += "(";
            }
            lblDisplay.Text = "0";
            isOperatorClicked = false;
            isNumberClicked = false;
        }
        private void HandleLeftParenthesis()
        {
            InsertLeftParenthesis();
        }
        private void btnLeftParenthesis_Click(object sender, EventArgs e)
        {
            InsertLeftParenthesis();
        }

        //refractor: HandleRightParenthesis and btnRightParenthesis_Click ----------------------|
        private void InsertRightParenthesis()
        {
            if (hasError) return; // Block input on error
            if (txtBoxDisplayRecent.Text.Contains("(") && !txtBoxDisplayRecent.Text.EndsWith("("))
            {
                txtBoxDisplayRecent.Text += lblDisplay.Text + ")";
                lblDisplay.Text = "";
                isOperatorClicked = false;
            }
        }
        private void HandleRightParenthesis()
        {
            InsertRightParenthesis();
        }
        private void btnRightParenthesis_Click(object sender, EventArgs e)
        {
            InsertRightParenthesis();
        }

        // Equals (on-screen and keypress) -----------------------------------------------------|
        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!isEqualsClicked)
            {
                // Set firstOperand if it is not yet set
                if (string.IsNullOrEmpty(firstOperand))
                {
                    firstOperand = lblDisplay.Text;
                }

                // Append current display text to the recent display (for full expression)
                if (!string.IsNullOrEmpty(lblDisplay.Text))
                {
                    txtBoxDisplayRecent.Text += lblDisplay.Text;
                }

                // Auto-complete operand if expression ends with an operator
                string expression = txtBoxDisplayRecent.Text;
                if (expression.Length > 0 && "+-*/".Contains(expression[expression.Length - 1]))
                {
                    txtBoxDisplayRecent.Text += $"{firstOperand} ";
                }

                // Auto-close unbalanced parentheses
                if (!SolvingExpression.AreParenthesesBalanced(expression))
                {
                    int openCount = expression.Count(c => c == '(');
                    int closeCount = expression.Count(c => c == ')');
                    txtBoxDisplayRecent.Text += new string(')', openCount - closeCount);
                }

                // Attempt to solve the expression and handle errors
                string errorMessage = string.Empty;
                bool divisionByZero = SolvingExpression.SolveExpression(lblDisplay, txtBoxDisplayRecent, out hasError, out errorMessage);

                if (hasError)
                {
                    lblDisplay.Text = errorMessage; // Show specific error message
                    DisableAllButtons();
                    return;
                }

                // Update history if calculation was successful
                if (txtBoxHistoryList.Text == "There's no history yet.")
                {
                    txtBoxHistoryList.Clear();
                }

                txtBoxHistoryList.AppendText(txtBoxDisplayRecent.Text + Environment.NewLine);
                txtBoxHistoryList.AppendText(lblDisplay.Text + Environment.NewLine + Environment.NewLine);  // Result on the next line

                isEqualsClicked = true;
                isOperatorClicked = false;
            }
        }

        //Disabling and Enabling in dividing any number by 0
        private void DisableAllButtons()
        {
            btnLeftParenthesis.Enabled = false;
            btnRightParenthesis.Enabled = false;
            btnEquals.Enabled = false;
            btnAddition.Enabled = false;
            btnSubtract.Enabled = false;
            btnMultiply.Enabled = false;
            btnDivide.Enabled = false;
        }
        private void EnableAllButtons()
        {
            btnAddition.Enabled = true;
            btnSubtract.Enabled = true;
            btnMultiply.Enabled = true;
            btnDivide.Enabled = true;
            btnLeftParenthesis.Enabled = true;
            btnRightParenthesis.Enabled = true;
            btnEquals.Enabled = true;
        }

        // AC (All Clear - on screen and keypress) ---------------------------------------------| 
        private void btnAC_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            txtBoxDisplayRecent.Text = "";
            hasError = false; // Reset the error state
            EnableAllButtons(); // Re-enable all buttons
        }

        // History -----------------------------------------------------------------------------|
        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (pnlFooter.Height == 0)
            {
                pnlFooter.Height = 350;
                pnlFooter.Top -= (350 - 0);
            }
            else
            {
                pnlFooter.Top += (350 - 0);
                pnlFooter.Height = 0;
            }

            if (string.IsNullOrWhiteSpace(txtBoxHistoryList.Text))
            {
                txtBoxHistoryList.Text = "There's no history yet.";
            }
        }
        private void AddToHistory(string expression, string result, bool hasError)
        {
            if (!hasError)
            {
                txtBoxHistoryList.Text += $"{expression} = {result}\n";
            }
        }
        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            txtBoxHistoryList.Clear();
        }

        // Close the Application ---------------------------------------------------------------|
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

    }
}