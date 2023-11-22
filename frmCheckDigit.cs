namespace PaymentProcessor
{
    public partial class frmCheckDigit : Form
    {
        public class paymentProcess
        {
            private TextBox textBox1;
            private TextBox textBox2;
            private TextBox textBox3;
            private RichTextBox richTextBox1;

            public paymentProcess(TextBox accountEntryTextBox, TextBox confirmationTextBox, TextBox paymentTextBox, RichTextBox messageArea)
            {
                this.textBox1 = accountEntryTextBox;
                this.textBox2 = confirmationTextBox;
                this.textBox3 = paymentTextBox;
                this.richTextBox1 = messageArea;
            }

            public void ResetForm()
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                richTextBox1.Clear();
                textBox1.Focus();
            }

            public void ProcessPayment()
            {
                string accountEntry = textBox1.Text;
                string confirmation = textBox2.Text;
                string paymentText = textBox3.Text;

                if (string.IsNullOrWhiteSpace(accountEntry) || string.IsNullOrWhiteSpace(confirmation) || string.IsNullOrWhiteSpace(paymentText))
                {
                    DisplayError("All textboxes must be filled.");
                    return;
                }

                if (!IsNumeric(paymentText))
                {
                    DisplayError("Payment amount must be numeric.");
                    return;
                }

                if (accountEntry != confirmation)
                {
                    DisplayError("Account entry and confirmation do not match.");
                    return;
                }

                // Process the payment
                decimal paymentAmount = decimal.Parse(paymentText);
                DateTime currentDate = DateTime.Now;

                string formattedPayment = FormatPayment(paymentAmount);
                string message = $"A payment of {formattedPayment} was applied to account {accountEntry} on {currentDate.ToString("MMMM dd")}.";

                DisplayMessage(message);
            }

            private bool IsNumeric(string input)
            {
                return decimal.TryParse(input, out _);
            }

            private string FormatPayment(decimal payment)
            {
                return payment.ToString("C"); // Formats the payment as currency
            }

            private void DisplayError(string errorMessage)
            {
                richTextBox1.Text = $"Error: {errorMessage}";
            }

            private void DisplayMessage(string message)
            {
                richTextBox1.Text = message;
            }
        }
        public frmCheckDigit(paymentProcess paymentProcess)
        {
            InitializeComponent();
            paymentProcess = new paymentProcess(textBox1, textBox2, textBox3, richTextBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paymentProcess paymentProcessor = new paymentProcess(textBox1, textBox2, textBox3, richTextBox1);
            paymentProcessor.ProcessPayment();
        }
    }
}