using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bartender2;

namespace Bartender2.App.Views.SubViews
{

    /// <summary>
    /// Interaction logic for PumpsList.xaml
    /// </summary>
    public partial class PumpsList : UserControl
    {
        private PumpEntities.PumpsManager pumpsManager = new PumpEntities.PumpsManager();

        public PumpsList()
        {
            this.InitializeComponent();
            this.pumpsList.ItemsSource = pumpsManager.getPumps();
        }

        private void PumpsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = pumpsList.SelectedItem as PumpEntities.Pump;

            if (item != null)
            {
                this.TxtName.Text = item.name;
            }
        }

        private void Pump_Edit(object sender, RoutedEventArgs e)
        {
            var item = pumpsList.SelectedItem as PumpEntities.Pump;

            if (item != null)
            {
                item.name = this.TxtName.Text;
            }
        }
    }
}
