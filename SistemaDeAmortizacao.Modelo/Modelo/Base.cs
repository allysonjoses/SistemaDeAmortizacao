using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAmortizacao.Modelo.Modelo
{
    /// <summary>
    /// Classe base para os 3 tipos de emprestimos
    /// de amortização (SAC, Price, Americano)
    /// </summary>
    public abstract class Base
    {
        /// <summary>
        //  Valor toral do Emprestimo
        /// </summary>
        public double ValorEmprestimo { get; private set; }

        /// <summary>
        //  Taxa de Juros Anual
        /// </summary>
        public double TaxaDeJuros { get; private set; }

        /// <summary>
        //  Quantidade de parcelas
        /// </summary>
        public int QtdParcelas { get; private set; }

        public Base(double valorEmprestimo, double taxaDeJuros, int qtdParcelas)
        {
            this.ValorEmprestimo = valorEmprestimo;
            this.TaxaDeJuros = taxaDeJuros;
            this.QtdParcelas = qtdParcelas;

            ValidarModelo();
        }

        public abstract List<Parcela> GerarEmprestimo();

        private void ValidarModelo()
        {
            throw new NotImplementedException();
        }
    }
}
