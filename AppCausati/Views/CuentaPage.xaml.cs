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
    public partial class CuentaPage : ContentPage
    {
        public CuentaPage()
        {
            InitializeComponent();
            obtenerUsuario();
        }
        User oGlobalUsuario;

        private async void BtnGuardarCambios_Clicked(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtDocumento.Text.Trim() == "")
            {
                await DisplayAlert("Mensaje", "Debe completar todos los campos", "OK");
                return;
            }


            User oUsuario = new User()
            {
                Name = txtNombre.Text,
                Password = oGlobalUsuario.Password,
                Email = oGlobalUsuario.Email
            };

            bool respuesta = await ApiServiceFirebase.GuardarCambiosUsuario(oUsuario);

            if (respuesta)
            {
                await DisplayAlert("Mensaje", "Se guardaron los cambios", "OK");
            }
            else
            {
                await DisplayAlert("Mensaje", "Hubo un error al guardar", "OK");
            }

        }

        private async void obtenerUsuario()
        {

            oGlobalUsuario = await ApiServiceFirebase.ObtenerUsuario();

            if (oGlobalUsuario != null)
            {
                txtNombre.Text = oGlobalUsuario.Name;
                txtEmail.Text = oGlobalUsuario.Email;

            }
        }

        private void BtnCerrarSesion_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }
    }
}