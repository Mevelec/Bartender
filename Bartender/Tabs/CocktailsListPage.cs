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
    }
}
