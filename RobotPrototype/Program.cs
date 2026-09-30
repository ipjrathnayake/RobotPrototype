using System;

namespace RobotPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create original Service Robot
            ServiceRobot serviceRobot = new ServiceRobot
            {
                ModelName = "SR-100",
                BatteryCapacity = 10,
                SoftwareVersion = "v1.0",
                ServiceTask = "Patient Assistance"
            };

            Console.WriteLine("Original Service Robot:");
            serviceRobot.Display();


            // Clone Service Robot
            ServiceRobot clonedServiceRobot =
                (ServiceRobot)serviceRobot.Clone();

            // Customize cloned robot
            clonedServiceRobot.BatteryCapacity = 15;
            clonedServiceRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("Cloned and Customized Service Robot:");
            clonedServiceRobot.Display();


            // Create original Industrial Robot
            IndustrialRobot industrialRobot = new IndustrialRobot
            {
                ModelName = "IR-200",
                BatteryCapacity = 20,
                SoftwareVersion = "v1.5",
                IndustrialTask = "Welding"
            };

            Console.WriteLine("Original Industrial Robot:");
            industrialRobot.Display();


            // Clone Industrial Robot
            IndustrialRobot clonedIndustrialRobot =
                (IndustrialRobot)industrialRobot.Clone();

            clonedIndustrialRobot.BatteryCapacity = 25;
            clonedIndustrialRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("Cloned and Customized Industrial Robot:");
            clonedIndustrialRobot.Display();


            // Create original Entertainment Robot
            EntertainmentRobot entertainmentRobot = new EntertainmentRobot
            {
                ModelName = "ER-300",
                BatteryCapacity = 12,
                SoftwareVersion = "v1.0",
                EntertainmentFeature = "Dancing and Singing"
            };

            Console.WriteLine("Original Entertainment Robot:");
            entertainmentRobot.Display();


            // Clone Entertainment Robot
            EntertainmentRobot clonedEntertainmentRobot =
                (EntertainmentRobot)entertainmentRobot.Clone();

            clonedEntertainmentRobot.BatteryCapacity = 18;
            clonedEntertainmentRobot.SoftwareVersion = "v2.0";

            Console.WriteLine("Cloned and Customized Entertainment Robot:");
            clonedEntertainmentRobot.Display();


            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}