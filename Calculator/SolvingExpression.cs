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
        public static bool SolveExpression(TextBox txtBoxDisplay, TextBox txtBoxDisplayRecent, out bool hasError)
        {
            hasError = false;
            try
            {
                string expression = txtBoxDisplayRecent.Text;

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

                if (IsDivisionByZero(expression))
                {
                    txtBoxDisplay.Text = "Cannot divide by zero";  
                    txtBoxDisplayRecent.Text += " =";  
                    hasError = true;  
                    return true;  
                }

                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");  

                if (result.ToString() == "∞" || result.ToString() == "-∞")
                {
                    txtBoxDisplay.Text = "Cannot divide by zero";
                    txtBoxDisplayRecent.Text += " =";
                    return true;
                }

                string resultStr;

                if (decimal.TryParse(result.ToString(), out decimal decimalResult))
                {
                    if (decimalResult % 1 == 0) 
                    {
                        resultStr = ((int)decimalResult).ToString();
                    }
                    else
                    {
                        resultStr = decimalResult.ToString(); 
                    }
                }
                else
                {
                    resultStr = result.ToString(); 
                }

                txtBoxDisplay.Text = resultStr; 
                txtBoxDisplayRecent.Text += " =";  

                return false; 
            }
            catch (Exception)
            {
                txtBoxDisplay.Text = "Exceeded maximum number limit";
                txtBoxDisplayRecent.Text += " ="; 
                hasError = true;  
                return false; 
            }

        }

        private static bool IsDivisionByZero(string expression)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(expression, @"\/\s*(0(\.0*)?)");
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