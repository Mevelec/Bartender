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
    public partial class CocktailsListPage : UserControl
    {
        private Cocktails.Logic.ICocktailManager cocktailsManager = Cocktails.CocktailsFacade.Instance.GetCocktailManager(Cocktails.ManagersTypes.LiteDB);
        private Cocktails.Logic.IIngredientsManager ingredientsManager = Cocktails.CocktailsFacade.Instance.GetIngredientManager(Cocktails.ManagersTypes.LiteDB);

        public CocktailsListPage()
        {
            InitializeComponent();
            this.refreshData();

            this.ListBoxCocktails.DisplayMember = "name";

            this.ListIngredients.View = View.Details;
            this.ListIngredients.GridLines = true;
            this.ListIngredients.FullRowSelect = true;
            this.ListIngredients.AllowColumnReorder = true;
            this.ListIngredients.CheckBoxes = true;
            this.ListIngredients.Columns.Add("Id");
            this.ListIngredients.Columns.Add("name");
            this.ListIngredients.Columns.Add("descritpion");
            this.ListIngredients.Columns.Add("Qty");
        }

        public void refreshData()
        {
            this.ListBoxCocktails.DataSource = this.cocktailsManager.GetCocktails();
        }

        private void ListBoxCocktails_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cocktails.Logic.ICocktail item = this.ListBoxCocktails.SelectedItem as Cocktails.Logic.ICocktail;
            if (item != null)
            {
                this.TextBoxName.Text = item.name;
                this.TextBoxDescription.Text = item.description;
                this.TextBoxVolume.Text = item.volume.ToString();
                this.TextBoxAlcoholDegree.Text = item.alcoholDegree.ToString();
                this.updateIngredientList();
            }
        }

        private void BtnAddIngredient_Click(object sender, EventArgs e)
        {
            using (Dialogs.SelectIngredient dialogWindow = new Dialogs.SelectIngredient())
            {
                if (dialogWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Cocktails.Logic.ICocktail cocktail = this.ListBoxCocktails.SelectedItem as Cocktails.Logic.ICocktail;
                    Cocktails.Logic.IIngredient ingredient = ingredientsManager.GetIngredient(
                            dialogWindow.selectedId);
                    cocktail.ingredients.Add(
                        ingredientsManager.GetIngredient(
                            dialogWindow.selectedId).id,
                            dialogWindow.qty
                        );
                    cocktailsManager.UpdateCocktail(cocktail);
                    this.updateIngredientList();
                }
            }
        }

        private void updateIngredientList()
        {
            Cocktails.Logic.ICocktail cocktail = this.ListBoxCocktails.SelectedItem as Cocktails.Logic.ICocktail;
            this.ListIngredients.Items.Clear();
            this.ListIngredients.Items.AddRange(
                cocktail.ingredients
                .Select(
                    item =>
                    new ListViewItem(
                        new[] {
                            item.Key.id.ToString(),
                            item.Key.name.ToString(),
                            item.Key.description.ToString(),
                            item.Value.ToString()
                        }
                    )
                ).ToArray()
            );
        }
    }
}
