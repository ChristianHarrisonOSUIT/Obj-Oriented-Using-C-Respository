namespace Week10Application
{
    public partial class frmRadioStar : Form
    {
        public frmRadioStar()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "Information Here";
            checkBox1.Checked = true;
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Display error for divide by zero
            label3.Text = "Error: Cannot divide by zero.";
            return;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }

}