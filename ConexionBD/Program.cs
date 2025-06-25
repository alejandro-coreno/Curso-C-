// Nos conectamos a la base de datos
using System;
using System.Collections.Generic;
using Mysqlx.Crud;
using Org.BouncyCastle.Crypto.Engines;
namespace ConexionBD 
{
    class Program
    {
        // Entrada de la aplicacion
        static void Main(string[] args)
        {
            try
            {
                // C
                // Instaciamos la clase para poder conectar al BD mediante el hijo
                BeerDB beerdb = new BeerDB("localhost", "Test", "root", "12345678");

                // creamos un menu para pdode elegir la opcion a realizar
                bool empezar = true;
                int op = 0;
                // Menu
                do
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("/-------/-------/---------/---------/");
                    showMenu();
                    Console.WriteLine("Elige un opcion a realizar");

                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            showList(beerdb);
                            break;
                        case 2:
                            Add(beerdb);
                            break;
                        case 3:
                            Edit(beerdb);
                            break;
                        case 4:
                            Delete(beerdb);
                            break;
                        case 5:
                            empezar = false;
                            break;
                    }
                } while (empezar);
            }

            // Atrapamos el error 
            catch (Exception ex)
            {
                Console.WriteLine("No se puede conectar a la base de datos" + ex.Message);
            }

        }

        // Metodo Menu
        public static void showMenu()
        {
            Console.WriteLine("\n Seleccione una opcion a realizar ");
            Console.WriteLine("1.- Mostrar ");
            Console.WriteLine("2.- Agregar ");
            Console.WriteLine("3.- Editar ");
            Console.WriteLine("4.- Eliminar ");
            Console.WriteLine("5.- Salir ");
        }


        // Metodo para mostrar el listado de cervezas de la BD
        public static void showList(BeerDB beerdb)
        {
            Console.Clear();

            Console.WriteLine("LIstado de Cervezas");
            Console.WriteLine("\n ------------------ ");
            // Obtenemos la lista del metodo GetAll que retorna la clase BeerDB 
            List<Cerveza> beers = beerdb.GetAll();

            //Iteramos nuestra lista de cervezas ya seteada
            foreach (var beer in beers)
            {
                Console.WriteLine($" La Cerveza con Id: {beer.Id} es {beer.Nombre} ");
            }

        }


        // Metodo para agregar un registro a la BD
        public static void Add(BeerDB beerdb)
        {
            Console.WriteLine("\n ------------------ ");
            Console.WriteLine("Agregar Cerveza");
            Console.WriteLine("Nombre de la Cerveza : ");

            string name = Console.ReadLine();

            Console.WriteLine("El id de la Marca");
            int id = int.Parse(Console.ReadLine());


            Cerveza beer = new Cerveza(name, id);

            beerdb.Add(beer);

        }

        // Metodo para Editar un registro
        public static void Edit(BeerDB beerdb)
        {
            Console.Clear();

            showList(beerdb);

            Console.WriteLine("Editar una Cerveza");

            Console.WriteLine("Eligue el id de la Cerveza a editar");

            int id = int.Parse(Console.ReadLine());

            Cerveza beer = beerdb.Get(id);

            if (beer.Id != null)
            {
                Console.WriteLine("Cual es el nombre: ");

                string name = Console.ReadLine();

                Console.WriteLine("Cual es el id de la Marca");

                int marca = int.Parse(Console.ReadLine());

                beer.Nombre = name;
                beer.MacaId = marca;

                beerdb.Edit(beer);
            }
            else
            {
                Console.WriteLine("El id de la cerveza no existe");
            }


        }

        // Metodo para Eliminar un regisgto de la BD
        public static void Delete(BeerDB beerdb)
        {
            Console.Clear();
            showList(beerdb);

            Console.WriteLine("Eliminar una cerveza");

            Console.WriteLine("Escribe el Id de la Cerveza a eliminar: ");

            int id = int.Parse(Console.ReadLine());

            Cerveza beer = beerdb.Get(id);


            if (beer != null)
            {
                beerdb.Delete(id);
            }
            else
            {
                Console.WriteLine("La cerveza no existe");
            }
            
            
        }
    } 
}
