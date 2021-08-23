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
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Security;
using System.Collections.ObjectModel;

namespace Super_Manager
{
    /// <summary>
    /// Logique d'interaction pour ProgressDialog.xaml
    /// </summary>
    public partial class ProgressDialog : MetroWindow
    {
        public static readonly ConnectScreen _connectScreen;
        public ProgressDialog()
        {
            InitializeComponent();
        }
        static void connect(ConnectScreen connectScreen)
        {
            string userName = connectScreen.PsUserName.Text;
            string password = connectScreen.PsPassword.Password;
            var securestring = new SecureString();
            foreach (Char c in password)
            {
                securestring.AppendChar(c);
            }
            PSCredential creds = new PSCredential(userName, securestring);
            WSManConnectionInfo connectionInfo = new WSManConnectionInfo
            {
                AuthenticationMechanism = AuthenticationMechanism.Negotiate,
                ComputerName = connectScreen.PsIp.Text,
                Credential = creds,
                Scheme = "https"
            };
            Runspace runspace = RunspaceFactory.CreateRunspace(connectionInfo);
            runspace.Open();
            using (PowerShell ps = PowerShell.Create())
            {
                ps.Runspace = runspace;
                ps.AddCommand("(Get-CimInstance Win32_PhysicalMemory | Measure-Object -Property capacity -Sum).sum /1gb");
                ps.Invoke();
                Collection<PSObject> result = ps.Invoke();

            };
        }
    }
}
