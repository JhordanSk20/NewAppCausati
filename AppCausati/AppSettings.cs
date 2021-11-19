using AppCausati.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCausati
{
    class AppSettings
    {
        public static string ApiFirebase = "https://causatiproject-default-rtdb.firebaseio.com/";
        private static string KeyAplication = "AIzaSyD2fSTwG-1xN3kbmzW3iVpI--4WTZ2XcPk";

        public static ResponseAuthentication oAuthentication { get; set; }
        private static string ApiUrlGoogleApis = "https://identitytoolkit.googleapis.com/v1/" ;

        public static string ApiAuthentication(string tipo)
        {
            if (tipo == "LOGIN")
                return ApiUrlGoogleApis = "accounts:SignInWithPassword?Key=" + KeyAplication;
            else if (tipo == "SIGNIN")
                    return ApiUrlGoogleApis = "accounts:signUp?Key=" + KeyAplication;
            else
                return "";
        }
    }
}
