namespace calculadora2
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private operacao OperacaoSelecionada { get; set; }
        private enum operacao
        {
            Somar,
            Subtrair,
            Dividir,
            Multiplicar
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void bnt8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void somar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.Somar;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            mostrarOp.Text = "+";
        }

        private void subtrair_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.Subtrair;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            mostrarOp.Text = "-";
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.Dividir;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            mostrarOp.Text = "%";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.Multiplicar;
            Valor = Convert.ToDecimal (txtResultado.Text);
            txtResultado.Text = "";
            mostrarOp.Text = "X";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case operacao.Somar:
                    {
                        Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                        break;
                    }
                
                case operacao.Subtrair:
                    {
                        Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                        break;
                    }
                case operacao.Dividir:
                    {
                        Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                        break;
                    }
                case operacao.Multiplicar:
                    {
                        Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                        break;
                    }

            }
            txtResultado.Text = Convert.ToString(Resultado);
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            mostrarOp.Text = "";
        }

        private void mostrarOp_Click(object sender, EventArgs e)
        {

        }
    }
}