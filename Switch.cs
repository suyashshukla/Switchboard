using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoard_Simulation
{
    class Switch 
    {

        public Switch(Appliance appliance)
        {
            device = appliance;
        }

        public Appliance device
        {
            get;set;
        }
    }
}
