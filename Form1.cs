namespace FormTeletypeLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "w";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ".";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void One_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void q_Click(object sender, EventArgs e)
        {
            textBox1.Text = "q";
        }

        private void e_Click(object sender, EventArgs e)
        {
            textBox1.Text = "e";
        }

        private void r_Click(object sender, EventArgs e)
        {
            textBox1.Text = "r";
        }

        private void t_Click(object sender, EventArgs e)
        {
            textBox1.Text = "t";
        }

        private void y_Click(object sender, EventArgs e)
        {
            textBox1.Text = "y";
        }

        private void u_Click(object sender, EventArgs e)
        {
            textBox1.Text = "u";
        }

        private void i_Click(object sender, EventArgs e)
        {
            textBox1.Text = "i";
        }

        private void o_Click(object sender, EventArgs e)
        {
            textBox1.Text = "o";
        }

        private void p_Click(object sender, EventArgs e)
        {
            textBox1.Text = "p";
        }

        private void a_Click(object sender, EventArgs e)
        {
            textBox1.Text = "a";
        }

        private void s_Click(object sender, EventArgs e)
        {
            textBox1.Text = "s";
        }

        private void d_Click(object sender, EventArgs e)
        {
            textBox1.Text = "d";
        }

        private void f_Click(object sender, EventArgs e)
        {
            textBox1.Text = "f";
        }

        private void g_Click(object sender, EventArgs e)
        {
            textBox1.Text = "g";
        }

        private void h_Click(object sender, EventArgs e)
        {
            textBox1.Text = "h";
        }

        private void j_Click(object sender, EventArgs e)
        {
            textBox1.Text = "j";
        }

        private void k_Click(object sender, EventArgs e)
        {
            textBox1.Text = "k";
        }

        private void l_Click(object sender, EventArgs e)
        {
            textBox1.Text = "l";
        }

        private void z_Click(object sender, EventArgs e)
        {
            textBox1.Text = "z";
        }

        private void x_Click(object sender, EventArgs e)
        {
            textBox1.Text = "x";
        }

        private void c_Click(object sender, EventArgs e)
        {
            textBox1.Text = "c";
        }

        private void v_Click(object sender, EventArgs e)
        {
            textBox1.Text = "v";
        }

        private void b_Click(object sender, EventArgs e)
        {
            textBox1.Text = "b";
        }

        private void n_Click(object sender, EventArgs e)
        {
            textBox1.Text = "n";
        }

        private void m_Click(object sender, EventArgs e)
        {
            textBox1.Text = "m";
        }

        private void Space_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Send_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}