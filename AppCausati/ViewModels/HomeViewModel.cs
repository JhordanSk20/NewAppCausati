using AppCausati.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppCausati.ViewModels
{
     public class HomeViewModel
    {
        public ObservableCollection<OfertaExclusiva> ofertaExclusiva { get; set; }
        public ObservableCollection<MasVendido> masvendido { get; set; }

        public HomeViewModel()
        {
            ofertaExclusiva = new ObservableCollection<OfertaExclusiva>
            {
                new OfertaExclusiva
                {
                    Name = "Casual T-shirt",
                    Price = "$150.00",
                    Image = "LaptopInicio.jpg"
                },
                new OfertaExclusiva
                {
                    Name = "Casual T-shirt",
                    Price = "$150.00",
                    Image = "LaptopInicio.jpg"
                },
                new OfertaExclusiva
                {
                    Name = "Casual T-shirt",
                    Price = "$150.00",
                    Image = "polera.jpg"
                },
            };

            masvendido = new ObservableCollection<MasVendido>
            {
                new MasVendido
                {
                    Name = "Casual Dress",
                     Price = "$150.00",
                    Image = "user.png"
                }

            };
        }
    }
}
