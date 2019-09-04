using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebMVC.Models
{
    public class ProductosDAL
    {
           
        IDbConnection _conn = BD_Conexion.AbrirConexion();
        // Agregar Producto
        public int AgregarProducto(ProductosEN pEN)
        {
            
            _conn.Open();
            SqlCommand comando = new SqlCommand("AgregarProd", _conn as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", pEN.Nombre);
            comando.Parameters.AddWithValue("@descripcion", pEN.Descripcion);
            comando.Parameters.AddWithValue("@precio", pEN.Precio);
            int Resultado = comando.ExecuteNonQuery();
            _conn.Close();
            return Resultado;
        }
        // Listar Produto
        public List<ProductosEN> ConsultarProd()
        {
         
            _conn.Open();
            SqlCommand comando = new SqlCommand("ConsultarProd", _conn as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            IDataReader leer = comando.ExecuteReader();
            List<ProductosEN> _lista = new List<ProductosEN>(); // Creamos una lista de produtos.
            while (leer.Read())
            {
                ProductosEN pEN = new ProductosEN();
                pEN.Id = leer.GetInt32(0);
                pEN.Nombre = leer.GetString(1);
                pEN.Descripcion = leer.GetString(2);
                pEN.Precio = leer.GetDecimal(3);
                _lista.Add(pEN);
            }
            _conn.Close();
            return _lista;
        }
    }
}