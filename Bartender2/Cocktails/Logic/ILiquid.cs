using System;
using System.Collections.Generic;
using System.Text;

namespace Cocktails.Logic
{
    public interface ILiquid : Logic.IIngredient
    {
        IngredientsTypes type { get; set; }
    }
}
