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
                    Name = "LaptopHP",
                    Price = "S/2850.00",
                    Image = "LaptopHP.jpg"
                },
                new OfertaExclusiva
                {
                    Name = "Zapatillas DC",
                    Price = "S/250.00",
                    Image = "ZapatillasInicio.jpg"
                },
                new OfertaExclusiva
                {
                    Name = "Polera Tiger",
                    Price = "S/150.00",
                    Image = "polera.jpg"
                },
                new OfertaExclusiva
                {
                    Name = "Jacket Champion",
                    Price = "$150.00",
                    Image = "CasacaHombre.jpg"
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
