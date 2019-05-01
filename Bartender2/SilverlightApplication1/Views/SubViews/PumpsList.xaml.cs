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
using Pumps;

namespace Bartender2.Views.SubViews
{

    /// <summary>
    /// Interaction logic for PumpsList.xaml
    /// </summary>
    public partial class PumpsList : UserControl
    {
        private Pumps.Logic.IPumpManager pumpsManager = PumpFacade.Instance.GetPumpManager();

        public PumpsList()
        {
            this.InitializeComponent();
            this.pumpsList.ItemsSource = pumpsManager.GetPumps();
        }

        /** EVENTS HANDLERS **/
        private void PumpsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = this.pumpsList.SelectedItem as Pumps.Logic.IPump;

            if (item != null)
            {
                this.TxtName.Text = item.name;
                this.TxtDescription.Text = item.description;
                this.TxtPin.Text = item.pin;
            }
        }

        private void Pump_Edit(object sender, RoutedEventArgs e)
        {
            var item = pumpsList.SelectedItem as Pumps.Logic.IPump;

            if (item != null)
            {
                item.name = this.TxtName.Text;
                item.description = this.TxtDescription.Text;
                item.pin = this.TxtPin.Text;

                pumpsManager.UpdatePump(item);
            }
            this.RefreshList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var item = pumpsList.SelectedItem as Pumps.Logic.IPump;

            if (item != null)
            {
                pumpsManager.DeletePump(item.id);
            }
            this.RefreshList();
        }

        /** UTYLS **/
        private void RefreshList()
        {
            this.pumpsList.ItemsSource = pumpsManager.GetPumps();
        }
    }
}
