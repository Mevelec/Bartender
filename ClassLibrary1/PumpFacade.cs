using System;
using System.Collections.Generic;
using System.Text;

namespace Pumps
{
    public class PumpFacade
    {

        public Logic.IPumpManager GetPumpManager()
        {
            return new Managers.PumpsManager();
        }
    }
}
