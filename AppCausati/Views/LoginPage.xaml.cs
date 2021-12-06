using AppCausati.Models;
using AppCausati.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCausati.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();

        }
        private async void ir_register(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegisterPage());
        }
        private async void ir_Inicio(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegisterPage());
        }



    }
}