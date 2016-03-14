using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAmortizacao.Modelo.Modelo
{
    public class EmprestimoPrice : Base
    {
        public EmprestimoPrice(double valorEmprestimo, double taxaDeJuros, int qtdParcelas) :
            base(valorEmprestimo, taxaDeJuros, qtdParcelas)
        { }

        /// <summary>
        //  Realiza os calculos para geração do emprestimo Price
        /// </summary>
        /// <returns>Lista de Parcelas do Emprestimo</returns>
        public override List<Parcela> GerarEmprestimo()
        {
            throw new NotImplementedException();
        }
    }
}
