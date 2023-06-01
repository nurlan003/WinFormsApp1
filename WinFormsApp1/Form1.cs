namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 400);
            int randomNumber2 = random.Next(1, 840);
            login.Location = new System.Drawing.Point(randomNumber, randomNumber2);
            int red = random.Next(256);
            int blue = random.Next(256);
            int green = random.Next(256);
            Color randomColor =Color.FromArgb(red, green, blue);
            login.Location =new Point(randomNumber, randomNumber2);
            login.BackColor = randomColor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}