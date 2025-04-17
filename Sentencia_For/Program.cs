// Sentencia FOR
// El bucle for se utiliza para ejecutar un bloque de código un número específico de veces.

// Declaracion del arreglo
string[] friends = new string[6]{
    "Amigo1",
    "Amigo2",
    "Amigo3",
    "Amigo4", 
    "Amigo5",
    "Amigo6"
};

// Iteracion del arreglo con bucle FOR
// Declaracion, Codicion, Incremento

for (int i = 0; i < friends.Length; i++)
{
    Console.WriteLine( friends[ i] );
}