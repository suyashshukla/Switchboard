using System;
using System.Collections.Generic;

namespace SwitchBoardSimulator
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
                s.ConnectAppliance(f);
                switchBoard.Add(s);
            }

            for (int i = 0; i < bulb; i++)
            {
                Bulb b = new Bulb((i + 1));

                Switch s = new Switch();
                s.ConnectAppliance(b);                
                switchBoard.Add(s);
            }


            for (int i = 0; i < ac; i++)
            {
                AC a = new AC((i + 1));

                Switch s = new Switch();
                s.ConnectAppliance(a);
                switchBoard.Add(s);
            }

            Console.WriteLine();


            while (true)
            {

                ShowSwitchBoard(switchBoard);
                
                Console.WriteLine(-1 + ". Exit");

                Console.WriteLine("\nType the Device Number");

                int device = int.Parse(Console.ReadLine());
                
                if (device == -1)
                    break;

                Switch switchInstance = switchBoard[device - 1];

                ShowSwitchMenu(switchInstance);

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                    switchInstance.ToggleState();
            }
        }

        public static void ShowSwitchBoard(List<Switch> switchBoard) {
            foreach (Switch s in switchBoard)
            {
                Console.WriteLine((switchBoard.IndexOf(s) + 1) + " " + s.GetDevice().type + " is " + (s.GetStatus() ? "ON" : "OFF"));
            }
        }

        public static void ShowSwitchMenu(Switch s)
        {
            Console.WriteLine("1. Switch " + s.GetDevice().type + " " + (s.GetStatus() ? "OFF" : "ON"));
            Console.WriteLine("2. BACK");
        }
    }
}

