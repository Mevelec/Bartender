using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartender
{
    public partial class MainWindow : Form
    {
        private Forms.PumpsListPage PumpsListPage;
        private Forms.CocktailsListPage CocktailsListPage;
        private Forms.IngredientsListPage IngredientsListPage;


        public MainWindow()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            //
            // PumpsListPage
            //
            this.PumpsListPage = new Forms.PumpsListPage();
            this.PumpsListPage.Dock = System.Windows.Forms.DockStyle.Fill;
            //
            // CocktailsListPage
            //
            this.CocktailsListPage = new Forms.CocktailsListPage();
            this.CocktailsListPage.Dock = System.Windows.Forms.DockStyle.Fill;
            //
            // IngredientsListPage
            //
            this.IngredientsListPage = new Forms.IngredientsListPage();
            this.IngredientsListPage.Dock = System.Windows.Forms.DockStyle.Fill;
            //

            this.PumpsListTab.Controls.Add(this.PumpsListPage);
            this.CocktailsListTab.Controls.Add(this.CocktailsListPage);
            this.TabIngredients.Controls.Add(this.IngredientsListPage);


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
