using System;
using System.Collections.Generic;
using System.Text;
using Cocktails.Logic;
using System.Linq;
using LiteDB;


namespace Cocktails.Managers
{
    class LiteDBCocktailManager : Logic.ICocktailManager
    {
        protected LiteDatabase db;
        private string cocktailTableName = "cocktails";

        public LiteDBCocktailManager(String dbLink)
        {
            this.db = new LiteDatabase(dbLink);
            var collection = this.db.GetCollection<ICocktail>(this.cocktailTableName);
            collection.Delete(x =>x != null);
        }

        public ICocktail AddCocktail(ICocktail cocktail)
        {
            var collection = this.db.GetCollection<ICocktail>(this.cocktailTableName);
            ICocktail tmpCocktail = new Cocktails.DefaultCocktail()
            {
                name = cocktail.name,
                description = cocktail.description,
                alcoholDegree = cocktail.alcoholDegree,

            };
            tmpCocktail.addIngredients(cocktail.getIngredients());
            collection.Insert(tmpCocktail);
            return cocktail;         
        }

        public bool DeleteCocktail(int id)
        {
            throw new NotImplementedException();
        }

        public List<ICocktail> GetCocktails()
        {
            return this.db.GetCollection<ICocktail>(this.cocktailTableName).FindAll().ToList();
        }

        public ICocktail UpdateCocktail(ICocktail cocktail)
        {
            var collection = this.db.GetCollection<ICocktail>(this.cocktailTableName);

            var item = collection.FindById(cocktail.id);
            item.name = cocktail.name;
            item.description = cocktail.description;
            item.alcoholDegree = cocktail.alcoholDegree;
            item.addIngredients(cocktail.getIngredients());

            collection.Update(item);
            return cocktail;
        }
    }
}
