using System;
using System.Collections.Generic;
using System.Text;

namespace AppCausati.Models
{
    public class Cart
    {
        public int Image { get; set; }
        public int Id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }

        public string Price { get; set; }
        public string Quantity { get; set; }

        public DateTime CreationDate  { get; set; }
    }
}
