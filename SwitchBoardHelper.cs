using System;
using System.Collections.Generic;
using SwitchBoardSimulator;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoardSimulation
{
    class SwitchBoardHelper
    {

        public static void ShowSwitchBoard(List<Switch> SwitchBoard)
        {
            foreach (Switch Switch in SwitchBoard)
            {
                Console.WriteLine((SwitchBoard.IndexOf(Switch) + 1) + " " + Switch.GetDevice().type + " is " + (Switch.GetStatus() ? "ON" : "OFF"));
            }
        }

        public static void ShowSwitchMenu(Switch Switch)
        {
            Console.WriteLine("1. Switch " + Switch.GetDevice().type + " " + (Switch.GetStatus() ? "OFF" : "ON"));
            Console.WriteLine("2. BACK");
        }
    }
}
