using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticulosNegocio
    {
        private AccesoDatos datos;
        public ArticulosNegocio()
        {
            datos = new AccesoDatos();
        }

        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            try
            {
                datos.setearConsulta("select a.Id, Codigo,Nombre,a.Descripcion,m.Id IdMarca,m.Descripcion Marca,c.Id IdCategoria,c.Descripcion Categoria,ImagenUrl,Precio from articulos a,MARCAS m,CATEGORIAS c where a.IdMarca = m.Id and a.IdCategoria = c.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void Agregar(Articulos nuevo)
        {
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio)values(@codigo,@nombre,@descripcion,@Idmarca,@Idcategoria,@imagen,@Precio)");
                datos.setearParametro("@codigo",nuevo.Codigo);
                datos.setearParametro("@nombre",nuevo.Nombre);
                datos.setearParametro("@descripcion",nuevo.Descripcion);
                datos.setearParametro("@idmarca",nuevo.Marca.Id);
                datos.setearParametro("@idcategoria",nuevo.Categoria.Id);
                datos.setearParametro("@imagen",nuevo.ImagenUrl);
                datos.setearParametro("@precio",nuevo.Precio);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Articulos modificado)
        {
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo,Nombre=@nombre,Descripcion=@descripcion,IdMarca=@marca,IdCategoria=@categoria,ImagenUrl=@imagen,Precio=@precio where Id=@id");
                datos.setearParametro("@codigo",modificado.Codigo);
                datos.setearParametro("@nombre",modificado.Nombre);
                datos.setearParametro("@descripcion",modificado.Descripcion);
                datos.setearParametro("@marca",modificado.Marca.Id);
                datos.setearParametro("@categoria",modificado.Categoria.Id);
                datos.setearParametro("@imagen",modificado.ImagenUrl);
                datos.setearParametro("@precio",modificado.Precio);
                datos.setearParametro("@id",modificado.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(Articulos eliminado)
        {
            try
            {
                datos.setearConsulta("delete from ARTICULOS where Id = @id");
                datos.setearParametro("@id", eliminado.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public List<Articulos> buscar(Categorias categoria, Marcas marca, string busqueda)
        {
            List<Articulos>lista = new List<Articulos>();
            string consulta = "select a.Id, Codigo,Nombre,a.Descripcion,m.Id IdMarca,m.Descripcion Marca,c.Id IdCategoria,c.Descripcion Categoria,ImagenUrl,Precio from articulos a,MARCAS m,CATEGORIAS c where a.IdMarca = m.Id and a.IdCategoria = c.Id";
            string categ = "";
            string marc = "";
            string busq = " and Nombre like '%" + busqueda + "%'";
            if (categoria != null)
            {
                categ = " and c.Id = "+categoria.Id.ToString();
            }
            if (marca != null)
            {
                marc = " and m.Id = " + marca.Id.ToString();
            }
            try
            {
                datos.setearConsulta(consulta + categ + marc + busq);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
