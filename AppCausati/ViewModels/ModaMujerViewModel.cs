using AppCausati.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppCausati.ViewModels
{
    class ModaMujerViewModel
    {
        public ObservableCollection<ModaMujer> modamujer { get; set; }
        public ModaMujerViewModel()
        {
            modamujer = new ObservableCollection<ModaMujer>
            {
                new ModaMujer
                {
                    Name = "Polo Deportivo",
                    Price = "S/80.00",
                    Image = "PoloDeportivoMujer.jpg"
                },
                 new ModaMujer
                {
                    Name = "Jogger Canada",
                    Price = "S/90.00",
                    Image = "JoggerMujer.jpg"
                },
                 new ModaMujer
                {
                    Name = "Casaca Jean",
                    Price = "S/120.00",
                    Image = "CasacaJeanMujer.jpg"
                },
                  new ModaMujer
                {
                    Name = "Casaca Mujer",
                    Price = "S/150.00",
                    Image = "CasacaMujer.jpg"
                },
                    new ModaMujer
                {
                    Name = "Pantalon Mujer",
                    Price = "S/100.00",
                    Image = "PantalonMujer.jpg"
                },
                        new ModaMujer
                {
                    Name = "Polo Estampado",
                    Price = "S/90.00",
                    Image = "PoloEstampa.jpg"
                },



            };

        }
    }
}
