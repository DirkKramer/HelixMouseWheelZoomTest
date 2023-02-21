using HelixToolkit.SharpDX.Core;
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

namespace HelixMouseWheelZoomTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void view1_MouseMove3D(object sender, RoutedEventArgs e)
        {

        }

        private void view1_Loaded(object sender, RoutedEventArgs e)
        {
            view1.EffectsManager = new DefaultEffectsManager();
        }
    }
}
