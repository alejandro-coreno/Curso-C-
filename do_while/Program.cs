// Sentencia Do y while
// El bucle do while ejecuta el bloque de código al menos una vez y luego verifica la condición.
// Si la condición es verdadera, el bucle se repite; si es falsa, el bucle termina.


// Primera declaracion del while
int i = 0;

while ( i < 10 )
{
    Console.WriteLine("Iteracion de i: " + i);
    i++;
}


// Se rompe el while cuando el valor es igual a 10:

int j = 0;

while( j < 100 ){

    if (i < 10 )
        break;
    
    Console.WriteLine( "Iteracion de j:  " + j );
    j++;
}

// Declaracion del arreglo
string [] friends = new string[5]{
    "Amigo1",
    "Amigo2",
    "Amigo3",
    "Amigo4",
    "Amigo5"
};

// Iteramos el arreglo para mostrar sus elementos
int index = 0;

while( index < friends.Length ) 
{
    Console.WriteLine( friends[index]);

    index++;
}

// Do while permite entrar al bloque de codigo al menos una vez
// primero se ejecuta despues evalua


bool entrar = false;

do{

    show();

} while(entrar);


void show(){
    Console.WriteLine("Entra una vez al Do mediante una funcion");
}