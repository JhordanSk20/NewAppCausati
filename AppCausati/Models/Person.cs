using SQLite;
using System;


namespace AppCausati.Models
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int PersonID { get; set; }

        [MaxLength(30)]
        public string NameField { get; set; }

        
    }
}
