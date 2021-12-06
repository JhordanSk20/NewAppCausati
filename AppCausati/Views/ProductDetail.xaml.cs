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
    public partial class ProductDetail : ContentPage
    {

        public ProductDetail(string id, string nombre, string imagen, string precio)
        {
            InitializeComponent();
            BindingContext = new ProductDetailViewModel();

            txtimage.Source = imagen;

        }

        private async void return_home(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HomePage());
        }
    }
}