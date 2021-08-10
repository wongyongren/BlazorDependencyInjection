using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorDependencyInjection
{
    public class CountModel : INotifyPropertyChanged
    {
        private int count;

        public int Count
        {
            get => count;
            set => SetProperty(ref count, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new
                                       PropertyChangedEventArgs(propertyName));
        }

        private bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string
                                                     propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public void Increment()
        {
            Count++;
        }
    }
}