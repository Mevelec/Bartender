using System;
using System.Collections.Generic;
using System.Text;

namespace Pumps
{
    class Pump : Logic.IPump
    {
        public string name { get; set; }
        public string description { get; set; }
        public string pin { get; set; }

        public bool pump(float qty)
        {
            return false;
        }
    }
}
