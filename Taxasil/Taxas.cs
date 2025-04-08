using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxasil
{

    public static class Taxas
    {
        public static double CalcularTaxas(double valor)
        {
            if (valor >= 0)
            {
                if (valor < 1000)
                {
                    return valor += valor * 0.07;
                }
                else if (valor >= 1000 && valor <= 3000)
                {
                    return valor += valor * 0.1;
                }
                else
                {
                    return valor += valor * 0.15;
                }
            }
            return valor;
        }

    }
}