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

        public Parcela(double prestacao, double juros,
            double amortizacao, double saldo, string identificador)
        {
            this.Prestacao = prestacao;
            this.Juros = juros;
            this.Amortizacao = amortizacao;
            this.Saldo = saldo;
            this.Identificador = identificador;

            ValidarModelo();
        }

        private void ValidarModelo()
        {
            //Validar
        }
    }
}