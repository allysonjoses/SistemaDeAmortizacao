using GalaSoft.MvvmLight.CommandWpf;
using MahApps.Metro.Controls.Dialogs;
using SistemaDeAmortizacao.Modelo.Modelo;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;
using SistemaDeAmortizacao.Utilitarios.Tools;

namespace SistemaDeAmortizacao.UI.ViewModel
{
    public class MainWindowsViewModel : ViewModelBase
    {
        public ICommand GerarEmprestimoCommand { get; set; }

        public ICommand SalvarEmprestimoCommand { get; set; }

        #region prop

        private MainWindow mainWindow;

        double valor;
        public double Valor
        {
            get { return valor; }
            set { valor = value; Notify(); }
        }

        double juros;
        public double Juros
        {
            get { return juros; }
            set { juros = value; Notify(); }
        }

        int parcelas;
        public int Parcelas
        {
            get { return parcelas; }
            set { parcelas = value; Notify(); }
        }

        ObservableCollection<EmprestimoBase> sistemaDeAmortizacao;
        public ObservableCollection<EmprestimoBase> SistemaDeAmortizacao
        {
            get { return sistemaDeAmortizacao; }
            set { sistemaDeAmortizacao = value; Notify(); }
        }

        ObservableCollection<Parcela> emprestimoParcelas;
        public ObservableCollection<Parcela> EmprestimoParcelas
        {
            get { return emprestimoParcelas; }
            set { emprestimoParcelas = value; Notify(); }
        }

        EmprestimoBase sistemaDeAmortizacaoSelecionado;

        public EmprestimoBase SistemaDeAmortizacaoSelecionado
        {
            get { return sistemaDeAmortizacaoSelecionado; }
            set { sistemaDeAmortizacaoSelecionado = value; Notify(); Tipo=""; }
        }

        public string Tipo
        {
            get { return "Sistema de Amortização " + SistemaDeAmortizacaoSelecionado.ToString(); }
            set { Notify(); }
        }

        #endregion

        #region Construtor

        public MainWindowsViewModel(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;

            GerarEmprestimoCommand = new RelayCommand(GerarEmprestimo);
            SalvarEmprestimoCommand = new RelayCommand(SalvarEmprestimo);

            SistemaDeAmortizacao = new ObservableCollection<EmprestimoBase>();

            EmprestimoParcelas = new ObservableCollection<Parcela>();

            SistemaDeAmortizacao.Add(new EmprestimoAmericano());
            SistemaDeAmortizacao.Add(new EmprestimoPrice());
            SistemaDeAmortizacao.Add(new EmprestimoSAC());

            SistemaDeAmortizacaoSelecionado = SistemaDeAmortizacao[0];
            Valor = 5000;
            Juros = 12;
            Parcelas = 5;
        }

        #endregion

        #region Metodos

        private async void GerarEmprestimo()
        {
            try
            {
                SistemaDeAmortizacaoSelecionado.SetValues(Valor, Juros, Parcelas);
                EmprestimoParcelas = new ObservableCollection<Parcela>(SistemaDeAmortizacaoSelecionado.GerarEmprestimo());
            }
            catch (Exception ex)
            {
               await mainWindow.ShowMessageAsync("Não foi possível gerar o emprestimo!", ex.Message);
            }
        }

        private async void SalvarEmprestimo()
        {
            try
            {
                PDF.ExportToPdf(EmprestimoParcelas, Tipo, @"D:\Test.pdf");
            }
            catch (Exception ex)
            {
                await mainWindow.ShowMessageAsync("Não foi possível salvar o emprestimo!", ex.Message);
            }
        }

        #endregion
    }
}
