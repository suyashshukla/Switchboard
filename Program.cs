using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoard_Simulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nSWITCHBOARD SIMULATION\n");

            Console.WriteLine("Number of Fans?");
            int fan = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of Bulbs?");
            int bulb = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of ACs?");
            int ac = int.Parse(Console.ReadLine());

            Appliance[] appliances = new Appliance[fan + bulb + ac];


            for (int i = 0; i < appliances.Length; i++)
            {

                appliances[i] = new Appliance();

                if (i < fan)
                {
                    appliances[i].name = "Fan ";
                    appliances[i].number = (i + 1);
                }
                else if (i >= fan && i < (fan+bulb))
                {
                    appliances[i].name = "Bulb";
                    appliances[i].number = (i + 1)-fan;
                }
                else
                {
                    appliances[i].name = "AC  ";
                    appliances[i].number = (i + 1)-(fan+bulb);
                }
                
            }

            Console.WriteLine();

                while (true)
            {

                for (int i = 0; i < appliances.Length; i++)
                {
                Console.WriteLine((i + 1) + ". " + appliances[i].name + " : " + 
                    appliances[i].number + " is " + (appliances[i].status ? "ON" : "OFF"));
                }

                Console.WriteLine((appliances.Length + 1) + ". Exit");

                Console.WriteLine("\nType in the Device Number");

                int device = int.Parse(Console.ReadLine());
                
                if (device == (appliances.Length + 1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nAPPLIANCE MENU :");
                    Console.WriteLine("1. SWITCH " + appliances[device - 1].name.Trim() 
                        +" "+ appliances[device-1].number + " "+ (appliances[device - 1].status ? "OFF" : "ON"));
                    Console.WriteLine("2. BACK");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        appliances[device - 1].status = (appliances[device - 1].status? false : true);
                        Console.WriteLine("\n");
                    }
                }

            }

        }
    }
}
