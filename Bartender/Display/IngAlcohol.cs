using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartender.Display
{
    public partial class IngAlcohol : UserControl
    {
        public IngAlcohol(Cocktails.Logic.IAlcohol item)
        {
            InitializeComponent();
            this.TextBoxName.Text = item.name;
            this.TextBoxDescription.Text = item.description;
            this.TexBoxAlcoholDegree.Text = item.alcoholDegree.ToString();
            this.TextBoxNutritionalValue.Text = item.nutritionalValue.ToString();
        }
    }
}
