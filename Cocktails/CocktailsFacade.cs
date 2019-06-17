using System;
using System.Collections.Generic;
using System.Text;

namespace Cocktails
{
    public enum ManagersTypes
    {
        LiteDB = 0,
    }

    public sealed class CocktailsFacade
    {

        public static CocktailsFacade Instance { get { return Nested.instance; } }

        private Logic.ICocktailManager cocktailManager;
        private Logic.IIngredientsManager ingredientManager;

        private CocktailsFacade(ManagersTypes type)
        {
            switch (type)
            {
                case ManagersTypes.LiteDB:
                    cocktailManager = new Managers.LiteDBCocktailManager(Settings.Settings.LITE_DB_CONNECTION);
                    ingredientManager = new Managers.LiteDBIngredientManager(Settings.Settings.LITE_DB_CONNECTION);

                    Logic.IIngredient ingredient1 = new Ingredients.IngLiquid()
                    { id = 1, name = "Ing 1", description = "test me" };
                    ingredientManager.AddIngredient(ingredient1);
                    

                    cocktailManager.AddCocktail(new Cocktails.DefaultCocktail() { name = "cocktail 1", description = "descri 1 " });
                    cocktailManager.AddCocktail(new Cocktails.DefaultCocktail() { name = "cocktail 2", description = "descri 2 " });
                    cocktailManager.AddCocktail(new Cocktails.DefaultCocktail() { name = "cocktail 3", description = "descri 3 " });
                    cocktailManager.AddCocktail(new Cocktails.DefaultCocktail() {
                        name = "cocktail 4",
                        description = "descri 4 "
                    });

                    Logic.ICocktail cocktail1 = new Cocktails.DefaultCocktail()
                    {
                        name = "Manza 8",
                        description = "descri 8 ",
                    };
                    cocktail1.addIngredient(ingredient1, 100);
                    cocktailManager.AddCocktail(cocktail1);

                    var a = cocktailManager.GetCocktails();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public Logic.ICocktailManager GetCocktailManager()
        {
            return this.cocktailManager;
        }

        public Logic.IIngredientsManager GetIngredientManager()
        {
            return this.ingredientManager;
        }

        private class Nested
        {
            static Nested() { }

            internal static readonly CocktailsFacade instance = new CocktailsFacade(
                (ManagersTypes)Enum.Parse(typeof(ManagersTypes), "LiteDB")
            );
        }
    }
}
