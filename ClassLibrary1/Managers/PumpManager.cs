using System;
using System.Collections.Generic;
using System.Text;

namespace Pumps.Managers
{
    class PumpManagerFakeDB : Logic.IPumpManager
    {
        private int _id = 1;
        readonly List<Pump> _pumpsList = new List<Pump>();

        public PumpManagerFakeDB()
        {
            this.AddPump(new Pump() { name = "pump 1 ", description = ""});
            this.AddPump(new Pump() { name = "pump 2 ", description = "" });
            this.AddPump(new Pump() { name = "pump 3 ", description = "" });
            this.AddPump(new Pump() { name = "pump 4 ", description = "" });
            this.AddPump(new Pump() { name = "pump 5 ", description = "" });
            this.AddPump(new Pump() { name = "pump 6 ", description = "" });
        }

        public Pump AddPump(Pump pump)
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

        public List<Pump> GetPumps()
        {
            return new List<Pump>(_pumpsList);
        }
    }
}
