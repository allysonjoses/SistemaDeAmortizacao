using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SistemaDeAmortizacao.UI.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void Notify([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged != null && !string.IsNullOrEmpty(propertyName))
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
