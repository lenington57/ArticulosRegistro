using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ArticulosRegistro.Entidades
{
    public class Articulo //Debe ser p⌂blica para que pueda ser vista desde las otras capas
    {
        [Key]//Esta es la llave primaria hay que importar 'using System.ComponentModel.DataAnnotations;' 


        public int ArticuloId { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public string Descripcion { get; set; }

        public float Precio { get; set; }

        public float Existencia { get; set; }

        public float CantCotizada { get; set; }

        //Inicializando los valores con el constructor
        public Articulo()
        {
            ArticuloId = 0;
            FechaVencimiento = DateTime.Now;
            Descripcion = string.Empty;
            Precio = 0;
            Existencia = 0;
            CantCotizada = 0;
        }

    }
}
