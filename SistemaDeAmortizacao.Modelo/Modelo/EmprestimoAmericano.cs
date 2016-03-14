using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAmortizacao.Modelo.Modelo
{
    public class EmprestimoAmericano : Base
    {
        public EmprestimoAmericano(double valorEmprestimo, double taxaDeJuros, int qtdParcelas) :
            base(valorEmprestimo, taxaDeJuros, qtdParcelas)
        { }

        /// <summary>
        //  Realiza os calculos para geração do emprestimo Americano
        /// </summary>
        /// <returns>Lista de Parcelas do Emprestimo</returns>
        public override List<Parcela> GerarEmprestimo()
        {
            throw new NotImplementedException();
        }
    }
}
