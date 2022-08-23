namespace ejercicio1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                convertTemp(Convert.ToDouble(txtInput.Text));
            }
            catch
            {
                txtOutput.Text = "Valor incorrecto";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            countSpaces(txtInput.Text);
        }
        private void countSpaces(String text)
        {
            int spaces = text.Count(Char.IsWhiteSpace);
            txtOutput.Text = "La frase contiene " + spaces + " espacios";
        }
        private void convertTemp(double temp)
        {
            double temperature = temp * 1.8 + 32;
            txtOutput.Text = temperature.ToString("#.##");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
