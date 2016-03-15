using System;
using System.Collections.Generic;

namespace SistemaDeAmortizacao.Modelo.Modelo
{
    public class EmprestimoPrice : EmprestimoBase
    {
        public EmprestimoPrice()
        {

        }

        /// <summary>
        //  Realiza os calculos para geração do emprestimo Price
        /// </summary>
        /// <returns>Lista de Parcelas do Emprestimo</returns>
        public override List<Parcela> GerarEmprestimo()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Price";
        }
    }
}
