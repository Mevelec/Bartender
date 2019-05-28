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
            AddCocktail(new Cocktails.DefaultCocktail() { name = "cocktail 1", description = "descri 1 " });
            AddCocktail(new Cocktails.DefaultCocktail() { name = "cocktail 2", description = "descri 2 " });
            AddCocktail(new Cocktails.DefaultCocktail() { name = "cocktail 3", description = "descri 3 " });
            AddCocktail(new Cocktails.DefaultCocktail() { name = "cocktail 4", description = "descri 4 " });
            AddCocktail(
                new Cocktails.DefaultCocktail()
                {
                    name = "Manza 8",
                    description = "descri 8 ",
                    ingredients = new Dictionary<int, float>()
                    {

                    }
                }
            );

        }

        public ICocktail AddCocktail(ICocktail cocktail)
        {
            var collection = this.db.GetCollection<ICocktail>(this.cocktailTableName);
            collection.Insert(new Cocktails.DefaultCocktail()
                {
                name = cocktail.name,
                description = cocktail.description,
                alcoholDegree = cocktail.alcoholDegree,
                ingredients = cocktail.ingredients,
                }
            );
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
            item.ingredients = cocktail.ingredients;

            collection.Update(item);
            return cocktail;
        }
    }
}
