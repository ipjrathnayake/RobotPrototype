using System;
using System.Collections.Generic;
using System.Text;

namespace RobotPrototype
{
    public class ServiceRobot : IRobotPrototype
    {
        public string ModelName { get; set; }
        public int BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }
        public string ServiceTask { get; set; }

        public IRobotPrototype Clone()
        {
            return new ServiceRobot
            {
                ModelName = this.ModelName,
                BatteryCapacity = this.BatteryCapacity,
                SoftwareVersion = this.SoftwareVersion,
                ServiceTask = this.ServiceTask
            };
        }

        public void Display()
        {
            Console.WriteLine("Service Robot");
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
            Console.WriteLine("Service Task: " + ServiceTask);
            Console.WriteLine();
        }
    }
}