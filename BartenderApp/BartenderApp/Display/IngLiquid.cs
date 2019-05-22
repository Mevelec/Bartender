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
    public partial class IngLiquid : UserControl
    {
        public IngLiquid(Cocktails.Logic.ILiquid item)
        {
            InitializeComponent();
            this.TextBoxName.Text = item.name;
            this.TextBoxDescription.Text = item.description;
            this.TextBoxNutritionalValue.Text = item.nutritionalValue.ToString();
        }
    }
}
