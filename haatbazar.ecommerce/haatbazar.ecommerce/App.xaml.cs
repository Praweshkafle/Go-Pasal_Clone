using haatbazar.ecommerce.Services;
using haatbazar.ecommerce.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace haatbazar.ecommerce
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
