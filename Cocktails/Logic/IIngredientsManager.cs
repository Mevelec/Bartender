using System;
using System.Collections.Generic;
using System.Text;

namespace Cocktails.Logic
{
    public interface IIngredientsManager
    {
        /// <summary>
        /// Get all the Ingredient
        /// </summary>
        /// <returns>List<Logic.IIngredient></returns>
        List<Logic.IIngredient> GetIngredients();

        /// <summary>
        /// Add a Ingredient using a IIngredient Object as model
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns></returns>
        IIngredient AddIngredient(IIngredient ingredient);

        /// <summary>
        /// Create a ingredient of type IngredientsTypes type
        /// Need to save after creation 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IIngredient CreateIngredient(IngredientsTypes type);

        /// <summary>
        /// Delete a Ingredient by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteIngredient(int id);

        /// <summary>
        /// Update a Ingredient using a IIngredient as Model
        /// </summary>
        /// <param name="ingredient"></param>
        /// <returns></returns>
        IIngredient UpdateIngredient(IIngredient ingredient);


    }
}
