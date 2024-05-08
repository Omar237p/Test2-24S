namespace Test2_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text) };


            Array.Sort(numbers);
            textBox1.Text = numbers[0].ToString();
            textBox2.Text = numbers[1].ToString();
            textBox3.Text = numbers[2].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] numbers = { int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text) };

           
            Array.Sort(numbers);
            Array.Reverse(numbers);

         
            textBox1.Text = numbers[0].ToString();
            textBox2.Text = numbers[1].ToString();
            textBox3.Text = numbers[2].ToString();
        }
    }
}
