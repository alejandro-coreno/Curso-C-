// Metodos de listas
using System;
using System.Collections.Generic;


namespace MetodosListas 
{
    class Program 
    {
        static void Main (string [] args)
        {   
            // Creacion de la lista
            List<int> numeros = new List<int>(){
                4, 3, 5, 19
            } ;

            Show(numeros);

            // Insert() -> Agregar un valor a la lista , posicion , valor
            numeros.Insert(1, 20);

            Show(numeros);
            

            // Permite evaluar si existe un valor Contains
            if( numeros.Contains(3))
                Console.WriteLine("Existe");
            else 
                Console.WriteLine("No existe");

            // IndexOf() -> Nos indica la posicion de un elemento
            int pos = numeros.IndexOf(19);
            Console.WriteLine("La posicion es: " + pos);

            //SOR -> Permite ordenar una lista de forma ascendente
            // Mutable -> Modifica directamente la lista
            numeros.Sort();
            Show(numeros);

            // AddRange() -> Permite agregar una lista a la lista actual

            List<int> numeros2 = new List<int>(){
                200, 300, 400
            };

            numeros.AddRange(numeros2);
            Show(numeros);
        }

        // Metodo static para mostrar los numeros
        public static void Show( List<int> numeros)
        {
            Console.WriteLine("-- Numeros --");
            foreach(int numero in numeros )
            {
                Console.WriteLine(numero);
            }
        }
    }
}
