using AppCausati.Models;
using AppCausati.Services;
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

        }
        private async void ir_register(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegisterPage());
        }
        private async void BtnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Trim().Equals("") || txtEmail.Text.Trim().Equals(""))
            {
                await DisplayAlert("Oops", "Ingrese todos los datos", "Aceptar");
                return;
            }

            UserAuthentication oUsuario = new UserAuthentication()
            {
                email = txtEmail.Text,
                password = txtContrasena.Text,
                returnSecureToken = true
            };

            bool respuesta = await ApiServiceAuthentication.Login(oUsuario);
            if (respuesta)
            {
                //Application.Current.MainPage = new NavigationPage(new MasterPage());
                //Application.Current.MainPage = new MasterPage();
                Application.Current.MainPage = new HomePage();
            }
            else
            {
                await DisplayAlert("Oops", "Usuario no encontrado", "OK");
            }
        }

        

    }
}