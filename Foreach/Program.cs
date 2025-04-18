// Metodo Foreach C#;
using System;
using System.Collections.Generic;

namespace Foreach
{
    class Program 
    {
        static void Main (string [] args)
        {
            // Lista de numeros
            List<int> numeros = new List<int>(){
                23, 12, 2 , 1 , 3 ,4 
            };

            // creamos el foreach su valor que va tener por cada vuelta y la lista
            foreach(int numero in numeros)
            {
                Console.WriteLine( numero );
            }


            // Creamos una lista de tipo people
            List<People> peoples = new List<People>() {
                new People { Nombre = "Alejandro", Pais = "Mexico"},
                new People { Nombre = "Juan", Pais = "Belgica"},
                new People { Nombre = "Alex", Pais = "Peru"}
            };

            // Invocamos nuestro metodo show
            Show(peoples);

            // Metodo para eliminar una posicion de la lista

            peoples.RemoveAt(0);

            Show(peoples);
        }

        // Metodo static para mostrar la lista de tipo people
        static void Show (List<People> students)
        {
            Console.WriteLine("-- Listado personas  --");

            // Recorremos nuestra lista
            foreach(var student in students)
            {
                Console.WriteLine($"Nombre: {student.Nombre}, Pais: {student.Pais}");
            }
        }


    }

    // clase people
    class People 
    {
        public  required string Nombre {get; set;}

        public required string Pais { get; set; }
    }
    
}
