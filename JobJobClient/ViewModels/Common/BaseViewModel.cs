using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobJobClient.viewmodel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected BaseViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(String propertyIntitule)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyIntitule);
                handler(this, e);
            }
        }
    }
}
