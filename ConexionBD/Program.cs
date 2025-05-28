// Conexion BD 

// Nos conectamos a la base de datos
using System;
using System.Collections.Generic;
namespace ConexionBD 
{
    class Program
    {
        static void Main (string [] args) 
        {
            try 
            {
                // Instaciamos la clase para poder conectar al BD mediante el hijo
                BeerDB beerdb = new BeerDB("localhost","Test", "root", "12345678");

                // Obtenemos la lista del metodo GetAll que retorna la clase BeerDB 
                List<Cerveza> beers = beerdb.GetAll();
                
                //Iteramos nuestra lista de cervezas ya seteada
                foreach(var beer in beers)
                {
                    Console.WriteLine($" La Cerveza con Id: {beer.Id} es {beer.Nombre} ");
                }
            }

            // Atrapamos el error 
            catch (Exception ex)
            {
                Console.WriteLine("No se puede conectar a la base de datos" + ex.Message);
            }

        }
    } 
}
