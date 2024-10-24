using System;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    internal static class SolvingExpression
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
        public static bool SolveExpression(TextBox txtBoxDisplay, TextBox txtBoxDisplayRecent)
        {
            try
            {
                string expression = txtBoxDisplayRecent.Text;

                // Auto-close parentheses if unbalanced (if needed)
                if (!AreParenthesesBalanced(expression))
                {
                    int openCount = expression.Split('(').Length - 1;
                    int closeCount = expression.Split(')').Length - 1;
                    while (openCount > closeCount)
                    {
                        expression += ")";
                        closeCount++;
                    }
                }

                // Check for division by zero or division by "zero-like" values such as 0.00, 0.000, etc.
                if (IsDivisionByZero(expression))
                {
                    txtBoxDisplay.Text = "Cannot divide by zero";  // Show the error message in the display
                    txtBoxDisplayRecent.Text += " =";  // Append '=' to make the expression complete
                    return true;  // Return true to indicate division by zero occurred
                }

                // Evaluate the expression using DataTable
                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");  // Perform the calculation

                // Check if the result is infinity, which indicates division by zero
                if (result.ToString() == "∞" || result.ToString() == "-∞")
                {
                    txtBoxDisplay.Text = "Cannot divide by zero";
                    txtBoxDisplayRecent.Text += " =";
                    return true;
                }

                string resultStr;

                // Convert result to string and parse to decimal
                if (decimal.TryParse(result.ToString(), out decimal decimalResult))
                {
                    // Check if the result is a whole number
                    if (decimalResult % 1 == 0) // If it's a whole number, remove decimal part
                    {
                        resultStr = ((int)decimalResult).ToString(); // Convert to integer string
                    }
                    else
                    {
                        // Keep the original decimal part without unnecessary trailing zeros
                        resultStr = decimalResult.ToString(); // Show full precision without forced formatting
                    }
                }
                else
                {
                    resultStr = result.ToString(); // Fallback if parsing fails
                }

                txtBoxDisplay.Text = resultStr;  // Show the result in the display
                txtBoxDisplayRecent.Text += " =";  // Append '=' to the recent display

                return false; // No division by zero occurred
            }
            catch (Exception ex)
            {
                txtBoxDisplay.Text = "Invalid expression: " + ex.Message;
                txtBoxDisplay.Clear();
                txtBoxDisplayRecent.Clear();
                return false; // No division by zero occurred due to exception
            }
        }

        // Helper method to detect division by zero or zero-like values
        private static bool IsDivisionByZero(string expression)
        {
            // Regex to match division by zero, including cases like "10 / 0", "10 / 0.0", "10 / 0.00", etc.
            return System.Text.RegularExpressions.Regex.IsMatch(expression, @"\/\s*(0(\.0*)?)");
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