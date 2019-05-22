using System;
using System.Collections.Generic;
using System.Text;

namespace Pumps
{
    public abstract class Pump : Logic.IPump
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string pin { get; set; }

        protected PumpsTypes type = PumpsTypes.Default;

        public bool pump(float qty)
        {
            return false;
        }
    }
}
