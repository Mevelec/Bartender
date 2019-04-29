using System;
using System.Collections.Generic;
using System.Text;

namespace Cocktails.Logic
{
    public interface ICocktail
    {
        int id { get; set; }
        string name { get; set; }
        string description { get; set; }

        IRecipe recipe { get; set; }
        Dictionary<IIngredient, float> ingredients { get; set; }

        //var to set on creation of cocktail
        float volume { get; set; }
        float alcoholDegree { get; set; }
        /// <summary>
        /// recalculate this.volume and this.alcoholDegree 
        /// using this.ingredients
        /// </summary>
        void refreshQtys();

    }
}
