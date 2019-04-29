using System;
using System.Collections.Generic;
using System.Text;

namespace Cocktails.Logic
{
    public interface IPowder : Logic.IIngredient
    {
        IngredientsTypes type { get; set; }
    }
}
