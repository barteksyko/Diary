using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;
using WpfApp1.Properties;

namespace WpfApp1.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        private UserSettings _userSettings;

        public SettingsViewModel()
        {
            CloseCommand = new RelayCommand(Close);
            ConfirmCommand = new RelayCommand(Confirm);
            _userSettings = new UserSettings();
        }

        public ICommand CloseCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }
        public UserSettings UserSettings
        {
            get
            {
                return _userSettings;
            }
            set
            {
                _userSettings = value;
                OnPropertyChanged();
            }
        }
        private void Confirm(object obj)
        {
            if (!UserSettings.IsValid)
            {
                return;
            }

            UserSettings.Save();
            RestartApplication();
        }

        private void RestartApplication()
        {
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Close(object obj)
        {
            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }
    }
}
