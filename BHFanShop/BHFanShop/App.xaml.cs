using Microsoft.Extensions.DependencyInjection;

namespace BHFanShop
{

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var navPage = new NavigationPage(new Views.LoginPage());
            return new Window(navPage);
        }
        

    }
}