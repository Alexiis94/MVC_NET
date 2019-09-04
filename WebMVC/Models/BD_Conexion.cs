using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class BD_Conexion
    {
        //private SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-CTJP88I\\SQLEXPRESS;Initial Catalog=BD_MVC;Integrated Security=True");
        private static string Conexion = @"Data Source=DESKTOP-CTJP88I\\SQLEXPRESS;Initial Catalog=BD_MVC;Integrated Security=True";
        public static IDbConnection AbrirConexion()
        {
            return new SqlConnection(Conexion);
        }

    }
}