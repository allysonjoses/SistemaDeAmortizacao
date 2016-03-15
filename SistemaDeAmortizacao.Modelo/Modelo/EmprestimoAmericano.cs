using System;
using System.Collections.Generic;

namespace SistemaDeAmortizacao.Modelo.Modelo
{
    public class EmprestimoAmericano : EmprestimoBase
    {
        public EmprestimoAmericano()
        {

        }
        /// <summary>
        //  Realiza os calculos para geração do emprestimo Americano
        /// </summary>
        /// <returns>Lista de Parcelas do Emprestimo</returns>
        public override List<Parcela> GerarEmprestimo()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Americano";
        }
    }
}
