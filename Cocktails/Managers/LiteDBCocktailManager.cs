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
        private string ingredientsTableName = "ingredients";

        public LiteDBCocktailManager(String dbLink)
        {
            this.db = new LiteDatabase(dbLink);
            var collection = this.db.GetCollection<ICocktail>(this.cocktailTableName);
            collection.Delete(x =>x != null);
            collection.Insert(new Cocktails.DefaultCocktail() { name = "cocktail 1", description = "descri 1 " });
            collection.Insert(new Cocktails.DefaultCocktail() { name = "cocktail 2", description = "descri 2 " });
            collection.Insert(new Cocktails.DefaultCocktail() { name = "cocktail 3", description = "descri 3 " });
            collection.Insert(new Cocktails.DefaultCocktail() { name = "cocktail 4", description = "descri 4 " });
            collection.Insert(new Cocktails.DefaultCocktail() { name = "cocktail 5", description = "descri 5 " });
            collection.Insert(new Cocktails.DefaultCocktail() { name = "cocktail 6", description = "descri 6 " });
            collection.Insert(new Cocktails.DefaultCocktail() { name = "cocktail 7", description = "descri 7 " });
            collection.Insert(new Cocktails.DefaultCocktail() { name = "cocktail 8", description = "descri 8 " });

        }

        public ICocktail AddCocktail(ICocktail cocktail)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
