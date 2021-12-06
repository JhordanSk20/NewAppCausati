
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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
           
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {

        }
        

        private void ir_detail_product(object sender, SelectionChangedEventArgs e)
        {
            var c = e.CurrentSelection.First();
            Models.Product model = e.CurrentSelection.FirstOrDefault() as Models.Product;
            string id = model.Id.ToString();
            string nombre = model.Name;
            string imagen = model.Image;
            string precio = model.Price.ToString();
            Navigation.PushModalAsync(new ProductDetail (id, nombre, imagen, precio));



        }


    }
}