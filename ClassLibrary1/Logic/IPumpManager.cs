using System;
using System.Collections.Generic;
using System.Text;

namespace Pumps.Logic
{
    interface IPumpManager
    {
        /// <summary>
        /// Gett all pumps
        /// </summary>
        /// <returns></returns>
        List<Pump> GetPumps();

        /// <summary>
        /// Add a pump using a Pump Object
        /// </summary>
        /// <param name="pump"></param>
        /// <returns></returns>
        Pump AddPump(Pump pump);
               
    }
}
