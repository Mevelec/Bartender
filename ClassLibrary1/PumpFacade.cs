using System;
using System.Collections.Generic;
using System.Text;

namespace Pumps
{
    class PumpFacade
    {

        public Logic.IPumpManager GetPumpManager()
        {
            return new Managers.PumpManagerFakeDB();
        }
    }
}
