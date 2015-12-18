namespace calculator2
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;


        public Form1()
        {
            InitializeComponent();
        }



        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")

            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }

            else
                result.Text = result.Text + b.Text;
        }
              

        private void button10_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(result.Text);
            operation_pressed = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            switch (operation) {
                case "+":
                    result.Text=(value+ double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;


            }

            //endswitch
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
