using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAmortizacao.Modelo.Validacao
{
    public static class Validar
    {
        public static void ElementoNulo(object object1, string message)
        {
            if (object1 == null)
            {
                throw new InvalidOperationException(message);
            }
        }

        public static void ElementoMenorQue(double object1, double min, string message)
        {
            ElementoNulo(object1, message);

            if (object1 < min)
                throw new InvalidOperationException(message);
        }
    }
}
