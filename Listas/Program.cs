// Libreria para trabajar con listas
using System;
using System.Collections.Generic;

// Listas en C#
// Tipo de dato para poder trabaja con ellos
// Podemos ordenar una lista, podemos manipular una lista
// Lista no se especifica el numero de elementos que va a tener 


// Declaracion de una lista 

List<int> numeros = new List<int>();

// agregar elementos 
numeros.Add(4);
numeros.Add(8);


// numero de elementos
Console.WriteLine( numeros.Count);


// Declaracion de la lista con valores por defecto

List<int> numero2 = new List<int>() {
    8, 10 ,12, 3
};


Console.WriteLine( numero2.Count);
// agregar valores
numero2.Add(444);

Console.WriteLine(numero2.Count);
// metodo para borrar los datos
numero2.Clear();
Console.WriteLine(numero2.Count);


// Lista de tipo string
List<string> paises = new List<string>() {
    "Mexico", "Argentina"
};
