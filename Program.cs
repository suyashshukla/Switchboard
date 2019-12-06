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
                    appliances[i].name = "Fan";
                }
                else if (i >= fan && i < bulb)
                {
                    appliances[i].name = "Bulb";
                }
                else
                {
                    appliances[i].name = "AC";
                }

                Console.WriteLine((i+1)+". "+appliances[i].name+" : " + (i + 1) + " is " + (appliances[i].status?"ON":"OFF"));

            }

            Console.WriteLine("Type in the Device Number");

            int device = int.Parse(Console.ReadLine());

        }
    }
}
