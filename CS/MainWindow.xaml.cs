using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Docking;
using System.Collections.ObjectModel;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            vm = mainGrid.Resources["viewModel"] as MainViewModel;
            ahvm = vm.ChildViews[7] as AutoHideViewModel; 
        }
        MainViewModel vm;
        AutoHideViewModel ahvm;

        private void Button_Click(object sender, RoutedEventArgs e) {
            vm.ChildViews.Remove(ahvm);
            (ahvm).MyTargetName = "DockPanels";
            vm.ChildViews.Add(ahvm);            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            vm.ChildViews.Remove(ahvm);
            (ahvm).MyTargetName = "auotHideGroup";
            vm.ChildViews.Add(ahvm);

        }

    }
}