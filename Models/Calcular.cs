﻿using System;
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

        public int Soma(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public int Subtracao(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        public int Multiplicacao(int valor1, int valor2)
        {
            return valor1 * valor2;
        }
        public int Divisao(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
    }
}
