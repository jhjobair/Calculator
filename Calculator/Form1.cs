namespace Calculator
{
    public partial class Form1 : Form
    {
        int number1;
        int number2;
        float Total;
        string opt;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "0";

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "2";

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "3";

        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "4";

        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "5";

        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "6";

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "7";

        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "8";

        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "9";

        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtResult.Clear();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            opt = "+";

            number1 = int.Parse(TxtResult.Text);
            TxtResult.Clear();


        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            number2 = int.Parse(TxtResult.Text);
            if (opt == "+")
            {
                Total = number1 + number2;
            }
            if (opt == "-")
            {
                Total = number1 - number2;
            }
            if (opt == "÷")
            {
                Total = number1 / number2;
            }
            if (opt == "x")
            {
                Total = number1 * number2;
            }
            TxtResult.Text = Total.ToString();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            opt = "-";

            number1 = int.Parse(TxtResult.Text);
            TxtResult.Clear();
        }

        private void BtnDivition_Click(object sender, EventArgs e)
        {
            opt = "÷";
            number1 = int.Parse(TxtResult.Text);
            TxtResult.Clear();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            opt = "x";
            number1 = int.Parse(TxtResult.Text);
            TxtResult.Clear();
        }
    }
}