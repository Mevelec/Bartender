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

        public CocktailsListPage()
        {
            InitializeComponent();
            this.refreshData();
            this.ListBoxCocktails.DisplayMember = "name";
            this.ListBoxCocktails.ValueMember = "id";

            this.ListIngredients.View = View.Details;
            this.ListIngredients.GridLines = true;
            this.ListIngredients.FullRowSelect = true;
            this.ListIngredients.AllowColumnReorder = true;
            this.ListIngredients.CheckBoxes = true;
            this.ListIngredients.Columns.Add("Id");
            this.ListIngredients.Columns.Add("name");
            this.ListIngredients.Columns.Add("descritpion");
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
            }
        }

        private void BtnAddIngredient_Click(object sender, EventArgs e)
        {
            using (Dialogs.SelectIngredient dialogWindow = new Dialogs.SelectIngredient())
            {
                if (dialogWindow.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.ListIngredients.Items.Add(
                            new ListViewItem(dialogWindow.lastItemChecked.Clone().ToString().Split(','), 0)
                            );
                }
            }
        }
    }
}
