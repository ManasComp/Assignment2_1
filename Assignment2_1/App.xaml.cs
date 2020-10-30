using System;
using Assignment2_1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment2_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new QuotesPage();
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
