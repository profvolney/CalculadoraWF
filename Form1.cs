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
        
        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            string operador;
            string resultado;
            string calculo;

            operador = btnSoma.Text;

            try
            {
                switch (operador)
                {
                    case "+":
                        Calcular calcular = new Calcular();
                        //lblResultado.Text = calcular.Soma(num1, num2).ToString();

                        //lblResultado.Text = "";
                        //resultado = Convert.ToDecimal(lblResultado.Text) + calculo;
                        //lblResultado.Text = resultado.ToString();
                        break;
                }




            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            lblOperacao.Text = "";
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {

        }
        private void btnSubtracao_Click(object? sender, EventArgs e)
        {
            lblResultado.Text = "";
            string operador, valorDigitado;

            operador = btnSubtracao.Text;
            operador = btnSoma.Text;

            switch (operador)
            {
                case "-":

                    //lblResultado.Text = resultado.ToString();
                    break;
            }
        }
        
        
        private void btnUm_Click(object sender, EventArgs e)
        {   
            string num1 = "1";

            if (btnUm.Text == num1)
                num1 = btnUm.Text;

            lblResultado.Text = lblResultado.Text += num1;            
            lblOperacao.Text = lblOperacao.Text += num1;  
        }
        private void btnDois_Click(object sender, EventArgs e)
        {
           string num2 = "2";

            if (btnDois.Text == num2)
                num2 = btnDois.Text;

            lblResultado.Text = lblResultado.Text += num2;
            lblOperacao.Text = lblOperacao.Text += num2;
        }
        private void btnTres_Click(object sender, EventArgs e)
        {
            string num3 = "3";

            if (btnTres.Text == num3)
                num3 = btnTres.Text;

            lblResultado.Text = lblResultado.Text += num3;
            lblOperacao.Text = lblOperacao.Text += num3;
        }
        private void btnQuatro_Click_1(object sender, EventArgs e)
        {
            string num4 = "4";

            if (btnQuatro.Text == num4)
                num4 = btnQuatro.Text;

            lblResultado.Text = lblResultado.Text += num4;
            lblOperacao.Text = lblOperacao.Text += num4;            
        }
        private void btnCinco_Click(object sender, EventArgs e)
        {
            string num5 = "5";

            if (btnCinco.Text == num5)
                num5 = btnCinco.Text;

            lblResultado.Text = lblResultado.Text += num5;
            lblOperacao.Text = lblOperacao.Text += num5;
        }
        private void btnSeis_Click(object sender, EventArgs e)
        {
            string num6 = "6";

            if (btnSeis.Text == num6)
                num6 = btnSeis.Text;

            lblResultado.Text = lblResultado.Text += num6;
            lblOperacao.Text = lblOperacao.Text += num6;
        }
        private void btnSete_Click(object sender, EventArgs e)
        {
            string num7 = "7";

            if (btnSete.Text == num7)
                num7 = btnSete.Text;

            lblResultado.Text = lblResultado.Text += num7;
            lblOperacao.Text = lblOperacao.Text += num7;
        }
        private void btnOito_Click(object sender, EventArgs e)
        {
            string num8 = "8";

            if (btnOito.Text == num8)
                num8 = btnOito.Text;

            lblResultado.Text = lblResultado.Text += num8;
            lblOperacao.Text = lblOperacao.Text += num8;
        }
        private void btnNove_Click(object sender, EventArgs e)
        {            
            string num9 = "9";

            if (btnNove.Text == num9)
                num9 = btnNove.Text;

            lblResultado.Text = lblResultado.Text += num9;
            lblOperacao.Text = lblOperacao.Text += num9;
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            string num0 = "0";

            if (btnZero.Text == num0)
                num0 = btnZero.Text;

            lblResultado.Text = lblResultado.Text += num0;
            lblOperacao.Text = lblOperacao.Text += num0;
        }
    }
}
