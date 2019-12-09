using SwitchBoard_Simulation;
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

                SwitchBoardHelper.ShowSwitchBoard(switchBoard);
                
                Console.WriteLine(-1 + ". Exit");

                Console.WriteLine("\nType the Device Number");

                int device = int.Parse(Console.ReadLine());
                
                if (device == -1)
                    break;

                Switch switchInstance = switchBoard[device - 1];

               SwitchBoardHelper.ShowSwitchMenu(switchInstance);

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                    switchInstance.ToggleState();
            }
        }

       
    }
}

