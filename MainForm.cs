namespace LabNumber2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Enable the Modulus operation
            // Display instructions for Modulus in a label
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Enable the Factorial operation
            // Display instructions for Factorial in a label
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Enable the Fibonacci operation
            // Display instructions for Fibonacci in a label
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if the corresponding Show button has been clicked
            // Validate input using the Validation class
            // Perform the selected operation
            // Display the result in the message area
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Clear the message area
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Display a thank you message using MessageBox
            Close();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button8_Click(this, new EventArgs());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        public static class Validation
        {
            public static bool IsValidInteger(string input, int minValue, int maxValue)
            {
                if (int.TryParse(input, out int number))
                {
                    return number >= minValue && number <= maxValue;
                }
                return false;
            }
        }
        public class ModulusOperation
        {
            public static string CalculateModulus(int dividend, int divisor)
            {
                int quotient = 0;
                int remainder = dividend;

                while (remainder >= divisor)
                {
                    remainder -= divisor;
                    quotient++;
                }

                return $"{dividend} divided by {divisor} is {quotient} with a remainder of {remainder}";
            }
        }
        public class FactorialOperation
        {
            public static string CalculateFactorial(int number)
            {
                if (number < 0)
                {
                    return "Factorial cannot be calculated for negative numbers.";
                }

                if (number > 15)
                {
                    return "Factorial calculation is limited to numbers up to 15.";
                }

                int result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }

                return $"The answer to {number}! is {result}";
            }
        }
        public class FibonacciOperation
        {
            public static string CalculateFibonacci(int number)
            {
                if (number < 0)
                {
                    return "Fibonacci terms cannot be calculated for negative numbers.";
                }

                if (number > 45)
                {
                    return "Fibonacci calculation is limited to terms up to 45.";
                }

                if (number == 0)
                {
                    return "Fibonacci(0) = 0";
                }
                else if (number == 1)
                {
                    return "Fibonacci(1) = 1";
                }

                int a = 0;
                int b = 1;
                int result = 0;

                for (int i = 2; i <= number; i++)
                {
                    result = a + b;
                    a = b;
                    b = result;
                }

                return $"Fibonacci({number}) = Fibonacci({number - 1}) + Fibonacci({number - 2}) = {result}";
            }
        }
    }
}