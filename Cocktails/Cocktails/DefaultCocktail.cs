using System;
using System.Collections.Generic;
using System.Text;
using Cocktails.Logic;

namespace Cocktails.Cocktails
{
    class DefaultCocktail : Logic.ICocktail
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public IRecipe recipe { get; set; }
        public Dictionary<IIngredient, float> ingredients { get; set; }
        public float volume { get; set; }
        public float alcoholDegree { get; set; }

        public DefaultCocktail()
        {
            this.ingredients = new Dictionary<IIngredient, float>();
        }
        public void refreshQtys()
        {
            throw new NotImplementedException();
        }
    }
}
