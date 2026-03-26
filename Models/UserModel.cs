using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClearEverythingV2.Models
{
    internal class UserModel : INotifyPropertyChanged
    {
        private string _name;
        public string Name { get => _name; set { _name = value; OnPropertyChanged(); } }
        private string _email;
        public string Email { get => _email; set { _email = value; OnPropertyChanged(); } }

        private string _phone;
        public string Phone { get => _phone; set { _phone = value; OnPropertyChanged(); } }

        public UserModel()
        {
            this.Name = string.Empty;
            this.Email = string.Empty;
            this.Phone = string.Empty;
        }
        public UserModel(string name, string email, string phone)
        {
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
