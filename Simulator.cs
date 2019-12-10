using SwitchBoardSimulation;
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
            int Fan = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of Bulbs?");
            int Bulb = int.Parse(Console.ReadLine());

            Console.WriteLine("Number of ACs?");
            int AC = int.Parse(Console.ReadLine());

            List<Switch> SwitchBoard = new List<Switch>();


            for (int i = 0; i < Fan; i++)
            {
                Fan FanAppliance = new Fan((i + 1));

                Switch Switch = new Switch();
                Switch.ConnectAppliance(FanAppliance);
                SwitchBoard.Add(Switch);
            }

            for (int i = 0; i < Bulb; i++)
            {
                Bulb BulbAppliance = new Bulb((i + 1));

                Switch Switch = new Switch();
                Switch.ConnectAppliance(BulbAppliance);                
                SwitchBoard.Add(Switch);
            }


            for (int i = 0; i < AC; i++)
            {
                AC ACAppliance = new AC((i + 1));

                Switch Switch = new Switch();
                Switch.ConnectAppliance(ACAppliance);
                SwitchBoard.Add(Switch);
            }

            Console.WriteLine();


            while (true)
            {

                SwitchBoardHelper.ShowSwitchBoard(SwitchBoard);
                
                Console.WriteLine(-1 + ". Exit");

                Console.WriteLine("\nType the Device Number");

                int Device = int.Parse(Console.ReadLine());
                
                if (Device == -1)
                    break;

                Switch SwitchInstance = SwitchBoard[Device - 1];

               SwitchBoardHelper.ShowSwitchMenu(SwitchInstance);

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                    SwitchInstance.ToggleState();
            }
        }

       
    }
}

