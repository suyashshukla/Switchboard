using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoard_Simulation
{
    class Appliance
    {

        public Appliance(){
            status = false;
            name = "Appliance";
        }

        public bool status
        {
            get;set;
        }

        public string name
        {
            get;set;
        }

    }
}
