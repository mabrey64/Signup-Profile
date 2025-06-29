using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Signup_Profile
{
    [QueryProperty(nameof(Username), "Username")]
    [QueryProperty(nameof(Email), "Email")]
    public partial class Profilepage : ContentPage, INotifyPropertyChanged
    {
        private string username;
        private string email;
        public string Username
        {
            get => username;
            set { username = value; OnPropertyChanged(); }
        }

        public string Email
        {
            get => email;
            set { email = value; OnPropertyChanged(); }
        }


        public Profilepage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}