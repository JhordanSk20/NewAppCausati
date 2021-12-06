using AppCausati.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Essentials;

namespace AppCausati.ViewModels
{
    public class ProductDetailViewModel
    {
        public ObservableCollection<ProductDetail> productdetail { get; set; }
        public ProductDetailViewModel()
        {
            productdetail = new ObservableCollection<ProductDetail>
            {
                new ProductDetail
                {
                    Name = "Casual T-shirt",
                    Price = "$150.00",
                    Image = "LaptopInicio.jpg"
                },
              
            };

        }



    }
}
