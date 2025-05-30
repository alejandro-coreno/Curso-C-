using System;
using MySqlConnector;
using Mysqlx.Connection;
using Mysqlx.Cursor;
using Org.BouncyCastle.Crypto.Operators;

namespace ConexionBD 
{
    // Creamos nuestra clase BeerDB y realizamos la herencia
    public class BeerDB : BD
    {
        // El padre en su constructor requiere los parametros se los pasamos con : base a la clase pádre
        public BeerDB(string server, string db, string user, string password)
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
                Cervezas.Add(new Cerveza(id, nombre, marcaid));

            }

            exit();

            return Cervezas;
        }

        // Metodo para obtener una cerveza

        public Cerveza Get(int id)
        {
            // Creamos nuestra conexion
            connect();

            // Creamos nuestro objeto de tipo Cerveza
            Cerveza beer = null;

            // Creamos nuestra consulta
            string query = "SELECT Id, Nombre, Marcaid WHERE id = @id";


            // Creamos un objeto de tipo command para poder ejecutar la consulta
            MySqlCommand command = new MySqlCommand(query, conn);


            // Pasamos nuestros parametros
            command.Parameters.AddWithValue("@id", id);


            // Leemos la informacion de la consulta
            MySqlDataReader reader = command.ExecuteReader();


            // Iteramos cada registro con el while para poder crear nuestro objeto de tipo cerveza
            while (reader.Read())
            {
                string name = reader.GetString(1);
                int marcaid = reader.GetInt32(2);


                beer = new Cerveza(id, name, marcaid);
            }
            // Cerramos la conexion
            exit();

            // retornamos nuestro objeto de tipo cerveza
            return beer;
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

        // Metodo para editar una cerveza
        public void Edit(Cerveza beer)
        {
            // Creamos la conexion
            connect();
            // Creamos la consulta
            string query = "UPDATE Cerveza SET Nombre = @name, Marcaid = @marcaid WHERE id = @id";

            // Instanciamos un objeto de tipo MysqlCommand
            MySqlCommand command = new MySqlCommand(query, conn);


            // Seteamos los parametros de la consulta
            command.Parameters.AddWithValue("@name", beer.Nombre);
            command.Parameters.AddWithValue("@marcaid", beer.MacaId);
            command.Parameters.AddWithValue("@id", beer.Id);

            // Ejecutamos la consulta
            command.ExecuteNonQuery();

            // Cerramos la conexion
            exit();
        }
    }
 

} 