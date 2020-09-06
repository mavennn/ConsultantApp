using System;
using consultant.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace consultant
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RequestsListPage());
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
