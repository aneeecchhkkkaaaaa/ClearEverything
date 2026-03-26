using ClearEverythingV2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClearEverythingV2.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private UserModel _user;

        public string Name
        {
            get => _user.Name;
            set
            {
                _user.Name = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _user.Email;
            set
            {
                _user.Email = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get => _user.Phone;
            set
            {
                _user.Phone = value;
                OnPropertyChanged();
            }
        }

        public ICommand ClearCommand { get; }

        public MainViewModel()
        {
            _user = new UserModel();
            ClearCommand = new Command(Clear);
        }

        private void Clear()
        {
            Name = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
