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

            txtBoxDisplay.Text = "0";
        }

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

            e.Handled = true;
        }

        private void ProcessNumberInput(string input)
        {
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

            if (isEqualsClicked)
            {
                txtBoxDisplay.Clear();
                txtBoxDisplayRecent.Clear();
                isEqualsClicked = false;
            }

            if (isOperatorClicked)
            {
                txtBoxDisplay.Clear();
                isOperatorClicked = false;
            }

            if (txtBoxDisplay.Text == "0")
            {
                txtBoxDisplay.Text = input; 
            }
            else
            {
                txtBoxDisplay.Text += input; 
            }

            isNumberClicked = true;  
        }

        private void ProcessOperatorInput(string input)
        {
            if (txtBoxDisplay.Text == "0.")
            {
                txtBoxDisplay.Text = "0";
            }

            if (string.IsNullOrEmpty(txtBoxDisplay.Text))
            {
                return; 
            }

            if (isEqualsClicked)
            {
                txtBoxDisplayRecent.Text = txtBoxDisplay.Text + " " + input + " ";
                isEqualsClicked = false;
            }
            else if (isOperatorClicked)
            {
                txtBoxDisplayRecent.Text = txtBoxDisplayRecent.Text.Substring(0, txtBoxDisplayRecent.Text.Length - 2) + input + " ";
            }
            else
            {
                txtBoxDisplayRecent.Text += txtBoxDisplay.Text + " " + input + " ";
            }

            isOperatorClicked = true; 
            isNumberClicked = false;   

            
        }

        private void HandleNumberInput(KeyPressEventArgs e)
        {
            ProcessNumberInput(e.KeyChar.ToString());
            e.Handled = true; 
        }

        private void HandleOperatorInput(KeyPressEventArgs e)
        {
            ProcessOperatorInput(e.KeyChar.ToString());
            e.Handled = true; 
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            ProcessNumberInput(btn.Text); 
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            RJButton btn = sender as RJButton;
            ProcessOperatorInput(btn.Text); 
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

            if (txtBoxDisplay.Text == "0" || isOperatorClicked)
            {
                txtBoxDisplay.Clear(); 
            }

            txtBoxDisplayRecent.Text += "(";

            isOperatorClicked = false;
            isNumberClicked = false; 
        }

        private void HandleRightParenthesis()
        {
            if (txtBoxDisplayRecent.Text.Contains("(") && !txtBoxDisplayRecent.Text.EndsWith("("))
            {
                txtBoxDisplayRecent.Text += txtBoxDisplay.Text + ")"; 
                txtBoxDisplay.Clear(); 
                isOperatorClicked = false; 
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

            if (txtBoxDisplay.Text == "0")
            {
                txtBoxDisplay.Clear(); 
            }

            txtBoxDisplayRecent.Text += "(";

            if (!string.IsNullOrEmpty(txtBoxDisplay.Text))
            {
                txtBoxDisplayRecent.Text = txtBoxDisplayRecent.Text.TrimEnd('(') + txtBoxDisplay.Text + " ("; // Move the text to the right place
                txtBoxDisplay.Clear();  
            }

            isOperatorClicked = false; 
            isNumberClicked = false;   
        }

        private void btnRightParenthesis_Click_1(object sender, EventArgs e)
        {
            txtBoxDisplayRecent.Text += txtBoxDisplay.Text + ")";
            txtBoxDisplay.Clear();  
            isOperatorClicked = false;  
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
                if (string.IsNullOrEmpty(firstOperand))
                {
                    firstOperand = txtBoxDisplay.Text;
                }

                if (!string.IsNullOrEmpty(txtBoxDisplay.Text))
                {
                    txtBoxDisplayRecent.Text += txtBoxDisplay.Text;
                }

                string expression = txtBoxDisplayRecent.Text;
                if (expression.Length > 0)
                {
                    char lastChar = expression[expression.Length - 1];

                    if ("+-*/".Contains(lastChar))
                    {
                        txtBoxDisplayRecent.Text += $"{firstOperand} ";  
                    }
                }

                if (!SolvingExpression.AreParenthesesBalanced(expression))
                {
                    int openCount = expression.Split('(').Length - 1;
                    int closeCount = expression.Split(')').Length - 1;
                    while (openCount > closeCount)
                    {
                        txtBoxDisplayRecent.Text += ")"; 
                        closeCount++;
                    }
                }

                bool hasError;
                bool divisionByZero = SolvingExpression.SolveExpression(txtBoxDisplay, txtBoxDisplayRecent, out hasError);

                if (txtBoxHistoryList.Text == "There's no history yet.")
                {
                    txtBoxHistoryList.Clear();
                }

                if (!hasError)
                {
                    txtBoxHistoryList.AppendText(txtBoxDisplayRecent.Text + Environment.NewLine);
                    txtBoxHistoryList.AppendText(txtBoxDisplay.Text + Environment.NewLine + Environment.NewLine);  // Result on the next line
                }

                isEqualsClicked = true; 
                isOperatorClicked = false;  
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtBoxDisplay.Text = "0"; 
            txtBoxDisplayRecent.Clear();
            isOperatorClicked = false;
            isEqualsClicked = false;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxHistoryList.Text))
            {
                txtBoxHistoryList.Text = "There's no history yet.";
            }

            if (pnlFooter.Height == 5)
            {
                pnlFooter.Height = 315;
                pnlFooter.Top -= (315 - 5); 
            }
            else
            {
                pnlFooter.Top += (315 - 5); 
                pnlFooter.Height = 5;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}