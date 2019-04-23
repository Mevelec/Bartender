using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using LiteDB;
using Cocktails;

namespace Bartender
{
    static class Program
    {
        public static CocktailsManager cocktailsManager = Cocktails.CocktailsManager.Instance;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            cocktailsManager.generateCocktailList();
            int idCocktail = 1;
            Console.WriteLine("\n---LiteDB CRUD sample ---");
            Console.WriteLine("search id product= " + idCocktail);

            Console.WriteLine("\n--- Search\\Read ---");

            Console.WriteLine("\n--- end ---");
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
        }

        //create product
        static void Create()
        {
            using (var db = new LiteDatabase(Settings.Settings.LITE_DB_CONNECTION))
            {
                var products = db.GetCollection<Cocktails.Cocktail>("Cocktail"); //get collection of products

                var cock1 = new Cocktails.Cocktail
                {
                    name = "margerita",
                    description = "rum and orange"
                };

                //insert in db
                products.Insert(cock1);

                var cock2 = new Cocktails.Cocktail
                {
                    name = "margerita",
                    description = "rum and orange"
                };

                //insert in db
                products.Insert(cock2);

            }
        }

        //read or search
        static void Read(int Id)
        {
            using (var db = new LiteDatabase(Settings.Settings.LITE_DB_CONNECTION))
            {
                var products = db.GetCollection<Cocktails.Cocktail>("Cocktail"); //get collection

                //index document using a document property
                products.EnsureIndex(x => x.Id);

                //cound products
                int n = products.Count();
                Console.WriteLine("All Products count " + n.ToString());

                //use LINQ to query documents
                var result = products.Find(x => x.Id == Id).FirstOrDefault();

                if(result != null)
                {
                    Console.WriteLine("Product Exist : ");
                    Console.WriteLine("result");
                }
            }
        }
    }
}
