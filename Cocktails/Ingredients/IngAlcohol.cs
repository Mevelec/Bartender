﻿using System;
using System.Collections.Generic;
using System.Text;
using Cocktails.Logic;

namespace Cocktails.Ingredients
{
    class IngAlcohol : Logic.IAlcohol
    {
        public float alcoholDegree { get; set; }
        public IngredientsTypes type { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public Dictionary<IIngredient, float> composition { get; set; }
        public float nutritionalValue { get; set; }

        public IngAlcohol()
        {
            this.type = IngredientsTypes.Alcohol;
        }
    }
}
