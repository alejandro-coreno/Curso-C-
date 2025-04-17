// Sobre Carga de Metodos en C#endregion
// Permite que la clase pueda tener varios metodos iguales pero con diferentes argumentos

// instanciamos el objeto de la clase Math
Math math = new Math();

Console.WriteLine( math.sum(3, 4));
Console.WriteLine(math.sum("1", "3"));


// Creamos nuestro arreglo de numeros
int [] numeros = new int[]{ 2, 5, 8};


// imprimimos nuestros numeros
Console.WriteLine(math.sum(numeros));
public class Math 
{
    // metodo sum que acepta dos valores de tipo int
    public int sum(int a , int b) 
    {
        return a + b ;
    }


    // metodo sum que acepta dos valores de tipo string
    public int sum ( string a , string b )
    {
        return int.Parse(a) + int.Parse(b);
    }

    // metodo que recibe un arreglo de numeros, retorna un entero
    public int sum(int[] numeros)
    {   
        int result = 0;

        int i = 0;

        while( i < numeros.Length )
        {
            result += numeros[i];
            i++;
        }

        return result;
    }

}




