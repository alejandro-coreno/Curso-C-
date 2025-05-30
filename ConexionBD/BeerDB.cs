using System;
using MySqlConnector;
using Mysqlx.Connection;

namespace ConexionBD 
{
    // Creamos nuestra clase BeerDB y realizamos la herencia
    public class BeerDB : BD 
    {
        // El padre en su constructor requiere los parametros se los pasamos con : base a la clase pádre
        public BeerDB (string server, string db, string user, string password)
            : base(server, db, user, password)
        {

        }


        // Creamos un metodo que retorna una lista de cervezas
        public List<Cerveza> GetAll()
        {
            // Abrimos la conexion
            connect();

            // cremos una lista de cervezas
            List<Cerveza> Cervezas = new List<Cerveza>();


            // Creamos la consulta
            string query = "SELECT Id, Nombre, MarcaId FROM Cerveza";

            // creamos la instancia command MysqlCommand   
            MySqlCommand command = new MySqlCommand(query, conn);

            // Permite leer la conuslta que  ejecutamos con coomand 
            MySqlDataReader reader = command.ExecuteReader();

            // Leemos los datos de cada fila de la base de datos
            while (reader.Read())
            {   
                // Guardamos cada uno de los campos para despues agregarlos a las lista
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                int marcaid = reader.GetInt32(2);

                // agregamos una lista de cervezas y agregamos los valores a la clase Cerveza    
                Cervezas.Add( new Cerveza(id, nombre, marcaid));
                
            }
             
            exit();

            return Cervezas;
        }

        // Metodo para agregar 
        public void Add(Cerveza beer)
        {
            // Realizamos la conexion
            connect();

            // Creamos nuestra consulta
            string query = "INSERT INTO Cerveza (Nombre, Marcaid) VALUES (@name, @marca)";

            // Creamos un objeto de tipo MySqlCommand
            MySqlCommand command = new MySqlCommand(query, conn);


            // Seteamos nuestros parametros
            command.Parameters.AddWithValue("@name", beer.Nombre);
            command.Parameters.AddWithValue("@marca", beer.MacaId);


            // Ejecutamos la consulta
            command.ExecuteNonQuery();

            //Cerramos nuetra conexion
            exit();
        }
    }
 

} 