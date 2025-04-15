namespace _Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        float num1;
        float num2;
        string option;
        float result;

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button9.Text;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + button16.Text;
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            option = "+";
            num1 = float.Parse(display.Text);

            display.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = float.Parse(display.Text);

            display.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = float.Parse(display.Text);

            display.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = float.Parse(display.Text);

            display.Clear();
        }

        private void button14_Click(object sender, EventArgs e)

        {
            num2 = float.Parse(display.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            display.Text = result + "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            display.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}

