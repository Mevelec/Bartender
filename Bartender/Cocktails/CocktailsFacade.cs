using System;
using System.Collections.Generic;
using System.Text;

namespace Cocktails
{
    public enum IngredientsTypes
    {
        Liquid  = 0,
        Alcohol = 1,
        Powder  = 2,
    }

    public enum ManagersTypes
    {
        LiteDB = 0,
    }

    public sealed class CocktailsFacade
    {

        private CocktailsFacade() { }

        public static CocktailsFacade Instance { get { return Nested.instance; } }

        public Logic.ICocktailManager GetCocktailManager(ManagersTypes type)
        {
            switch (type)
            {
                case ManagersTypes.LiteDB:
                    return new Managers.LiteDBCocktailManager(Settings.Settings.LITE_DB_CONNECTION);
                default:
                    throw new NotImplementedException();
            }
        }

        private class Nested
        {
            static Nested() { }

            internal static readonly CocktailsFacade instance = new CocktailsFacade();
        }
    }
}
