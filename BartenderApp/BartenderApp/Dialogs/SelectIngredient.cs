using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartender.Dialogs
{
    public partial class SelectIngredient : Form
    {
        private Cocktails.Logic.IIngredientsManager ingredientsManager = Cocktails.CocktailsFacade.Instance.GetIngredientManager(Cocktails.ManagersTypes.LiteDB);

        public SelectIngredient()
        {
            InitializeComponent();
            this.TopMost = true;

            this.ListIngredients.View = View.Details;
            this.ListIngredients.GridLines = true;
            this.ListIngredients.FullRowSelect = true;
            this.ListIngredients.AllowColumnReorder = true;
            this.ListIngredients.CheckBoxes = true;
            this.ListIngredients.Columns.Add("Id");
            this.ListIngredients.Columns.Add("name");
            this.ListIngredients.Columns.Add("descritpion");
            this.ListIngredients.Items.AddRange(
                this.ingredientsManager.GetIngredients().Select(
                    item =>
                    new ListViewItem(
                        new[] {
                            item.id.ToString(),
                            item.name.ToString(),
                            item.description.ToString()
                        }
                    )
                ).ToArray()
            );
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            this.ListIngredients.Items.Clear();
            this.ListIngredients.Items.AddRange(
                this.ingredientsManager.GetIngredients()
                .Where(
                    item => item.name.StartsWith(this.textBoxSearchIngredient.Text)
                )
                .Select(
                    item =>
                    new ListViewItem(
                        new[] {
                            item.id.ToString(),
                            item.name.ToString(),
                            item.description.ToString()
                        }
                    )
                ).ToArray()
            );

        }
        private void ListIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearchIngredient_KeyUp(object sender, KeyEventArgs e)
        {
            this.searchBox_TextChanged(sender, e);
        }

        private void textBoxQtyChanged(object sender, KeyEventArgs e)
        {
            if(this.textBoxQty.Text.Length > 0)
            {
                this.btnAddIngredient.Enabled = true;
            }
            else
            {
                this.btnAddIngredient.Enabled = false;
            }
        }

        public ListViewItem lastItemChecked;
        public float qty;
        public int selectedId;
        private void ListIngredients_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // if we have the lastItem set as checked, and it is different
            // item than the one that fired the event, uncheck it
            if (lastItemChecked != null && lastItemChecked.Checked
                && lastItemChecked != this.ListIngredients.Items[e.Index])
            {
                // uncheck the last item and store the new one
                lastItemChecked.Checked = false;
            }

            // store current item
            lastItemChecked = this.ListIngredients.Items[e.Index];
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            if(this.textBoxQty.Text.Length > 0 &&
                lastItemChecked != null)
            {
                this.qty = float.Parse(this.textBoxQty.Text);
                this.selectedId = Int32.Parse(this.lastItemChecked.SubItems[0].Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
