namespace Week2_HarrisonChristian_Project
{
    public partial class frmSummer2023 : Form
    {
        public frmSummer2023()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // NAME: Christian Harrison | Class Info: ITD 2343 Obj-Orient Prg Using C# | Due Date: 9/19/2023
        private void button3_Click(object sender, EventArgs e)
        {
            // This is to clear the textbox
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This is to clear the text on the label
            label2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string f = textBox1.Text;

            // This copies the text over from the textbox over to the Label
            label2.Text = f;
            label2.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // This closes the Program.
            this.Close();
        }
    }
}