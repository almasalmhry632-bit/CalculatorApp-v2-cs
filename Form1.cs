namespace CalculatorApp_v2
{
    public partial class Calculator : Form
    {
        string operation = "";
        double firstnumber = 0;
        double secondnumber = 0;
        double result = 0;
        bool operationcompleted = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (operationcompleted == true)
            {
               textBox1.Clear();
                operationcompleted = false;
            }
            Button button = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            firstnumber = double.Parse(textBox1.Text);
            Button button = (Button)sender;
            textBox1.Text += button.Text;
            operation = button.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string expression = textBox1.Text;
            int index = expression.IndexOf(operation);
            string firstPart = expression.Substring(0, index);
            string secondPart = expression.Substring(index + operation.Length);

            firstnumber = double.Parse(firstPart);
            secondnumber = double.Parse(secondPart);

            switch (operation)
            {
                case "+":
                    result = (firstnumber + secondnumber);
                    break;
                case "-":
                    result = (firstnumber - secondnumber);
                    break;
                case "*":
                    result = (firstnumber * secondnumber);
                    break;
                case "/":
                    result = (firstnumber / secondnumber);
                    break;
                case "%":
                    result = (firstnumber % secondnumber);
                    break;
            }
            textBox1.Text = result.ToString();
            operationcompleted= true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
           if(textBox1.Text.Length > 0)
            {
                textBox1.Text= textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }      
        
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }
    }
}
