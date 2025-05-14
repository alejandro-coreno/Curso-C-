// Conexion BD 
// Creamos la clase BD para conectarnos

using System;
// Traemos la libreria propia de C# para poder ocupar LA BD
using MySql.Data.MySqlClient;



namespace ConexionBD 
{
    public class BD
    {
        // Creamos nuestra variable de conexion - cadena de conexion
        private string connectionString;

        // Atriobuto para crear nuestro objeto de tipo connection
        // varible para podernos conectar al BD con MySqlConnection
        protected MySqlConnection conn;


        // Creamos nuestro constructor el cual se encarga de inicializar nuestros
        // atributos
        public BD(string server, string db, string user, string password)
        {
            // Agregamos nuestras variables a la caden de conexion para MYSQL para inicializar
            connectionString = $"Server={server};Database={db};User ID={user};Password={password};";

        } 

        // Metodo para realizar la conexion a la BD
        public void  connect()
        {
            // creamos la varible para conectarno por medion de MysqlConnection 
            // el constructor requiere la cadena de conexion
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }

        // Metodo para cerrar nuesta Conexion
        // Primero verifica que este abierta la connexion
        public void exit()
        {
            if (connectionString != null)
                conn.Close();
        }
    }  
}
