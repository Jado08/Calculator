using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFunctions());
        }

        public static void SolveExpression(TextBox txtBoxDisplay, TextBox txtBoxDisplayRecent)
        {
            try
            {
                string expression = txtBoxDisplayRecent.Text;

                // Check if parentheses are balanced
                if (!AreParenthesesBalanced(expression))
                {
                    MessageBox.Show("The expression has unmatched parentheses.");
                    return;
                }

                // Check for division by zero
                if (expression.Contains("/ 0"))
                {
                    txtBoxDisplay.Text = "Cannot divide by zero";
                    return;  // Stop further execution
                }

                // Evaluate the expression using DataTable
                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");

                string resultStr;

                if (result is double doubleResult)
                {
                    // Check if the result is a whole number
                    if (doubleResult == Math.Floor(doubleResult))
                    {
                        // If the result is a whole number, cast to an integer and show it without decimals
                        resultStr = ((int)doubleResult).ToString();
                    }
                    else
                    {
                        // Otherwise, show the result with up to two decimal places
                        resultStr = doubleResult.ToString("0.##");
                    }
                }
                else
                {
                    resultStr = result.ToString(); // Fallback if the result is not a double
                }

                txtBoxDisplay.Text = resultStr; // Show the formatted result in txtBoxDisplay
                txtBoxDisplayRecent.Text += " ="; // Append "=" in txtBoxDisplayRecent
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid expression: " + ex.Message);
                txtBoxDisplay.Clear();
                txtBoxDisplayRecent.Clear();
            }
        }


        public static bool AreParenthesesBalanced(string expression)
        {
            int balance = 0;

            foreach (char c in expression)
            {
                if (c == '(') balance++;
                if (c == ')') balance--;

                if (balance < 0) return false;  // Unmatched closing parenthesis
            }

            return balance == 0;  // Return true if balanced
        }

    }
}
