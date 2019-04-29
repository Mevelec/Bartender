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
        Logic.IPump AddPump(PumpsTypes type);

        /// <summary>
        /// Delete a pump based on int id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeletePump(int id);

        /// <summary>
        /// Update a pump using IPump Object
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        Logic.IPump UpdatePump(Logic.IPump pump);

        
    }
}
