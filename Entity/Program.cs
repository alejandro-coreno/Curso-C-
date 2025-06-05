using System;
using Entity.Models;
using System.Linq;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;


namespace Entity
{
    class Program
    {
        static void Main(String[] args)
        {

            // Creamos una instancia de tipo DbContextOptionsBuilder para poder setear nuestra cadena de conexion 
            DbContextOptionsBuilder<TestContext> optionsBuilder = new DbContextOptionsBuilder<TestContext>();


            //Ocupamos el metodo UseMysql para poder mandar la conexion a nuestro BD
            optionsBuilder.UseMySql("server=localhost;database=Test;user=root;password=12345678", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.38-mysql"));


            // Using permite que cada que se ocupe algo solamente en ese momento y lo libera
            // Creamos un contex de nuestra BD mapeada con Entity Framework

            // Le pasamos a nuestro contexto la cadena de conexion dinamica a ocupar
            /*
            using (TestContext context = new TestContext(optionsBuilder.Options))
            {

                // Ocupamos un metodo para traernos un listado de cervesas
                var beers = context.Cervezas.ToList();

                // Iteramos nuestro listado de Cervezas de la BD
                foreach (var beer in beers)
                {
                    Console.WriteLine($"Cerveza: {beer.Nombre} con el ID: {beer.Id}");
                }

            }

            */


            // Creamos un menu para poder realizar las consultas con Entity
            bool active = true;
            int op = 0;

            do
            {
                ShowMenu();

                Console.WriteLine("Eligue una opcion");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Show(optionsBuilder);
                        break;
                }

            } while (active);

        }

        // Metodo para mostrar el listado de cervezas
        public static void Show(DbContextOptionsBuilder<TestContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("Listado de Cervezas de la Base de Datos :: ");

            // Ocupamos el contexto con using para que se cierre la conexion una vez que termina
            using (TestContext context = new TestContext(optionsBuilder.Options))
            {

                // Creamos un listado de cervezas el cual nos trae de la BD
                List<Cerveza> beers = context.Cervezas.ToList();


                //Iteramos el listado de la BD
                foreach (Cerveza beer in beers)
                {
                    Console.WriteLine($"La Cerveza {beer.Nombre} con el ID de la Marca {beer.Marcaid}");
                }
            }
        }


        // Metodo para mostrar el menu
        public static void ShowMenu()
        {
            Console.WriteLine("------ MENU ------");
            Console.WriteLine("1.- Mostrar ");
            Console.WriteLine("2.- Agregar");
            Console.WriteLine("3.- Editar");
            Console.WriteLine("4.- Eliminar");
            Console.WriteLine("5.- Salir");
        }
    }
}