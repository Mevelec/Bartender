using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartender.Forms
{
    public partial class IngAlcohol : UserControl
    {
        private Cocktails.Logic.IIngredientsManager ingredientsManager = Cocktails.CocktailsFacade.Instance.GetIngredientManager(Cocktails.ManagersTypes.LiteDB);
        private List<object> listeners = new List<object>();
        public IngAlcohol()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Cocktails.Logic.IAlcohol item = ingredientsManager.CreateIngredient(Cocktails.IngredientsTypes.Alcohol) as Cocktails.Logic.IAlcohol;
            item.name = this.TextBoxName.Text;
            item.description = this.TextBoxDescription.Text;
            item.nutritionalValue = float.Parse(this.TextBoxNutritionalValue.Text);
            item.alcoholDegree = float.Parse(this.TexBoxAlcoholDegree.Text);
            ingredientsManager.AddIngredient(item);

            this.TextBoxName.Text = "";
            this.TextBoxDescription.Text = "";
            this.TexBoxAlcoholDegree.Text = "";
            this.TextBoxNutritionalValue.Text = "";
        }
    }
}
