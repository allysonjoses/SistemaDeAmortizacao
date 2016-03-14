using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAmortizacao.Modelo.Modelo
{
    public class EmprestimoSAC : Base
    {
        public EmprestimoSAC(double valorEmprestimo, double taxaDeJuros, int qtdParcelas) :
            base(valorEmprestimo, taxaDeJuros, qtdParcelas)
        { }

        /// <summary>
        //  Realiza os calculos para geração do emprestimo SAC
        /// </summary>
        /// <returns>Lista de Parcelas do Emprestimo</returns>
        public override List<Parcela> GerarEmprestimo()
        {
            List<Parcela> parcelas = new List<Parcela>();

            double a = Valor/QtdParcelas; //Amortização
            double s = Valor; //Saldo Devedor
            double jurosMesal = Juros / 12;

            Parcela parcelaZero = new Parcela(0, 0, 0, s, "0");
            parcelas.Add(parcelaZero);

            for (int i = 1; i < QtdParcelas; i++)
            {
                double j = s * jurosMesal / 100; //Juros
                double p = a + j; //Prestação

                Parcela x = new Parcela(p, j, a, s, i.ToString());
                parcelas.Add(x);

                s -= a;
            }

            double totalPrestacao = parcelas.Sum(p => p.Prestacao);
            double totalJuros = totalPrestacao - Valor;

            Parcela parcelaResultado = new Parcela(totalPrestacao, totalJuros, Valor, s, "TOTAL");
            parcelas.Add(parcelaResultado);

            return new List<Parcela>();
        }
    }
}
