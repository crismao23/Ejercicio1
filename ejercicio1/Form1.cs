namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validateUser(txtUser.Text, txtPassword.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void validateUser(String user, String password)
        {
            String us = "pepe";
            String pass = "1234";
            if (user == us && password == pass)
            {
                formTwo();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void formTwo()
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}