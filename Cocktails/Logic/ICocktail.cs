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

        //var to set on creation of cocktail
        float volume { get; set; }
        float alcoholDegree { get; set; }
        /// <summary>
        /// recalculate this.volume and this.alcoholDegree 
        /// using this.ingredients
        /// </summary>
        void refreshQtys();

        /// <summary>
        /// return the list of ingredients as  Dictionary<IIngredient, float>
        /// </summary>
        /// <returns></returns>
        Dictionary<IIngredient, float> getIngredients();
        bool addIngredients(Dictionary<IIngredient, float> ingredients);
        bool addIngredient(IIngredient ingredient, float qty);
        bool removeIngredient(IIngredient ingredient);

    }
}
