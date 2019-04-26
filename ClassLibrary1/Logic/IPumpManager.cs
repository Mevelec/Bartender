using System;
using System.Collections.Generic;
using System.Text;

namespace Pumps.Logic
{
    public interface IPumpManager
    {
        /// <summary>
        /// Gett all pumps
        /// </summary>
        /// <returns></returns>
        List<Logic.IPump> GetPumps();

        /// <summary>
        /// Add a pump using a Pump Object
        /// </summary>
        /// <param name="pump"></param>
        /// <returns></returns>
        Logic.IPump AddPump(Logic.IPump pump);
               
    }
}
