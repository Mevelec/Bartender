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
    public partial class IngLiquid : UserControl
    {
        private Cocktails.Logic.IIngredientsManager ingredientsManager = Cocktails.CocktailsFacade.Instance.GetIngredientManager(Cocktails.ManagersTypes.LiteDB);
        private List<object> listeners = new List<object>();
        public IngLiquid()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Cocktails.Logic.ILiquid item = ingredientsManager.CreateIngredient(Cocktails.IngredientsTypes.Liquid) as Cocktails.Logic.ILiquid;
            item.name = this.TextBoxName.Text;
            item.description = this.TextBoxDescription.Text;
            item.nutritionalValue = float.Parse(this.TextBoxNutritionalValue.Text);
            ingredientsManager.AddIngredient(item);
        }
    }
}
