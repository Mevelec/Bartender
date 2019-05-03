using System;
using System.Collections.Generic;
using System.Text;

namespace Cocktails.Logic
{
    public interface IAlcohol : Logic.ILiquid
    {
        /// <summary>
        /// alcoholDegree is by % of alcohol in 1L
        /// </summary>
        float alcoholDegree { get; set; }
    }
}
