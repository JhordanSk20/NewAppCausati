using AppCausati.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppCausati.Services
{
    class ApiServiceFirebase
    {
        public static async Task<bool> RegistrarUsuario(User oUsuario, ResponseAuthentication oResponse)
        {
            try
            {

                HttpClient client = new HttpClient();
                var body = JsonConvert.SerializeObject(oUsuario);
                var content = new StringContent(body, Encoding.UTF8, "application/json");
                var formatoapi = string.Concat(AppSettings.ApiFirebase, "{0}/{1}.json?auth={2}");

                var response = await client.PutAsync(
                    string.Format(formatoapi, "usuarios", oResponse.LocalId, oResponse.IdToken),
                    content);
                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                string t = ex.Message;
                return false;
            }

        }

        internal static Task<List<Cart>> ObtenerCompra()
        {
            throw new NotImplementedException();
        }

        public static async Task<Dictionary<string, Category>> ObtenerCategorias()
        {
            Dictionary<string, Category> oObject = new Dictionary<string, Category>();
            try
            {
                HttpClient client = new HttpClient();
                string apiurlformat = string.Concat(AppSettings.ApiFirebase, "dbalmacen/categoria.json?auth={0}");
                var response = await client.GetAsync(string.Format(apiurlformat, AppSettings.oAuthentication.IdToken));
                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();

                    if (jsonstring != "null")
                    {
                        oObject = JsonConvert.DeserializeObject<Dictionary<string, Category>>(jsonstring);
                    }
                    return oObject;
                }
                else
                {
                    return oObject;
                }
            }
            catch (Exception ex)
            {
                string t = ex.Message;
                return oObject;
            }

        }

        public static async Task<Dictionary<string, Product>> ObtenerProductos(string nombreCategoria)
        {
            Dictionary<string, Product> oObject = new Dictionary<string, Product>();
            try
            {
                HttpClient client = new HttpClient();
                string apiurlformat = string.Concat(AppSettings.ApiFirebase, "dbalmacen/categoria/{0}/productos.json?auth={1}");
                var response = await client.GetAsync(string.Format(apiurlformat, nombreCategoria, AppSettings.oAuthentication.IdToken));
                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();

                    if (jsonstring != "null")
                    {
                        oObject = JsonConvert.DeserializeObject<Dictionary<string, Product>>(jsonstring);
                    }
                    return oObject;
                }
                else
                {
                    oObject = null;
                    return oObject;
                }
            }
            catch (Exception ex)
            {
                string t = ex.Message;
                oObject = null;
                return oObject;
            }

        }

        public static async Task<User> ObtenerUsuario()
        {
            User oObject = new User();
            try
            {
                HttpClient client = new HttpClient();
                string apiformat = string.Concat(AppSettings.ApiFirebase, "usuarios/{0}.json?auth={1}");
                var response = await client.GetAsync(string.Format(apiformat, AppSettings.oAuthentication.LocalId, AppSettings.oAuthentication.IdToken));
                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    var jsonstring = await response.Content.ReadAsStringAsync();

                    if (jsonstring != "null")
                    {
                        oObject = JsonConvert.DeserializeObject<User>(jsonstring);
                    }
                    return oObject;
                }
                else
                {
                    return oObject;
                }
            }
            catch (Exception ex)
            {
                string t = ex.Message;
                return oObject;
            }

        }

        public static async Task<bool> GuardarCambiosUsuario(User oUsuario)
        {
            User oObject = new User();
            try
            {
                HttpClient client = new HttpClient();
                var body = JsonConvert.SerializeObject(oUsuario);
                var content = new StringContent(body, Encoding.UTF8, "application/json");


                string apiformat = string.Concat(AppSettings.ApiFirebase, "usuarios/{0}.json?auth={1}");
                var response = await client.PutAsync(string.Format(apiformat, AppSettings.oAuthentication.LocalId, AppSettings.oAuthentication.IdToken), content);
                if (response.StatusCode.Equals(HttpStatusCode.OK))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                string t = ex.Message;
                return false;
            }

        }

        
      
       

       
       


       
    }
}
