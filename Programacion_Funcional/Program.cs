
#region  Cuerpo de un proyecto en C#
using System;
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
#endregion


#region DelegadoT
// Programacion Funcional
// Delegado, definicion de una funcion o estructura
// Permite guardar en varibles nuestra funcion y poder modificar
// El delegado indica la estructura de nuestra funcion, o formar de definir una funcion  
// Tipo o forma de definir una funcion 
// Cumple las reglas con un delegado

#endregion


#region Variables que guardan la funcion

// Creamos una variable del Tipo delegado Operation 
// Creacion de nuestra variable que guarda una funcion
operation mysum = Fuctions.Sum;

// Ejecucion de la variable que contiene la funcion del delegado
Console.WriteLine(mysum(5, 8));

mysum = Fuctions.Mul;

// Ejecutamos nuestra funcion con delegado
Console.WriteLine(mysum(5, 7));

// Creamos un delegado de tipo Show, y lo guardamos en nuestra variable message
Show mesage = Console.WriteLine;


// Ejecutamos nuestra Funcion la cual se encuentra en Mesasge
mesage += mesage;
mesage("Holaaa Programacion Funcional");

// Llamamos nuestra funcion de tipo Some

Fuctions.Some("Alejandro", "Coreño", mesage);

#endregion


#region FuncionLamda 
// Forma de escribir una funcion anonima y practica
// Permite crear una funcion 

//  Ejemplo

// Action pérmite crear una funcion con parametros, y no retornar nada
// Creamos le delegado con Action y mostramos la respuesta dentro de la misma funcion
Action<string, string> showMesage2 = (a, b) => Console.WriteLine($"{a} , {b}");

// Llamamos la funcion con sus dos parametros que nos solicita
showMesage2("Nombre", "Nombre2");

#endregion


#region  Delegado Generico Action
// Delegado Generico Action ->
// Permite definir una funcion que no retorna un valor
// Se definen por numero de parametros y si regresan un valor o no 
// Action -> Permite recibir parametros pero no regresa nada
// Delegado Generico , ser una funcion cualquiera que reciba un numero de parametros, pero no regresa nada 
// Guardamos nuestra variable showMesage

// Action -> Recibe el tipo de dato, que va a recibir
Action<string> showMessage = Console.WriteLine;

// Ejecutamos nuestro delegado Action
showMessage("Delegado Generico Action");

Fuctions.SomeAction("Josue Alejandro", "Camacho", showMessage);
#endregion




#region  Delegados
// Creamos nuestro delegados para las funciones que cumplan con cierta regla
delegate int operation(int a, int b);
public delegate void Show(string mesasge);
public delegate void Show2(string mesasge, string mesage2);
public delegate void Show3(string mesasge, string mesage2, string mesage3);

#endregion





// Clase Fuctions
public class Fuctions
{
    // Funcion que recibe como parametro dos valores y retorna el resultado
    public static int Sum(int x, int y) => x + y;

    // Funcion que recibe dos valore y regresa un valor
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

    public static void SomeAction(string name, string lastname, Action<string> fn)
    {
        Console.WriteLine("Has algo al Inicio");
        // Llamamos a la funcion de tipo Show que recibe un mesange y pasamos nuestros parametros de la funcion principal
        fn($"Hola {name}, {lastname}");

        Console.WriteLine("Has algo al final");
    }

    // Funcion que retorna un valor mas 1
    public int nombre(int n)
    {
        return n + 1;
    }

}