namespace MIni_Calculadora
{
    public partial class btnLimpar : Form
    {
        public btnLimpar()
        {
            InitializeComponent();
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            if ((txtNumero1.Text != string.Empty) && (txtNumero2.Text != string.Empty))
            {
                btnDividir.Enabled = true;
                btnSomar.Enabled = true;
                btnSubtrair.Enabled = true;
                btnMultiplica.Enabled = true;

            }
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            if ((txtNumero1.Text != string.Empty) && (txtNumero2.Text != string.Empty))
            {
                btnDividir.Enabled = true;
                btnSomar.Enabled = true;
                btnSubtrair.Enabled = true;
                btnMultiplica.Enabled = true;

            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            
            float num1, num2, result;
            num1 = float.Parse(txtNumero1.Text);
            num2 = float.Parse(txtNumero2.Text);
            result = num1 + num2;
            txtResultado.Text = result.ToString();

           
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txtNumero1.Text);
            num2 = float.Parse(txtNumero2.Text);
            result = num1 - num2;
            txtResultado.Text = result.ToString();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txtNumero1.Text);
            num2 = float.Parse(txtNumero2.Text);
            result = num1 * num2;
            txtResultado.Text = result.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            float num1, num2, result;
            num1 = float.Parse(txtNumero1.Text);
            num2 = float.Parse(txtNumero2.Text);
            result = num1 / num2;
            txtResultado.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd'-'MM'-'yyyy");
            dateTimePicker1.Value = DateTime.Now; lblData.Text = DateTime.Now.ToString("dd'-'MM'-'yyyy");
            dateTimePicker1.Value = DateTime.Now;
        }

        /*private void btnLimpar_Load(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Text = "";
        }*/
    }
}