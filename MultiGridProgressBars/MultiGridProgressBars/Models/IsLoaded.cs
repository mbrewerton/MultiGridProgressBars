using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiGridProgressBars.Models
{
    public class IsLoaded : INotifyPropertyChanged
    {
        private bool _loaded;

        public bool Loaded
        {
            get { return _loaded; }
            set
            {
                _loaded = value;
                RaisePropertyChanged("Loaded");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
