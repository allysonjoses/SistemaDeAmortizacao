using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaDeAmortizacao.Modelo.Modelo
{
    public class EmprestimoSAC : EmprestimoBase
    {
        public EmprestimoSAC() { }

        /// <summary>
        //  Realiza os calculos para geração do emprestimo SAC
        /// </summary>
        /// <returns>Lista de Parcelas do Emprestimo</returns>
        public override List<Parcela> GerarEmprestimo()
        {
            List<Parcela> parcelas = new List<Parcela>();

            Parcela parcelaZero = new Parcela(0, 0, 0, Valor, "0");
            parcelas.Add(parcelaZero);

            #region Parcelas

            double a = Math.Round(Valor / QtdParcelas, 2); //Amortização
            double s = Valor; //Saldo Devedor
            double jurosMesal = Math.Round(Juros / 12, 2);
            double j = 0; //Juros
            double p = 0; //Prestação

            for (int i = 1; i < QtdParcelas; i++)
            {
                j = Math.Round(s * jurosMesal / 100, 2); //Juros
                p = Math.Round(a + j, 2); //Prestação
                s -= a; //Saldo Devedor

                Parcela x = new Parcela(p, j, a, Math.Round(s,2), i.ToString());
                parcelas.Add(x);
            }

            #endregion

            #region Ultima Parcela
            //Devido ao arredondamento da prestação, é possível que o valor final pago seja
            //maior ou menor que o valor do emprestimo, dessa forma, é necessário
            //fazer a verificação na ultima parcela.

            j = Math.Round(s * jurosMesal / 100, 2); //Juros
            p = Math.Round(a + j, 2); //Prestação
            s -= a;

            if (s > 0) { p += Math.Round(s,2); s = 0; } //O valor final pago foi menor, então adicionamos ao valor da ultima prestação
            else { p -= Math.Round(s, 2); s = 0; } //O valor final pago foi maior, então subtraimos ao valor da ultima prestação

            Parcela ultimaParcela = new Parcela(p, j, a, s, QtdParcelas.ToString());
            parcelas.Add(ultimaParcela);

            #endregion

            #region Parcela Total

            double totalPrestacao = parcelas.Sum(_p => _p.Prestacao);
            double totalJuros = totalPrestacao - Valor;

            Parcela parcelaResultado = new Parcela(totalPrestacao, totalJuros, Valor, s, "TOTAL");
            parcelas.Add(parcelaResultado);

            #endregion

            return parcelas;
        }

        public override string ToString()
        {
            return "SAC";
        }
    }
}
