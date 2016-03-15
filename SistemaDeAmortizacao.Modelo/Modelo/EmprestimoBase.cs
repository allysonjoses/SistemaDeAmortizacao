using SistemaDeAmortizacao.Modelo.Validacao;
using System.Collections.Generic;

namespace SistemaDeAmortizacao.Modelo.Modelo
{
    /// <summary>
    /// Classe base para os 3 tipos de emprestimos
    /// de amortização (SAC, Price, Americano)
    /// </summary>
    public abstract class EmprestimoBase
    {
        /// <summary>
        //  Valor toral do Emprestimo
        /// </summary>
        public double Valor { get; private set; }

        /// <summary>
        //  Taxa de Juros Anual
        /// </summary>
        public double Juros { get; private set; }

        /// <summary>
        //  Quantidade de parcelas
        /// </summary>
        public int QtdParcelas { get; private set; }

        public void SetValues(double Valor, double Juros, int QtdParcelas)
        {
            Validar.ElementoMenorQue(Valor, 1, "");
            Validar.ElementoMenorQue(Juros, 0, "");
            Validar.ElementoMenorQue(QtdParcelas, 1, "");

            this.Valor = Valor;
            this.Juros = Juros;
            this.QtdParcelas = QtdParcelas;
        }

        public abstract List<Parcela> GerarEmprestimo();
    }
}
