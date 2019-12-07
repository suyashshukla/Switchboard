using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoardSimulator
{
    class Appliance
    {

        public Appliance(int id,string type)
        {
            this.Id = id;
            this.type = type;
        }
        
        public string type
        {
            get;set;
        }

        public int Id
        {
            get;set;
        }

    }
}
