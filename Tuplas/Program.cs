using System;


// Tuplas en C#
// Lista de variables de distintos tipos
// Se pueden modifcar sus valores 
// Deben tener el mismo tipo de dato para cada valor y mismo acomodo
namespace Tuplas 
{
    class Program
    {
        static void Main (string [] args)
        {
            // Declaracion de una tupla
            ( int i, string nombre ) producto = (22 , "Victoria");

            // Forma 1
            // Imprimos los valores de producto
            Console.WriteLine($"{producto.i} {producto.nombre}");

            // Modificamos sus valores
            producto.nombre = "Corona";
            Console.WriteLine( $"{producto.nombre}");


            // Forma 2
            var persona = (23, "Alejandro");
            Console.WriteLine($"{persona.Item1} {persona.Item2}");

            
            // Forma 1
            // Tupla de Arreglos no concemos el nombre de la variable
            var personas = new [] {
                (1, "Alejandro"),
                (1, "Juan"),
                (1, "Jorge"),
            };

            // Iteramos la tupla
            foreach(var per in personas)
            {
                Console.WriteLine($"{per.Item1} {per.Item2}");
            }


            // Forma 2, con nobre de la variable de cada valor del arreglo
            (int id , string nombre)[] personas2 = new [] 
            {
                (1, "Alejandro"),
                (2, "Josue"),
            };

            foreach (var persona2 in personas2) 
            {
                Console.WriteLine($"{persona2.id} ${persona2.nombre}");
            }

            // Invocamos nuestro metodo para poder recibir los 3 valores
            var getInfo = GetLocation();
            Console.WriteLine($"Latitud {getInfo.latitud}, Longitud {getInfo.longitud}, Nombre {getInfo.nombre}");


            // Solo deseamos obtener un valor de la tupla que retorna dos valores
            var (_, longitud ,_) = GetLocation();
            Console.WriteLine(longitud);
        }

        // Metodo static para poder regresar mas de un valor de la funcion en una tupla
        // Declaracion de una tupla en un metodo que retorna 3 valordes
        public static (float latitud, float longitud, string nombre) GetLocation()
        {
            float latitud = 19.123f;
            float longitud = -99.18f;
            string nombre = "CDMX";


            return ( latitud, longitud, nombre);
        }  
    }
}