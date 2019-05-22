using System;
using System.Collections.Generic;
using System.Text;

namespace Pumps.Pumps
{
    public class DefaultPump : Pump
    {
        public DefaultPump()
        {
            this.type = PumpsTypes.Default;
        }

        public DefaultPump(Pump pump)
        {
            this.description = pump.description;
            this.name = pump.name;
            this.pin = pump.pin;

            this.type = PumpsTypes.Default;
        }
    }
}
