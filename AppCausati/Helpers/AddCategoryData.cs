using AppCausati.Models;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCausati.Helpers
{
    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }
        FirebaseClient client;
        public AddCategoryData()
        {

        }
    }
}
