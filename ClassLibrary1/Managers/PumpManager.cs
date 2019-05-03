using System;
using System.Collections.Generic;
using System.Text;
using Pumps.Logic;
using Pumps.Pumps;

namespace Pumps.Managers
{
    class PumpsManager : Logic.IPumpManager
    {
        private int _id = 1;
        readonly List<Logic.IPump> _pumpsList = new List<Logic.IPump>();

        public PumpsManager()
        {
            this.Initialize();
        }

        protected void Initialize()
        {
            this._pumpsList.Add(new DefaultPump() { name = "pump 1 ", description = "descri 1", pin="000000", id = 1});
            this._pumpsList.Add(new DefaultPump() { name = "pump 2 ", description = "descri 2", pin = "010010", id = 2 });
            this._pumpsList.Add(new DefaultPump() { name = "pump 3 ", description = "descri 3", id = 3 });
            this._pumpsList.Add(new DefaultPump() { name = "pump 4 ", description = "descri 4", id = 4 });
            this._pumpsList.Add(new DefaultPump() { name = "pump 5 ", description = "descri 5", id = 5  });
            this._pumpsList.Add(new DefaultPump() { name = "pump 6 ", description = "descri 6", pin = "020000", id = 6 });
        }

        public Logic.IPump AddPump(PumpsTypes type)
        {
            Logic.IPump addedPump;
            switch (type)
            {
                case PumpsTypes.Default:
                    this._pumpsList.Add(addedPump = new DefaultPump()
                    {
                        name = "new pump",
                        description = "",
                    });
                    addedPump.id = _id++;
                    break;
                default: // create default pump by default
                    this._pumpsList.Add(addedPump = new DefaultPump()
                    {
                        name = "new pump",
                        description = "",
                    });
                    addedPump.id = _id++;
                    break;
            }
            return addedPump;
        }

        public List<Logic.IPump> GetPumps()
        {
            return new List<Logic.IPump>(_pumpsList);
        }

        public bool DeletePump(int id)
        {
            int i = this._pumpsList.RemoveAll(x => x.id == id);
            return i > 0 ? true : false;
        }

        public IPump UpdatePump(IPump pump)
        {
            Logic.IPump updatedPump = this._pumpsList.Find(x => x.id == pump.id);
            if(updatedPump != null )
            {
                updatedPump.name = pump.name;
                updatedPump.description = pump.description;
                updatedPump.pin = pump.pin;
                return pump;
            }
            return null;
        }
    }
}
