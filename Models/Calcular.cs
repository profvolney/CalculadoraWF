using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraWF.Models
{
    class Calcular
    {
        public Calcular()
        {
            
        }

        public double v1 { get; set; }
        public double v2 { get; set; }
        public double resultado { get; set; }
        public char operacao { get; set; }


        public void Calculadora()
        {
            switch (this.operacao)
            {
                case '+':
                    this.resultado = this.v1 + this.v2;
                    break;
                case '-':
                    this.resultado = this.v1 - this.v2;
                    break;
                case '*':
                    this.resultado = this.v1 * this.v2;
                    break;
                case '/':
                    this.resultado = this.v1 / this.v2;
                    break;
            }
        }

    }
}
