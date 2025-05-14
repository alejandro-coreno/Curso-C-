// Conexion BD 

using System;
namespace ConexionBD 
{
    class Program
    {
        static void Main (string [] args) 
        {
            try 
            {
                // Instaciamos la clase para poder conectar al BD
                BD bd = new BD("localhost","Test", "root", "123456789");

                bd.connect();

                bd.exit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se puede conectar a la base de datos" + ex.Message);
            }

        }
    } 
}
