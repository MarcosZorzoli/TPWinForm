using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using System.Windows.Forms.VisualStyles;
using dominio;
namespace negocio
{
    public class NegocioArticulo
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta("Select A.Id, Codigo, Nombre,Descripcion,IdMarca,IdCategoria,Precio, ImagenUrl  from ARTICULOS A, IMAGENES I  WHERE A.Id=I.IdArticulo");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = datos.Lector.GetInt32(0);
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.IdMarca = datos.Lector.GetInt32(4);
                    aux.IdCategoria = datos.Lector.GetInt32(5);
                    aux.Precio = datos.Lector.GetDecimal(6);
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    if (lista.Count == 0)
                    {
                        lista.Add(aux);

                    }
                    else

                    if (lista.Last().Id == aux.Id)
                    {

                        lista.Remove(aux);
                    }
                    else
                    {
                        lista.Add(aux);
                    }


                }


                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public List<Articulo> ListarXNombre(string nombre)
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=Tobi\\SQLEXPRESST; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select A.Id, Codigo, Nombre,Descripcion,IdMarca,IdCategoria,Precio, ImagenUrl  from ARTICULOS A, IMAGENES I  WHERE A.Id=I.IdArticulo and A.Nombre=nombre";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    string nnombre = (string)lector["Nombre"];
                    if (nnombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) > -1)
                    {
                        aux.Id = lector.GetInt32(0);
                        aux.Codigo = (string)lector["Codigo"];
                        aux.Nombre = (string)lector["Nombre"];
                        aux.Descripcion = (string)lector["Descripcion"];
                        aux.IdMarca = lector.GetInt32(4);
                        aux.IdCategoria = lector.GetInt32(5);
                        aux.Precio = lector.GetDecimal(6);
                        aux.UrlImagen = (string)lector["ImagenUrl"];
                        if (lista.Count == 0)
                        {
                            lista.Add(aux);
                        }
                        else

                    if (lista.Last().Id == aux.Id)
                        {

                            lista.Remove(aux);
                        }
                        else
                        {
                            lista.Add(aux);
                        }
                    }

                }
                conexion.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<Articulo> ListarXMarca(int id)
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=Tobi\\SQLEXPRESST; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select A.Id, Codigo, Nombre,Descripcion,IdMarca,IdCategoria,Precio, ImagenUrl  from ARTICULOS A, IMAGENES I  WHERE A.Id=I.IdArticulo and A.Nombre=nombre";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    id = lector.GetInt32(0);
                    if (id == aux.IdMarca)
                    {
                        aux.Id = lector.GetInt32(0);
                        aux.Codigo = (string)lector["Codigo"];
                        aux.Nombre = (string)lector["Nombre"];
                        aux.Descripcion = (string)lector["Descripcion"];
                        aux.IdMarca = lector.GetInt32(4);
                        aux.IdCategoria = lector.GetInt32(5);
                        aux.Precio = lector.GetDecimal(6);
                        aux.UrlImagen = (string)lector["ImagenUrl"];
                        if (lista.Count == 0)
                        {
                            lista.Add(aux);

                        }
                        else

                    if (lista.Last().Id == aux.Id)
                        {

                            lista.Remove(aux);
                        }
                        else
                        {
                            lista.Add(aux);
                        }
                    }


                }
                conexion.Close();
                return lista;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void EiminarArticulo(ref Articulo target, ref List<Articulo> listaActual)
        {
            List<Articulo> aux = new List<Articulo>();
            int contador = 0;
            for (int i = 0; i < listaActual.Count; i++)
            {
                if (listaActual[i] != target)
                {
                    contador++;
                    aux.Add(listaActual[i]);

                }
            }
            listaActual = aux;

        }
        public void AgregarArticulo(ref Articulo target, ref List<Articulo> listaActual)
        {
            List<Articulo> aux = new List<Articulo>();

            for (int i = 0; i < listaActual.Count; i++)
            {
                aux.Add(listaActual[i]);

            }

            aux.Add(target);
            listaActual = aux;

        }


    }
}
