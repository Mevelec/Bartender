﻿using System;
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

namespace Bartender2.App.Views.SubViews
{
    /// <summary>
    /// Interaction logic for Parameters.xaml
    /// </summary>
    public partial class Parameters : UserControl
    {
        public Parameters()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.DataContext = new Bartender2.App.Views.SubViews.Menu();
        }

        private void Configure_Pumps(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.DataContext = new Bartender2.App.Views.SubViews.PumpsList();
        }
    }
}
