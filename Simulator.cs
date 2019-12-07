using System;
using System.Collections.Generic;

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

            List<Switch> switchBoard = new List<Switch>();


            for (int i = 0; i < fan; i++)
            {
                Fan f = new Fan((i + 1));

                Switch s = new Switch();
                s.connectAppliance(f);
                switchBoard.Add(s);
            }

            for (int i = 0; i < bulb; i++)
            {
                Bulb b = new Bulb((i + 1));

                Switch s = new Switch();
                s.connectAppliance(b);                
                switchBoard.Add(s);
            }


            for (int i = 0; i < ac; i++)
            {
                AC a = new AC((i + 1));

                Switch s = new Switch();
                s.connectAppliance(a);
                switchBoard.Add(s);
            }

            Console.WriteLine();


            while (true)
            {

                showSwitchBoard(switchBoard);
                
                Console.WriteLine(-1 + ". Exit");

                Console.WriteLine("\nType in the Device Number");

                int device = int.Parse(Console.ReadLine());
                
                if (device == -1)
                    break;

                Switch switchInstance = switchBoard[device - 1];

                Console.WriteLine("1. Switch " + switchInstance.getDevice().type + " " + (switchInstance.status ? "OFF" : "ON"));
                Console.WriteLine("2. BACK");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        switchInstance.status = true;
                        break;
                    default:
                        break;
                }
            }
        }

        public static void showSwitchBoard(List<Switch> switchBoard) {
            foreach (Switch s in switchBoard)
            {
                Console.WriteLine((switchBoard.IndexOf(s) + 1) + " " + s.getDevice().type + " is " + (s.status ? "ON" : "OFF"));
            }
        }
    }
}

