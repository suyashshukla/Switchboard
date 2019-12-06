using System;

namespace SwitchBoard_Simulation
{
    internal class Simulator
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("\nSWITCHBOARD SIMULATION\n");

            Console.WriteLine("Number of Fans?");
            int fan = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of Bulbs?");
            int bulb = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of ACs?");
            int ac = int.Parse(Console.ReadLine());

            Appliance[] appliances = new Appliance[fan + bulb + ac];

            Switch[] switches = new Switch[fan + bulb + ac];


            for (int i = 0; i < appliances.Length; i++)
            {

                if (i < fan)
                {
                    Fan f = new Fan
                    {
                        name = "Fan ",
                        number = (i + 1)
                    };
                    Switch s = new Switch(f);
                    switches[i] = s;
                }
                else if (i >= fan && i < (fan + bulb))
                {
                    Bulb b = new Bulb
                    {
                        number = (i + 1) - fan,
                        name = "Bulb"
                    };
                    Switch s = new Switch(b);
                    switches[i] = s;
                }
                else
                {
                    AC a = new AC
                    {
                        name = "AC  ",
                        number = (i + 1) - (fan + bulb)
                    };
                    Switch s = new Switch(a);
                    switches[i] = s;
                }

            }

            Console.WriteLine();

            while (true)
            {

                for (int i = 0; i < appliances.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + switches[i].device.name + " : " +
                        switches[i].device.number + " is " + (switches[i].device.status ? "ON" : "OFF"));
                }

                Console.WriteLine((switches.Length + 1) + ". Exit");

                Console.WriteLine("\nType in the Device Number");

                int device = int.Parse(Console.ReadLine());

                if (device == (switches.Length + 1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nAPPLIANCE MENU :");
                    Console.WriteLine("1. SWITCH " + switches[device - 1].device.name.Trim()
                        + " " + switches[device - 1].device.number + " " + (switches[device - 1].device.status ? "OFF" : "ON"));
                    Console.WriteLine("2. BACK");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        switches[device - 1].device.status = (switches[device - 1].device.status ? false : true);
                        Console.WriteLine("\n");
                    }
                }

            }

        }
    }
}
