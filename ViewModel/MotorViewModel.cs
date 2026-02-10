using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Motor.Command;
using Motor.Model;

namespace Motor.ViewModel
{
    public class MotorViewModel :ViewModelBase
    {
        

        private string _deviceName = "水泵";
        public string DeviceName
        {
            get => _deviceName;
            set { _deviceName = value; Raise(); }
        }

        private bool _running;
        public bool Running
        {
            get => _running;
            set { _running = value; Raise(); }
        }

        private bool _standby;
        public bool Standby
        {
            get => _standby;
            set { _standby = value; Raise(); }
        }

        private bool _fault;
        public bool Fault
        {
            get => _fault;
            set { _fault = value; Raise(); }
        }

        private bool _connection;
        public bool Connection
        {
            get => _connection;
            set { _connection = value; Raise(); }
        }

        public ICommand MotorCMD { get; }
        public bool CanWork => Connection || !Fault;

        public MotorViewModel()
        {
            MotorCMD = new RelayCommand(
                execute: param => MessageBox.Show("Motor is Running"),
                canExecute: param => CanWork);
        }
    }
}
