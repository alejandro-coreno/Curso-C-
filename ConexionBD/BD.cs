// Conexion BD 
// Creamos la clase BD para conectarnos

using System;
// Traemos la libreria propia de C# para poder ocupar LA BD
using MySql.Data.MySqlClient;



namespace ConexionBD 
{
    public class BD
    {
        // Creamos nuestra variable de conexion
        private string connectionString;

        // Atriobuto para crear nuestro objeto de tipo connection
        protected MySqlConnection conn;


        // Creamos nuestro constructor el cual se encarga de inicializar nuestros
        // atributos
        public BD(string server, string db, string user, string password)
        {
            // Agregamos nuestras variables a la caden de conexion para MYSQL
            connectionString = $"Server={server};Database={db};User ID={user};Password={password};";

        } 

        // Metodo para realizar la conexion a la BD
        public void  connect()
        {
            conn = new MySqlConnection(connectionString);
            conn.Open();
        }

        // Metodo para cerrar nuesta Conexion
        public void exit()
        {
            conn.Close();
        }
    }  
}
