using MahApps.Metro.Controls;
using System.Windows;
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : MetroWindow
    {
        public SettingsView(bool canCloseWindow) 
        {
            InitializeComponent();
            DataContext = new SettingsViewModel(canCloseWindow);
        }
    }
}
