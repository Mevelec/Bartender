using System;
using System.Collections.Generic;
using System.Text;

namespace Pumps.Managers
{
    class PumpsManager : Logic.IPumpManager
    {
        private int _id = 1;
        readonly List<Logic.IPump> _pumpsList = new List<Logic.IPump>();

        public PumpsManager()
        {
            this.AddPump(new Pump() { name = "pump 1 ", description = ""});
            this.AddPump(new Pump() { name = "pump 2 ", description = "" });
            this.AddPump(new Pump() { name = "pump 3 ", description = "" });
            this.AddPump(new Pump() { name = "pump 4 ", description = "" });
            this.AddPump(new Pump() { name = "pump 5 ", description = "" });
            this.AddPump(new Pump() { name = "pump 6 ", description = "" });
        }

        public Logic.IPump AddPump(Logic.IPump pump)
        {
            Pump addedPump;
            this._pumpsList.Add(addedPump = new Pump()
            {
                name = pump.name,
                description = pump.description,
            });
            addedPump.pin = (_id++).ToString();

            return addedPump;
        }

        public List<Logic.IPump> GetPumps()
        {
            return new List<Logic.IPump>(_pumpsList);
        }
    }
}
