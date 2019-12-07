using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoard_Simulation
{
    class Switch 
    {

        public Switch()
        {
            status = false;
        }

        private Appliance device
        {
            get;set;
        }

        public bool status
        {
            get;set;
        }

        public void connectAppliance(Appliance appliance)
        {
            this.device = appliance;
        }

        public Appliance getDevice()
        {
            return this.device;
        }
    }
}
