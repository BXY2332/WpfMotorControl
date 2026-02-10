using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Motor.ViewModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Motor.Controls
{
    public class MotorControl : Control
    {
        static MotorControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MotorControl), new FrameworkPropertyMetadata(typeof(MotorControl)));
        }

        public static readonly DependencyProperty DeviceNameProperty =
            DependencyProperty.Register("DeviceName", typeof(string), typeof(MotorControl));
        public string DeviceName
        {
            get => (string)GetValue(DeviceNameProperty);
            set => SetValue(DeviceNameProperty, value);
        }


        public static readonly DependencyProperty ConnectionProperty =
            DependencyProperty.Register("Connection", typeof(bool), typeof(MotorControl), new PropertyMetadata(false));
        public bool Connection
        {
            get => (bool)GetValue(ConnectionProperty);
            set => SetValue(ConnectionProperty, value);
        }


        public static readonly DependencyProperty RunningProperty =
            DependencyProperty.Register(nameof(Running), typeof(bool), typeof(MotorControl), new PropertyMetadata(false));
        public bool Running
        {
            get => (bool)GetValue(RunningProperty);
            set => SetValue(RunningProperty, value);
        }

        public static readonly DependencyProperty StandbyProperty =
            DependencyProperty.Register(nameof(Standby), typeof(bool), typeof(MotorControl), new PropertyMetadata(false));
        public bool Standby
        {
            get => (bool)GetValue(StandbyProperty);
            set => SetValue(StandbyProperty, value);
        }

        public static readonly DependencyProperty FaultProperty =
            DependencyProperty.Register(nameof(Fault), typeof(bool), typeof(MotorControl), new PropertyMetadata(false));
        public bool Fault
        {
            get => (bool)GetValue(FaultProperty);
            set => SetValue(FaultProperty, value);
        }
    }
}
