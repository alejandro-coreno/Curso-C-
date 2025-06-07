using System;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System.Runtime.Intrinsics.Arm;


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

                Console.WriteLine("Elige una opcion");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Show(optionsBuilder);
                        break;
                    case 2:
                        Add(optionsBuilder);
                        break;
                    case 3:
                        Update(optionsBuilder);
                        break;
                    case 4:
                        Delete(optionsBuilder);
                        break;
                    case 5:
                        active = false;
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
                List<Cerveza> beers = context.Cervezas.OrderBy(b => b.Nombre).ToList();

                // Creamos un listado de cervezas y con LINQ , filtramos de manera ordenada de manera por el nombre del Listado de la BD
                // Include nos permit realizar un JOIN con la Tabla cerveza
                // Nos permite realizar un JOIN con la tabla
                List<Cerveza> beers2 = (from b in context.Cervezas where b.Marcaid == 2 orderby b.Nombre select b).Include( b => b.Marca).ToList();


                //Iteramos el listado de la BD
                foreach (Cerveza beer in beers2)
                {
                    Console.WriteLine($"La Cerveza {beer.Nombre} con el ID de la Marca {beer.Marcaid}, {beer.Marca.Nombre}");
                }
            }
        }

        
        // Metodo para agregar una cerveza
        public static void Add(DbContextOptionsBuilder<TestContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("Agregar una Cerveza BD");
            Console.WriteLine("Escribe el nombre de la Cerveza:: ");

            string cerveza = Console.ReadLine();

            Console.WriteLine("Escribe el ID de la cerveza");

            int id = int.Parse(Console.ReadLine());



            using (TestContext context = new TestContext(optionsBuilder.Options))
            {
                // Creamos una instancia de Cerveza
                Cerveza beer = new Cerveza()
                {
                    Nombre = cerveza,
                    Marcaid = id
                };

                // Agregamos la cerveza al contexto
                context.Add(beer);

                // Guard amos los cambios en la BD
                context.SaveChanges();

                Console.WriteLine("Cerveza agregada correctamente");
            }
        }

        // Metodo para actualizar una cerveza
        public static void Update(DbContextOptionsBuilder<TestContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("Actualizar una Cerveza BD");

            // Mostramos la cervezas
            Show(optionsBuilder);
            Console.WriteLine("Escribe el ID de la Cerveza a actualizar:: ");
            
            // Guardamos el ID de la cerveza a actulizar
            int id = int.Parse(Console.ReadLine());

            using (TestContext context = new TestContext(optionsBuilder.Options))
            {
                // Buscamos la cerveza por el ID
                Cerveza beer = context.Cervezas.Find(id);

                if (beer != null)
                {
                    Console.WriteLine($"Cerveza encontrada: {beer.Nombre}");
                    Console.WriteLine("Escribe el nuevo nombre de la Cerveza:: ");

                    string nombre = Console.ReadLine();

                    Console.WriteLine("Escribe el nuevo ID de la marca :: ");

                    int neeId = int.Parse(Console.ReadLine());


                    beer.Nombre = nombre;
                    beer.Marcaid = neeId;

                    // Editamos la informacion con entry , con el estado le indicamos que estamos modificando la cerveza
                    context.Entry(beer).State = EntityState.Modified;

                    // Guardamos los cambios en la BD
                    context.SaveChanges();

                    Console.WriteLine("Cerveza actualizada correctamente");
                }
                else
                {
                    Console.WriteLine("Cerveza no encontrada");
                }
            }
        }

        // Metodo para eliminar una cerveza 
        public static void Delete(DbContextOptionsBuilder<TestContext> optionsBuilder)
        {
            Console.Clear();
            Console.WriteLine("*** Eliminar una Cerveza");

            Show(optionsBuilder);

            Console.WriteLine("Escribe el ID de la cerveza a eliminar");
            int id = int.Parse(Console.ReadLine());

            using (TestContext context = new TestContext(optionsBuilder.Options))
            {
                Cerveza cerv = context.Cervezas.Find(id);

                if (cerv != null)
                {
                    // Metodo Remove nos permite eliminar un elemento de la BD
                    context.Cervezas.Remove(cerv);

                    // Guardamos los cambios en BD
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("No se encontro la cerveza");
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