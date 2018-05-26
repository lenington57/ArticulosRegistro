using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Linq.Expressions;
using ArticulosRegistro.DAL;
using ArticulosRegistro.Entidades;

namespace ArticulosRegistro.BLL
{
    ///<summary>
    ///En esta clase se programa toda la lógica de negocio.
    ///</summary>
    public class ArticuloBLL
    {
        ///<summary>
        ///Permite Guardar una entidad en la Base de Datos.
        ///</summary>
        ///<param name="articulo">una instancia de Articulo</param>
        ///<returns>Retorna True si Guardó o False si no lo hizo</returns>
        public static bool Guardar(Articulo articulo)
        {
            bool paso = false;
            //creamos una instancia del contexto para poder conectar con la BD.
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Articulo.Add(articulo) != null)
                {
                    contexto.SaveChanges();//Guardar los cambios.
                    paso = true;
                }
                contexto.Dispose();//Siempre hay que cerrar la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        ///<summary>
        ///Permite Modificar una entidad en la Base de Datos.
        ///</summary>
        ///<param name="articulo">una instancia de Articulo</param>
        ///<returns>Retorna True si Modificó o False si no lo hizo</returns>
        public static bool Modificar(Articulo articulo)
        {
            bool paso = false;
            //creamos una instancia del contexto para poder conectar con la BD.
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();//Siempre hay que cerrar la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        ///<summary>
        ///Permite Eliminar una entidad en la Base de Datos.
        ///</summary>
        ///<param name="id">El id el Articulo que desea Eliminar</param>
        ///<returns>Retorna True si Eliminó o False si no lo hizo</returns>
        public static bool Eliminar(int id)
        {
            bool paso = false;
            //creamos una instancia del contexto para poder conectar con la BD.
            Contexto contexto = new Contexto();
            try
            {
                Articulo articulo = contexto.Articulo.Find(id);

                contexto.Articulo.Remove(articulo);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();//Siempre hay que cerrar la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        
        ///<summary>
        ///Permite Buscar una entidad en la Base de Datos.
        ///</summary>
        ///<param name="id">El id el Articulo que desea encontrarar</param>
        ///<returns>Retorna el Articulo encontrado</returns>
        public static Articulo Buscar(int id)
        {
            //creamos una instancia del contexto para poder conectar con la BD.
            Contexto contexto = new Contexto();
            Articulo articulo = new Articulo();
            try
            {
                articulo = contexto.Articulo.Find(id);
                contexto.Dispose();//Siempre hay que cerrar la conexión.
            }
            catch (Exception)
            {
                throw;
            }
            return articulo;
        }

        ///<summary>
        ///Permite extraer una lista de Articulos de la Base de Datos.
        ///</summary>
        ///<param name="expression">Expresión Lambda conteniendo los filtros de búsqueda</param>
        ///<returns>Retorna una lista de Articulos</returns>
        public static List<Articulo> GetList(Expression<Func<Articulo, bool>> expression)
        {
            List<Articulo> articulos = new List<Articulo>();
            Contexto contexto = new Contexto();
            try
            {
                articulos = contexto.Articulo.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulos;
        }

    }
}
