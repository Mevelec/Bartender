using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Settings;

namespace Cocktails
{
    class CocktailsManager
    {
        public static CocktailsManager Instance { get { return Singleton.instance; } }

        private class Singleton
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Singleton()
            {
                
            }

            internal static readonly CocktailsManager instance = new CocktailsManager();
        }

        public void generateCocktailList()
        {
            using (var db = new LiteDatabase(Settings.Settings.LITE_DB_CONNECTION))
            {
                var items = db.GetCollection<Cocktails.Cocktail>("Cocktail"); //get collection of products

                for(int i = 0; i < 10; i++)
                {
                    var tmp = new Cocktails.Cocktail //create
                    {
                        name = "margerita",
                        description = "rum and orange"
                    };
                    items.Insert(tmp); //insert
                }
            }
        }
    }
}
