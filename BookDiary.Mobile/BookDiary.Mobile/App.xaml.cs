using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BookDiary.Mobile.Services;
using BookDiary.Mobile.Views;
using BookDiary.Mobile.Views.Login;

namespace BookDiary.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
