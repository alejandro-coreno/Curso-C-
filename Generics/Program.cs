// Generics en C#;
// Permite recibir un tipo de dato de la clase y poder reutilizar metodos y propiedades de diferentes tipos
// Nos permite a reutilizar codigo y se llama <T>

// Ocupamos nuestra clase con el Generics para indicar que vamos a trabajar con int
MiLista<int> numeros = new MiLista<int>(8);

// Agregamos valores a cada posicion del arreglo
numeros.Add(2);
numeros.Add(14);

MiLista<string> cadena = new MiLista<string>(5);
cadena.Add("Alejandro");

// Creamos dos objetos de tipo People

MiLista<People> people = new MiLista<People>(5);
people.Add(new People() {Nombre = "Alejandro", Pais="Mexico"});
people.Add(new People() {Nombre = "Juan", Pais="Brasil"});


Console.WriteLine(numeros.GetElements(12));
Console.WriteLine(cadena.GetElements(0));


Console.WriteLine(numeros.GetString());
Console.WriteLine(cadena.GetString());
Console.WriteLine(people.GetString());
// Nos permite manejar varios tipos de datos en la clase para poder reutilizar codigo y trabajar con distintos tipos de datos

public class People {
    public string Nombre {get; set;}

    public string Pais { get; set;}

    public override string ToString()
    {
        return $"Nombre: {Nombre} -- Pais: {Pais}";
    }
}

public class MiLista <T>
{
    // atributo privado de numeros int 
    private T[] elements;
    private int index = 0;


    // numero de posiciones que recibe el constructor para el arreglo de elementos 
    public MiLista(int n){
        this.elements = new T[n];
    }


    // Metodo para agregar un valor en cada posicion de nuestro arreglo e incrementamos 
    public void Add( T e){
        if (index < elements.Length)
        {
            elements[index] = e;
            index++;
        }
    }


    // Metodo para devolver valores generics
    public T GetElements(int i)
    {
        if (i < index && i >= 0)
        {
            return elements[i];
        }

        return default(T);
    }

    // Metodo para mostrar los elementos
public string GetString(){
        int i = 0;
        string result = "";
        while ( i < index)
        {
            result += elements[i].ToString() + "|";
            i++;
        }        

        return result;
    }
}
