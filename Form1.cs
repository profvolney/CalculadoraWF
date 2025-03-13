using CalculadoraWF.Models;

namespace CalculadoraWF
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            //btnSoma.Click += new EventHandler(btnSoma_Click);
            //btnSubtracao.Click += new EventHandler(btnSubtracao_Click);
        }

        private void btnSubtracao_Click(object? sender, EventArgs e)
        {
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

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(btnUm.Text);
            int num2 = Convert.ToInt32(btnDois.Text); ;
            int num4 = Convert.ToInt32(btnTres.Text);
            int num5 = Convert.ToInt32(btnQuatro.Text);
            int num6 = Convert.ToInt32(btnCinco.Text);
            int num7 = Convert.ToInt32(btnTres.Text);
            int num8 = Convert.ToInt32(btnTres.Text);
            int num9 = Convert.ToInt32(btnTres.Text);
            int num0 = Convert.ToInt32(btnTres.Text);

            try
            {
                Calcular calcular = new Calcular();
                lblResultado.Text = calcular.Soma(num1, num2).ToString();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

           

        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            string operador;
            string resultado;
            
            operador = btnSoma.Text;


            switch (operador)
            {
                case "+":
                    resultado = btnUm.Text + btnDois.Text + btnTres.Text;
                    lblResultado.Text = resultado.ToString();
                    break;
            }
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            string num1, valorDigitado;

            num1 = "1";
            if (btnUm.Text == "1")
                num1 = btnUm.Text;
            lblResultado.Text = num1.ToString();
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            string num2;
            num2 = "2";
            if (btnDois.Text == "2")
                num2 = btnDois.Text;
            lblResultado.Text = num2.ToString();
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            string num3;
            num3 = "3";
            if (btnTres.Text == "3")
                num3 = btnTres.Text;
            lblResultado.Text = num3.ToString();
        }


        private void btnQuatro_Click_1(object sender, EventArgs e)
        {
            string num4;
            num4 = "4";
            if (btnQuatro.Text == "4")
                num4 = btnQuatro.Text;
            lblResultado.Text = num4.ToString();
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            string num5;
            num5 = "5";
            if (btnCinco.Text == "5")
                num5 = btnCinco.Text;
            lblResultado.Text = num5.ToString();
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            string num6;
            num6 = "6";
            if (btnSeis.Text == "6")
                num6 = btnSeis.Text;
            lblResultado.Text = num6.ToString();
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            string num7;
            num7 = "7";
            if (btnSete.Text == "7")
                num7 = btnSete.Text;
            lblResultado.Text = num7.ToString();
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            string num8;
            num8 = "8";
            if (btnOito.Text == "8")
                num8 = btnOito.Text;
            lblResultado.Text = num8.ToString();
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            string num9;
            num9 = "9";
            if (btnNove.Text == "9")
                num9 = btnNove.Text;
            lblResultado.Text = num9.ToString();
        }

    }
}
