using System;
using Microsoft.VisualBasic;

// Tipos Anonimos en C# 
// Objeto que no necesita de una clase para ser creado
// No permite modificar las propiedades del objeto anonimo 
// Se puede crear objetos de tipo anonimo pero solo son de modo lectura
namespace TiposAnonimos
{
    class Program
    {
        static void Main(string [] args)
        {
            // Declaracion de un objeto anonimo
            // objeto de solo lectura 
            var persona = new {
                Nombre = "Alejandro",
                Pais = "Mexico"
            };

            Console.WriteLine($"{persona.Nombre}, {persona.Pais}");

            // declaracion de un arreglo anonimo

            var beers = new [] {
                new { Nombre= "Corona", Marca = "Modelo"},
                new {Nombre = "Indio", Marca = "Coauthemoc "}
            };


            // Recorremos el arreglo

            foreach (var b in beers) 
            {
                Console.WriteLine($"Cerveza {b.Nombre} {b.Marca}");

            }
        }
    }
}