using System;
using System.Collections.Generic;
using System.Text;

namespace Motor.Model
{
    public class MotorModel
    {
        public bool Running { get; set; } 
        public bool Standby { get; set; }
        public bool Fault { get; set; }

        public bool Connection {  get; set; }
    }
}
