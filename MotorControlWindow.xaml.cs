using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MotorControlWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MotorControlWindow : Window
    {
        private MotorBuutonControl _targetMotorButton;

        public MotorControlWindow(string txt, MotorBuutonControl targetButton)
        {
            InitializeComponent();
            MotorText.Text = txt;
            _targetMotorButton = targetButton;
        }

        private void Run_Click(object sender, RoutedEventArgs e)
        {
            if (_targetMotorButton is not null)
            {
                // 设置 IsRunning 属性）
                _targetMotorButton.IsRunning = true;
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            if (_targetMotorButton is not null)
            {
                // 设置IsRunning 属性）
                _targetMotorButton.IsRunning = false;
            }
        }
    }
}
