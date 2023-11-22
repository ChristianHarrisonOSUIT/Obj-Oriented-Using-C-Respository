namespace _4To7Lab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void convertFromDecimal_Click(object sender, EventArgs e)

        {

            try

            {

                int inputNumber = Convert.ToInt32(textBox1.Text);

                int outputNumber = 0;

                string outputBase = "0123456789ABCDEF";


                if (inputNumber == 0)

                {

                    label2.Text = "0";

                    return;

                }


                while (inputNumber > 0)

                {

                    int remainder = inputNumber % 16;

                    outputNumber = outputNumber * 16 + remainder;

                    inputNumber /= 16;

                }


                label2.Text = Reverse(outputBase.Substring(0, 16)).ToString();

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error: " + ex.Message);

            }

        }


        private void convertFromOctal_Click(object sender, EventArgs e)

        {

            try

            {

                int inputNumber = Convert.ToInt32(textBox1.Text, 8);

                int outputNumber = 0;

                string outputBase = "0123456789ABCDEF";


                while (inputNumber > 0)

                {

                    int remainder = inputNumber % 16;

                    outputNumber = outputNumber * 16 + remainder;

                    inputNumber /= 16;

                }


                label2.Text = Reverse(outputBase.Substring(0, 16)).ToString();

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error: " + ex.Message);

            }

        }


        private void convertFromBinary_Click(object sender, EventArgs e)

        {

            try

            {

                int inputNumber = Convert.ToInt32(textBox1.Text, 2);

                int outputNumber = 0;

                string outputBase = "0123456789ABCDEF";


                while (inputNumber > 0)

                {

                    int remainder = inputNumber % 16;

                    outputNumber = outputNumber * 16 + remainder;

                    inputNumber /= 16;

                }


                label2.Text = Reverse(outputBase.Substring(0, 16)).ToString();

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error: " + ex.Message);

            }

        }


        private void processButton_Click(object sender, EventArgs e)

        {

            try

            {

                int inputNumber = Convert.ToInt32(textBox1.Text);

                int outputNumber = 0;

                int inputBase = Convert.ToInt32(textBox1.Text);

                string outputBase = "0123456789ABCDEF";


                while (inputNumber > 0)

                {

                    int remainder = inputNumber % 16;

                    outputNumber = outputNumber * 16 + remainder;

                    inputNumber /= 16;

                }


                label2.Text = Reverse(outputBase.Substring(0, 16)).ToString();

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error: " + ex.Message);

            }

        }


        private string Reverse(string s)

        {

            char[] charArray = s.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);

        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)

        {

            if (e.KeyCode == Keys.Escape)

            {

                this.Close();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}