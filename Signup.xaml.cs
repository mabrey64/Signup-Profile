namespace Signup_Profile
{
    public partial class Signup : ContentPage
    {
        private Profile profile = new Profile("", "", "", "");

        public Signup()
        {
            InitializeComponent();
        }

        // Method to check if any of the fields are empty
        private bool HasEmptyFields()
        {
            return string.IsNullOrEmpty(profile.Username) ||
                   string.IsNullOrEmpty(profile.Email) ||
                   string.IsNullOrEmpty(profile.Password) ||
                   string.IsNullOrEmpty(profile.ConfirmPassword);
        }

        private bool PasswordsMatch()
        {
            return passwordEntry.Text == confirmPasswordEntry.Text;
        }

        public async void OnSignUpClicked(object sender, EventArgs e)
        {
            // Validate the input fields and update the profile object
            profile.Username = usernameEntry.Text;
            profile.Email = emailEntry.Text;
            profile.Password = passwordEntry.Text;
            profile.ConfirmPassword = confirmPasswordEntry.Text;

            // Check for empty fields and display errors
            usernameError.IsVisible = string.IsNullOrEmpty(profile.Username);
            emailError.IsVisible = string.IsNullOrEmpty(profile.Email);
            passwordError.IsVisible = string.IsNullOrEmpty(profile.Password);

            confirmPasswordError.IsVisible = string.IsNullOrEmpty(profile.ConfirmPassword) || !PasswordsMatch();

            // Check if any field is empty and display an alert. Calls a method to check for empty fields.
            if (HasEmptyFields())
            {
                await DisplayAlert("Error", "All fields are required.", "OK");
                return;
            }

            if (!PasswordsMatch())
            {
                await DisplayAlert("Error", "Passwords do not match.", "OK");
                return;
            }
            else
            {
                // If all fields are filled and passwords match, proceed with signup
                await DisplayAlert("Success", "Signup successful!", "OK");
                // Here you can add code to save the profile or navigate to another page
                await Shell.Current.GoToAsync($"profilepage?Username={profile.Username}&Email={profile.Email}");

            }
        }
    }

}
