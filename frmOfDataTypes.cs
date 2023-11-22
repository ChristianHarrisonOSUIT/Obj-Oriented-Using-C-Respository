namespace Module4Project
{
    public partial class frmOfDataTypes : Form
    {
        public frmOfDataTypes()
        {
            InitializeComponent();
        }

        private void frmOfDataTypes_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Byte b = 100;
            b = (Byte)(b + 200);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            short x = 5;
            short y = 5 - 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            short x = 5;
            short y = 5 / 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            short x = 5;
            short y = 5 % 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            short x = 5;
            short y = 5 % 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            short x = 5;
            short y = 5 / 10;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            short x = 5;
            short y = 5 * 10;
        }
    }
}