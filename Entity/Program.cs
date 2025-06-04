using System;
using Entity.Models;

namespace Entity
{
    class Program
    {
        static void Main(String[] args)
        {
            // Creamos un contex de nuestra BD mapeada con Entity Framework
            TestContext context = new TestContext();


            // Ocupamos un metodo para traernos un listado de cervesas

            var beers = context.Cervezas.ToList();

            // Iteramos nuestro listado de Cervezas de la BD
            foreach (var beer in beers)
            {
                Console.WriteLine($"Cerveza: {beer.Nombre} con el ID: {beer.Id}");
            }
        }
    }
}