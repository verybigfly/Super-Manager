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
using MahApps.Metro.Controls;
using ControlzEx.Theming;
using MahApps.Metro.IconPacks;
using System.Management.Automation;
using System.Management.Automation.Runspaces;



namespace Super_Manager
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            ThemeManager.Current.ThemeSyncMode = ThemeSyncMode.SyncWithAppMode;
            ThemeManager.Current.SyncTheme();
            
        }
        private void OpenConnectScreen(object sender, RoutedEventArgs e)
        {
            ConnectScreen connectScreen = new ConnectScreen();
            connectScreen.ShowDialog();
        }
        public static class PublicData
        { 
     
        }
    }
}
