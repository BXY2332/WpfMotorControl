using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace Motor.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void Raise([CallerMemberName] string? p = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(p));
            if (p == nameof(MotorViewModel.Connection) || p == nameof(MotorViewModel.Fault))
            {
                CommandManager.InvalidateRequerySuggested();
            }
        }
    }
}
