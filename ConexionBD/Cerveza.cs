using System;

namespace ConexionBD 
{
    public class Cerveza 
    {   
        // Creamos las propiedades de la entidad que tienen la tabla de la BD
        public int Id {get; set;}

        public string Nombre { get; set;}

        public int MacaId { get; set;}


        // Creamos el constructor

        public Cerveza( int id, string nombre, int marcaid)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.MacaId = marcaid;
        }

         public Cerveza( string nombre, int marcaid)
        {
            this.Nombre = nombre;
            this.MacaId = marcaid;
        }
    }    
}