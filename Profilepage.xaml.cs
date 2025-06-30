using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Signup_Profile
{
    // This file is part of the Signup_Profile project.
    // It defines the Profilepage class, which is a ContentPage that displays user profile information.
    // The class implements INotifyPropertyChanged to allow for data binding and updates to the UI when properties change.
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

        // The INotifyPropertyChanged interface is implemented to notify the UI of property changes.
        // This allows the UI to update automatically when properties like Username or Email change.
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public async void OnSignout(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("signup");
        }

    }
}