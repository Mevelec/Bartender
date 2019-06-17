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
    public partial class IngredientsListPage : UserControl
    {
        private Cocktails.Logic.IIngredientsManager ingredientsManager = Cocktails.CocktailsFacade.Instance.GetIngredientManager();

        // FORMS
        private Forms.IngLiquid formIngredientLiquid;
        private Forms.IngAlcohol formIngredientAlcohol;
        //

        public IngredientsListPage()
        {
            InitializeComponent();
            this.refreshData();
            this.ListBoxIngredients.DisplayMember = "name";
            this.ListBoxIngredients.ValueMember = "id";

            //
            // Select Type
            //
            this.SelectType.DataSource = Enum.GetValues(typeof(Cocktails.IngredientsTypes)).Cast<Cocktails.IngredientsTypes>().ToList(); ;
            //

            // CREATE FORMS 
            this.formIngredientLiquid = new Forms.IngLiquid();
            this.formIngredientLiquid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formIngredientAlcohol = new Forms.IngAlcohol();
            this.formIngredientAlcohol.Dock = System.Windows.Forms.DockStyle.Fill;
            //
        }

        private void ListBoxIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cocktails.Logic.IIngredient item = this.ListBoxIngredients.SelectedItem as Cocktails.Logic.IIngredient;
            if(item != null)
            {
                this.TabInfos.Controls.Clear();
                switch (item.type)
                {
                    case Cocktails.IngredientsTypes.Alcohol:
                        var formAlcohol = new Display.IngAlcohol(item as Cocktails.Logic.IAlcohol);
                        formAlcohol.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.TabInfos.Controls.Add(formAlcohol);
                        break;

                    case Cocktails.IngredientsTypes.Liquid:
                        var formLiquid = new Display.IngLiquid(item as Cocktails.Logic.ILiquid);
                        formLiquid.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.TabInfos.Controls.Add(formLiquid);
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }
        }

        private void SelectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BoxIngredientForm.Controls.Clear();
            switch (this.SelectType.SelectedItem)
            {
                case Cocktails.IngredientsTypes.Liquid:
                    this.BoxIngredientForm.Controls.Add(this.formIngredientLiquid);
                    break;
                case Cocktails.IngredientsTypes.Alcohol:
                    this.BoxIngredientForm.Controls.Add(this.formIngredientAlcohol);
                    break;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshData();
        }

        // UTILS
        public void refreshData()
        {
            var tmp = this.ingredientsManager.GetIngredients();
            this.ListBoxIngredients.DataSource = this.ingredientsManager.GetIngredients();
        }
    }
}
