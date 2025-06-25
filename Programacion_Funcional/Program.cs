using System;

// Programacion Funcional
// Delegado, definicion de una funcion o estructura
// Perrmite guardar en varibles nuestra funcion y poder modificar

// El delegado indica la estructura de nuestra funcion


//  Tipo o forma de definir una funcion 
// Cumple las reglas con un delegado
/*

// Funciones de Orden Superior -> Funciones que pueden recibir una funcion como parametro

namespace Programacion_Funcional
{
    class System
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
        }
    }
}

*/


// Creamos una variable del Tipo delegado Operation 
// Creacion de nuestra variable que guarda una funcion
operation mysum = Fuctions.Sum;

// Ejecucion de la variable que contiene la funcion del delegado
Console.WriteLine(mysum(5, 8));

mysum = Fuctions.Mul;

Console.WriteLine(mysum(5, 7));

// Creamos un delegado de tipo Show, y lo guardamos en nuestra variable message
Show mesage = Console.WriteLine;


// Ejecutamos nuestra Funcion la cual se encuentra en Mesasge
mesage += mesage;
mesage("Holaaa Programacion Funcional");

// Llamamos nuestra funcion de tipo Some

Fuctions.Some("Alejandro", "Coreño", mesage);


// Creamos nuestro delegados para las funciones que cumplan con cierta regla
delegate int operation(int a, int b);
public delegate void Show(string mesasge);


// Llamamos la funcion de tipo show

//Fuctions.Some("Juan", "Perez", mesage);


// Clase Fuctions
public class Fuctions
{
    // Funcion que recibe como parametro dos valores y retorna el resultado
    public static int Sum(int x, int y) => x + y;

    public static int Mul(int num1, int num2) => num1 * num2;

    public static void ShowMessage(string m) => Console.WriteLine(m.ToUpper());

    // Funcion que recibe un delegado como parametros
    // Funcion de Orden Superior
    public static void Some(string name, string lastname, Show fn)
    {
        Console.WriteLine("Has algo al Inicio");
        // Llamamos a la funcion de tipo Show que recibe un mesange y pasamos nuestros parametros de la funcion principal
        fn($"Hola {name}, {lastname}");

        Console.WriteLine("Has algo al final");
    }

}