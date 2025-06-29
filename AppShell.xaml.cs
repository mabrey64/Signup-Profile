namespace Signup_Profile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("profilepage", typeof(Profilepage));
        }
    }
}
