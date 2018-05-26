using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using ArticulosRegistro.Entidades;

namespace ArticulosRegistro.DAL
{
    //Aqui agregamos public también, para que la clase pueda ser encontradaen cualquier parte del proyecto
    //y heredamos de DbContext para que EntityFramework haga su trabajo
    public class Contexto : DbContext
    {
        public DbSet<Articulo> Articulo { get; set; }


        //base("ConStr") para pasar la conexion a EntityFramework
        public Contexto() : base("ConStr")
        { }
    }
}
