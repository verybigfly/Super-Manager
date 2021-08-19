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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using ControlzEx.Theming;
using MahApps.Metro.IconPacks;
using System.Collections.ObjectModel;

namespace Super_Manager
{
    /// <summary>
    /// Logique d'interaction pour ConnectScreen.xaml
    /// </summary>
    public partial class ConnectScreen : MetroWindow
    {
        public ConnectScreen()
        {
            InitializeComponent();
            ThemeManager.Current.ThemeSyncMode = ThemeSyncMode.SyncWithAppMode;
            ThemeManager.Current.SyncTheme();
        }

        private void ConnectBtn_Click(object sender, RoutedEventArgs e)
        {
            ProgressDialog progressDialog = new ProgressDialog();
            progressDialog.ShowDialog();

        }

        private void BrowseBtn_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = openFileDlg.ShowDialog();
            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock
            if (result == true)
            {
                CertifPath.Text = openFileDlg.FileName;
            }
        }
    }
}
