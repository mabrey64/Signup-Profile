namespace Signup_Profile
{
    public partial class AppShell : Shell
    {
        // Added the constructor to initialize the AppShell and register routes for the pages created within this project.
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("profilepage", typeof(Profilepage));
            Routing.RegisterRoute("signup", typeof(Signup));
        }
    }
}
