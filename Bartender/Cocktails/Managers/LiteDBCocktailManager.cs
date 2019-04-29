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
