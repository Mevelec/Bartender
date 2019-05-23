using System;
using System.Collections.Generic;
using System.Text;
using Cocktails.Logic;
using System.Linq;
using LiteDB;


namespace Cocktails.Managers
{
    class LiteDBIngredientManager : Logic.IIngredientsManager
    {
        protected LiteDatabase db;
        private string ingredientsTableName = "ingredients";

        public LiteDBIngredientManager(String dbLink)
        {
            this.db = new LiteDatabase(dbLink);
            var collection = this.db.GetCollection<IIngredient>(this.ingredientsTableName);
            collection.Delete(x => x != null);
            collection.Insert(new Ingredients.IngLiquid() { name = "cocktail 1", description = "descri 1 " });
            collection.Insert(new Ingredients.IngLiquid() { name = "cocktail 2", description = "descri 2 " });
            collection.Insert(new Ingredients.IngLiquid() { name = "cocktail 3", description = "descri 3 " });
            collection.Insert(new Ingredients.IngLiquid() { name = "cocktail 4", description = "descri 4 " });

        }

        public IIngredient AddIngredient(IIngredient ingredient)
        {
            // todo : correct implementation, must return object with correct id 
            // and use table aggregation if needed
            var collection = this.db.GetCollection<IIngredient>(this.ingredientsTableName);
            switch (ingredient.type)
            {
                case IngredientsTypes.Liquid:
                    collection.Insert(new Ingredients.IngLiquid()
                    {
                        name = ingredient.name,
                        description = ingredient.description,
                        nutritionalValue = ingredient.nutritionalValue,
                    }
                    );
                    return ingredient;
                case IngredientsTypes.Alcohol:
                    Logic.IAlcohol temp = (Ingredients.IngAlcohol)ingredient;
                    ingredient = (Logic.IAlcohol)ingredient;
                    collection.Insert(new Ingredients.IngAlcohol()
                    {
                        name = ingredient.name,
                        description = ingredient.description,
                        nutritionalValue = ingredient.nutritionalValue,
                        alcoholDegree = temp.alcoholDegree,
                    }
                    );
                    return ingredient;
                default:
                    throw new NotImplementedException();
            }
        }

        public IIngredient CreateIngredient(IngredientsTypes type)
        {
            switch (type)
            {
                case IngredientsTypes.Liquid:
                    return new Ingredients.IngLiquid();
                case IngredientsTypes.Alcohol:
                    return new Ingredients.IngAlcohol();
                default:
                    throw new NotImplementedException();
            }
        }

        public bool DeleteIngredient(int id)
        {
            throw new NotImplementedException();
        }

        public List<IIngredient> GetIngredients()
        {
            return this.db.GetCollection<IIngredient>(this.ingredientsTableName).FindAll().ToList();
        }

        public IIngredient UpdateIngredient(IIngredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
