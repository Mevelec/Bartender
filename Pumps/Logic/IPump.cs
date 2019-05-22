using System;
using System.Collections.Generic;
using System.Text;

namespace Pumps.Logic
{
    public interface IPump
    {
        int id { get; set; }
        string name { get; set; }
        string description { get; set; }
        string pin { get; set; }
        bool pump(float qty);
    }
}
