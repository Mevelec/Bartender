using System;
using System.Collections.Generic;
using System.Text;

namespace Pumps
{
    public enum PumpsTypes
    {
        Default = 0,
    }

    public sealed class PumpFacade
    {

        private PumpFacade() { }

        public static PumpFacade Instance { get { return Nested.instance; } }

        public Logic.IPumpManager GetPumpManager()
        {
            return new Managers.PumpsManager();
        }

        private class Nested
        {
            static Nested() { }

            internal static readonly PumpFacade instance = new PumpFacade();
        }
    }
}
