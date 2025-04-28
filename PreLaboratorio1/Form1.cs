namespace PreLaboratorio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "12345")
            {
                Form2 v1 = new Form2();
                v1.Show();
            }
            else
            {
                MessageBox.Show("INGRESE BIEN LA CONTRASEÑA");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 v2 = new Form3();
            v2.Show();
        }
    }
}
