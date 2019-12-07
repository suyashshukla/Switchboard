using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoardSimulator
{
    class Switch 
    {

        public Switch()
        {
            Status = false;
        }

        private Appliance Device
        {
            get;set;
        }

        public bool Status
        {
            get;set;
        }

        public void ConnectAppliance(Appliance appliance)
        {
            this.Device = appliance;
        }

        public Appliance GetDevice()
        {
            return this.Device;
        } 

        public bool GetStatus()
        {
            return this.Status;
        }
        
        public void ToggleState()
        {
            this.Status = !this.Status;
        }


    }
}
