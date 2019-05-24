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

        private CocktailsFacade() { }

        public static CocktailsFacade Instance { get { return Nested.instance; } }

        private Dictionary<ManagersTypes, Logic.ICocktailManager> cocktailManagers = new Dictionary<ManagersTypes, Logic.ICocktailManager>();
        private Dictionary<ManagersTypes, Logic.IIngredientsManager> ingredientManagers = new Dictionary<ManagersTypes, Logic.IIngredientsManager>();

        public Logic.ICocktailManager GetCocktailManager(ManagersTypes type)
        {
            if(!cocktailManagers.ContainsKey(type))
            {
                switch (type)
                {
                    case ManagersTypes.LiteDB:
                        cocktailManagers.Add( 
                            type,
                            new Managers.LiteDBCocktailManager(Settings.Settings.LITE_DB_CONNECTION)
                        );
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            return cocktailManagers[type];
        }

        public Logic.IIngredientsManager GetIngredientManager(ManagersTypes type)
        {
            if(!ingredientManagers.ContainsKey(type))
            {
                switch (type)
                {
                    case ManagersTypes.LiteDB:
                         ingredientManagers.Add(
                             type,
                             new Managers.LiteDBIngredientManager(Settings.Settings.LITE_DB_CONNECTION)
                           );
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            return ingredientManagers[type];
        }

        private class Nested
        {
            static Nested() { }

            internal static readonly CocktailsFacade instance = new CocktailsFacade();
        }
    }
}
