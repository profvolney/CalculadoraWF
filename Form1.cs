using CalculadoraWF.Models;

namespace CalculadoraWF
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            lblResultado.Text = "";
            lblOperacao.Text = "";
        }

        Calcular calcular = new Calcular();

        private void Calculadora_Load(object sender, EventArgs e)
        {
            
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            calcular.v2 = Convert.ToDouble(lblResultado.Text);
            lblResultado.Text = "";

            calcular.Calculadora();
            lblOperacao.Text += calcular.v2;
            lblResultado.Text = calcular.resultado.ToString();
            lblOperacao.Text = "";
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lblOperacao.Text = "";
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            calcular.v1 = Convert.ToDouble(lblResultado.Text);
            calcular.operacao = '+';

            lblOperacao.Text = lblResultado.Text + calcular.operacao;
            lblResultado.Text = "";
            lblOperacao.Text = "";
        }
        private void btnSubtracao_Click(object? sender, EventArgs e)
        {
            calcular.v2 = Convert.ToDouble(lblResultado.Text);
            calcular.operacao = '-';

            lblOperacao.Text = lblResultado.Text + calcular.operacao;
            lblResultado.Text = "";
            lblOperacao.Text = "";
        }
        private void btnUm_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "1";
            lblOperacao.Text = "";
        }
        private void btnDois_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "2";
            lblOperacao.Text = "";
        }
        private void btnTres_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "3";
            lblOperacao.Text = "";
        }
        private void btnQuatro_Click_1(object sender, EventArgs e)
        {
            lblResultado.Text += "4";
            lblOperacao.Text = "";
        }
        private void btnCinco_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "5";
            lblOperacao.Text = "";
        }
        private void btnSeis_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "6";
            lblOperacao.Text = "";
        }
        private void btnSete_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "7";
            lblOperacao.Text = "";
        }
        private void btnOito_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "8";
            lblOperacao.Text = "";
        }
        private void btnNove_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "9";
            lblOperacao.Text = "";
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "0";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            calcular.v1 = Convert.ToDouble(lblResultado.Text);
            calcular.operacao = '*';

            lblOperacao.Text = lblResultado.Text + calcular.operacao;
            lblResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            calcular.v1 = Convert.ToDouble(lblResultado.Text);
            calcular.operacao = '/';

            lblOperacao.Text = lblResultado.Text + calcular.operacao;
            lblResultado.Text = "";
            lblOperacao.Text = "";
        }
    }
}
