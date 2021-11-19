using System;
using System.Collections.Generic;
using System.Text;

namespace AppCausati.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Total { get; set; }

    }
}
