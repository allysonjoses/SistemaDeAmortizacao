using SistemaDeAmortizacao.Modelo.Validacao;

namespace SistemaDeAmortizacao.Modelo.Modelo
{
    /// <summary>
    //  Representa uma parcela de um emprestimo
    /// </summary>
    public class Parcela
    {
        /// <summary>
        //  Valor em reais da prestação
        /// </summary>
        public double Prestacao { get; private set; }

        /// <summary>
        //Valor em reais dos juros
        /// </summary>
        public double Juros { get; private set; }

        /// <summary>
        //  Valor em reais da amortização
        /// </summary>
        public double Amortizacao { get; private set; }

        /// <summary>
        //  Valor em reais do saldo devedor restante
        /// </summary>
        public double Saldo { get; private set; }

        /// <summary>
        //  Identificador da Parcela
        /// </summary>
        public string Identificador { get; private set; }

        public Parcela(double Prestacao, double Juros,
            double Amortizacao, double Saldo, string Identificador)
        {
            Validar.ElementoMenorQue(Prestacao, 0, "");
            Validar.ElementoMenorQue(Juros, 0, "");
            Validar.ElementoMenorQue(Amortizacao, 0, "");
            Validar.ElementoMenorQue(Saldo, 0, "");
            Validar.ElementoVazio(Identificador, "");

            this.Prestacao = Prestacao;
            this.Juros = Juros;
            this.Amortizacao = Amortizacao;
            this.Saldo = Saldo;
            this.Identificador = Identificador;
        }
    }
}