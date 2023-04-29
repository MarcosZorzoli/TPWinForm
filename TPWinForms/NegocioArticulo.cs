using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TPWinForms
{
    public class NegocioArticulo
    {
        public List<Articulo> Listar()
        {
			List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            

            try
			{
                conexion.ConnectionString = "server=DESKTOP-E8MHNDC\\SQLLAB3; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Codigo, Nombre,Descripcion,IdMarca,IdCategoria,Precio from ARTICULOS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = lector.GetInt32(0);
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.IdMarca = lector.GetInt32(4);
                    aux.IdCategoria = lector.GetInt32(5);
                    aux.Precio = lector.GetDecimal(6);

                    lista.Add(aux);


                }
                conexion.Close();
                return lista;
            }
			catch (Exception)
			{

				throw;
			}

        }
    }
}
