namespace Calculator_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num1_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //float num1 = Convert.ToInt16(num1_textBox.Text);
            float num1 = float.Parse(num1_textBox.Text);
            float num2 = float.Parse(num2_textBox.Text);
            switch (char.Parse(operation_textbox.Text))
            {
                case '+':
                    result_label.Text = $"{num1} + {num2} = {num1 + num2}";
                    result_label.Visible = true;
                    break;
                case '-':
                    result_label.Text = $"{num1} - {num2} = {num1 - num2}";
                    result_label.Visible = true;
                    break;
                case '*':
                    result_label.Text = $"{num1} * {num2} = {num1 * num2}";
                    result_label.Visible = true;
                    break;
                case '/':
                    result_label.Text = $"{num1} / {num2} = {num1 / num2}";
                    result_label.Visible = true;
                    break;
                case '%':
                    result_label.Text = $"{num1} % {num2} = {num1 % num2}";
                    result_label.Visible = true;
                    break;
                default:
                    result_label.ForeColor = Color.Red;
                    result_label.Text = "Invalid Operation";
                    result_label.Visible = true;
                    break;
                    

            }

        }
    }
}