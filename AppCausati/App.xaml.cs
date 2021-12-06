
using AppCausati.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCausati
{
    public partial class App : Application
    {
     
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage ();

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
