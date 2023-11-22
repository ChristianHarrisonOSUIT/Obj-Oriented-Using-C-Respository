namespace Solution5Harrison
{
    public partial class FrmChoices : Form
    {
        public FrmChoices()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Text = "This number is equal to ";
        }
    }
}