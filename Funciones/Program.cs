// Funciones en C#
int a = 2;

int b = 3;

Console.WriteLine( a );
Console.WriteLine( b );


// Funcion que recibe valores y retorna un valor

static int mul( int num1, int num2){
    return num1 * num2;    
}

// Funcione recibe valores
static void sum (int num1 , int num2){

    Console.WriteLine( num1 + num2 );
}


// Funcion que le pertenece a la clase declaracion no devuelve valores
static void show () {
    Console.WriteLine("Hola soy un texto que se imprime desde una funcion");
} 

// invocamos la funcion
show();
sum( 2 , 3);
sum( 5 , 7);


int res = mul( 5 , 7) ;

Console.WriteLine( "El resultado es " + res);