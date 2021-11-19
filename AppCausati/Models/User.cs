using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCausati.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        [MaxLength(16)]

        public string Password { get; set; }
      
    }


}

