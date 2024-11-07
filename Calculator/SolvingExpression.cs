using System;
using System.Data;
using System.Linq;
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
        public static bool SolveExpression(Label lblDisplay, TextBox txtBoxDisplayRecent, out bool hasError, out string errorMessage)
        {
            hasError = false;
            errorMessage = string.Empty;
            string expression = txtBoxDisplayRecent.Text;
            if (!AreParenthesesBalanced(expression))
            {
                int openCount = expression.Count(c => c == '(');
                int closeCount = expression.Count(c => c == ')');
                expression += new string(')', openCount - closeCount);
            }

            if (IsDivisionByZero(expression))
            {
                errorMessage = "Cannot divide by zero";
                txtBoxDisplayRecent.Text += " =";
                hasError = true;
                return true;
            }

            try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");

                if (decimal.TryParse(result.ToString(), out decimal decimalResult))
                {
                    if (decimalResult > decimal.MaxValue || decimalResult < decimal.MinValue)
                    {
                        errorMessage = "Too large to compute";
                        txtBoxDisplayRecent.Text += " =";
                        hasError = true;
                        return false;
                    }

                    lblDisplay.Text = decimalResult % 1 == 0 ? ((int)decimalResult).ToString() : decimalResult.ToString();
                }
                else
                {
                    lblDisplay.Text = result.ToString();
                }

                txtBoxDisplayRecent.Text += " =";
                return false;
            }
            catch
            {
                errorMessage = "Too large to compute";
                txtBoxDisplayRecent.Text += " =";
                hasError = true;
                return false;
            }
        }
        private static bool IsDivisionByZero(string expression)
        {
            // Matches division by exactly 0 or 0.0, 0.00, etc., but not values like 0.1, 0.15, etc.
            return System.Text.RegularExpressions.Regex.IsMatch(expression, @"\/\s*0(\.0+)?(?=\s|$)");
        }

        public static bool AreParenthesesBalanced(string expression)
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
    }
}