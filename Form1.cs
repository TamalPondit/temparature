namespace Temperature
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            double number, result;
            number = Convert.ToInt32(textBox1.Text);
            result = Math.Round((number - 32) * 5 / 9, 2);
            label5.Text = result.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToInt32(textBox2.Text);
            result = Math.Round((number * 1.8) + 32, 2);
            label6.Text = result.ToString();
        }
    }
}