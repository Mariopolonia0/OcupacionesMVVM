using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMOcupaciones
{
    public class IGeneric : IEnlace
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var hanler = PropertyChanged;
            if (hanler != null)
            {
                hanler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
