using System;
using System.Collections.Generic;
using System.Text;

namespace AppCausati.Models
{
    public class Product
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public int IdCategory { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public bool Isfavourite { get; internal set; }
    }
}
