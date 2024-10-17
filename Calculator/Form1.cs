using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool isOperatorClicked = false;
        private bool isEqualsClicked = false;
        private bool isNumberClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLeftParenthesis_Click(object sender, EventArgs e)
        {
            if (isEqualsClicked)
            {
                txtBoxDisplay.Clear();
                txtBoxDisplayRecent.Clear();
                isEqualsClicked = false;
            }

            txtBoxDisplayRecent.Text += "(";
            isOperatorClicked = false;
        }

        private void btnRightParenthesis_Click(object sender, EventArgs e)
        {
            txtBoxDisplayRecent.Text += txtBoxDisplay.Text + ")";
            txtBoxDisplay.Clear();
            isOperatorClicked = false;
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

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

            txtBoxDisplay.Text += btn.Text;
            isNumberClicked = true;
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (!isNumberClicked) return;

            if (isEqualsClicked)
            {
                isEqualsClicked = false;
            }

            if (!isOperatorClicked)
            {
                txtBoxDisplayRecent.Text += txtBoxDisplay.Text + " " + btn.Text + " ";
                isOperatorClicked = true;
                isNumberClicked = false;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (!isEqualsClicked)
            {
                txtBoxDisplayRecent.Text += txtBoxDisplay.Text;
                SolveExpression();
                isEqualsClicked = true;
                isOperatorClicked = false;
                isNumberClicked = false;
            }
        }

        private void SolveExpression()
        {
            try
            {
                string expression = txtBoxDisplayRecent.Text;

                if (!AreParenthesesBalanced(expression))
                {
                    MessageBox.Show("The expression has unmatched parentheses.");
                    return;
                }

                if (expression.Contains("/ 0"))
                {
                    txtBoxDisplay.Text = "Cannot divide by zero";
                    return;
                }

                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");

                txtBoxDisplay.Text = result.ToString();
                txtBoxDisplayRecent.Text += " =";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid expression: " + ex.Message);
                txtBoxDisplay.Clear();
                txtBoxDisplayRecent.Clear();
            }
        }

        private bool AreParenthesesBalanced(string expression)
        {
            int balance = 0;

            foreach (char c in expression)
            {
                if (c == '(') balance++;
                if (c == ')') balance--;

                if (balance < 0) return false;
            }

            return balance == 0;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtBoxDisplay.Clear();
            txtBoxDisplayRecent.Clear();
            isOperatorClicked = false;
            isEqualsClicked = false;
            isNumberClicked = false;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtBoxDisplay.Text.Length > 0)
            {
                txtBoxDisplay.Text = txtBoxDisplay.Text.Substring(0, txtBoxDisplay.Text.Length - 1);
            }
        }
    }
}
