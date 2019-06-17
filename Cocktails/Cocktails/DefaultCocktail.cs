using System;
using System.Collections.Generic;
using System.Linq;
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

        public float volume { get; set; }
        public float alcoholDegree { get; set; }
        public List<IIngredient> ingredients { get; private set; }
        public List<float> qtys { get; private set; }
        
        public DefaultCocktail()
        {
            this.ingredients =  new List<IIngredient>();
            this.qtys = new List<float>();
        }
        public void refreshQtys()
        {
            throw new NotImplementedException();
        }

        public Dictionary<IIngredient, float> getIngredients()
        {
            return this.ingredients.Zip(this.qtys, (k, v) => new { k, v })
              .ToDictionary(x => x.k, x => x.v);
        }
        public bool addIngredients(Dictionary<IIngredient, float> ingredients)
        {
            this.ingredients = new List<IIngredient>(ingredients.Keys);
            this.qtys = new List<float>(ingredients.Values);
            return true;
        }
        public bool addIngredient(IIngredient ingredient, float qty)
        {
            this.ingredients.Add(ingredient);
            this.qtys.Add(qty);
            return true;
        }
        public bool removeIngredient(IIngredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
