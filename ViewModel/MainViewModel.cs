using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Motor.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        private MotorViewModel _motor;
        public MotorViewModel Motor
        {
            get => _motor;
            set {  _motor = value; Raise(); }
        }

        public ObservableCollection<MotorViewModel> MotorList { get; set; }

        public MainViewModel()
        {
            Motor = new MotorViewModel
            {
                DeviceName = "主电机",
                Connection = true,
                Standby = true,
            };

            MotorList = new ObservableCollection<MotorViewModel>
            {
                new MotorViewModel { DeviceName = "传送带 A", Connection = true, Standby = true },
                new MotorViewModel { DeviceName = "机械臂 B", Connection = true, Standby = true },
                new MotorViewModel { DeviceName = "风扇 C", Connection = true, Standby = true }
            };
        }
    }
}
