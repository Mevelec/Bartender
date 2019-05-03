using System;
using System.Collections.Generic;
using System.Text;

namespace Cocktails.Logic
{
    public interface IIngredient
    {
        int id { get; set;  }
        string name { get; set; }
        string description {get; set; }
        IngredientsTypes type { get; set; }

        Dictionary<IIngredient, float> composition { get; set;  }
        float nutritionalValue { get; set; }
    }
}
