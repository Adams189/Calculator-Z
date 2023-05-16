namespace Calculator_Y
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operator_pressed = false;
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

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text= (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;

            } 
            value = Double.Parse(result.Text);
            operation = "";


        }

        private void button_Click(object sender, EventArgs e)
        {
            if((result.Text == "0")||(operator_pressed))
                result.Clear();
            operator_pressed = false;

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation += b.Text;
            value = Double.Parse(result.Text);
            operator_pressed = true;
            equation.Text = value + ""+ operation;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String NewContent = result.Text.Remove(result.Text.Length - 1, 1);
            result.Text = NewContent;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntRoot_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}