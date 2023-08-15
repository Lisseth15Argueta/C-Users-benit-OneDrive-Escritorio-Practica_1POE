namespace WinFormsApp1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //evaluar si no es una tecla de control o un caracter
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                //nos permite no permitir el acceso de esas teclas
                e.Handled = true;
                label1.Text = "Solo se permiten numeros";

            }
            else
            {
                label1.Text = "";
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }
        //cambiar automaticamente el color de fondo del label cuando el usuario lo coloca
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }
        //cambiar automaticamente el color de fondo del label cuando el usuario lo saca
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Blue;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //evaluando la condicion
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten caracteres");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string email = textBox3.Text;
            if (!emailValido(email))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool emailValido(string email)
        {
            //para capturar los errores 
            try
            {
                //para validar la estructura del gmail
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}