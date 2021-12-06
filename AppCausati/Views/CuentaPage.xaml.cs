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
    public partial class CuentaPage : ContentPage
    {
        public CuentaPage()
        {
            InitializeComponent();
            BindingContext = new ModaMujerViewModel();

        }

    }
}