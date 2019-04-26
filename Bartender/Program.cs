using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bartender2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application a = new Application();
            a.StartupUri = new Uri("./App/Views/MainWindow.xaml", System.UriKind.Relative);
            a.Run();
        }
    }
}
