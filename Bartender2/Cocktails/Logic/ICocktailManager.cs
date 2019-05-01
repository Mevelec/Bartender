using System;
using System.Collections.Generic;
using System.Text;

namespace Cocktails.Logic
{
    public interface ICocktailManager
    {
        /// <summary>
        /// Get all the cocktails
        /// </summary>
        /// <returns>List<Logic.ICocktail></returns>
        List<Logic.ICocktail> GetCocktails();

        /// <summary>
        /// Add a cocktail using a ICocktail Object as model
        /// </summary>
        /// <param name="cocktail"></param>
        /// <returns></returns>
        ICocktail AddCocktail(ICocktail cocktail);

        /// <summary>
        /// Delete a Cocktail by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteCocktail(int id);

        /// <summary>
        /// Update a cocktail using a ICocktail as Model
        /// </summary>
        /// <param name="cocktail"></param>
        /// <returns></returns>
        ICocktail UpdateCocktail(ICocktail cocktail);
    }
}
