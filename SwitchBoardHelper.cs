using System;
using System.Collections.Generic;
using SwitchBoardSimulator;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoard_Simulation
{
    class SwitchBoardHelper
    {

        public static void ShowSwitchBoard(List<Switch> switchBoard)
        {
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
