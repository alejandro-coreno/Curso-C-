// arreglos en C#

// Los arreglos son estructuras de datos que permiten almacenar múltiples valores en una sola variable. En C#, los arreglos son de tamaño fijo y pueden contener elementos del mismo tipo. A continuación, se presentan ejemplos de cómo declarar, inicializar y manipular arreglos en C#.
 

// Declaracion de una arreglo con sus valores inicializados

string [] friends = new string [7]{
    "Alejandro", 
    "Juan",
    "Paco", 
    "Carlos",
    "Ricardp",
    "Hernan", 
    null
};

// Almacenamos el primer valor 
friends[0] = "Alejandro";


// Imprimimos la primera posicion
Console.WriteLine(friends[0]);
Console.WriteLine(friends[1]);
Console.WriteLine(friends[2]);
Console.WriteLine(friends[3]);
Console.WriteLine(friends[4]);
Console.WriteLine(friends[5]);
Console.WriteLine(friends[6]);


friends[6] = "Posicion 6";

Console.WriteLine(friends[6]);

