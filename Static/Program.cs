// Palabra reservada static;
// Permite que le pertenezca a un tipo, clase, metodo, atributo etc

// Nota:: Cuando la clase es static todos sus metodos o atributos debe ser iguales


// Creamos el objeto de People
People people1 = new People()

// Modificamos el set de nombre y de edad
{
    nombre = "Alejandro",
    edad = 23
};

People people2 = new People()

{
    nombre = "Josue",
    edad = 23
};
Console.WriteLine( People.count );

Console.WriteLine( People.GetCount());


public static class A 
{
    public static void GetInfo() {
        Console.WriteLine("Este es un metodo static dentro de una clase Static");
    }
}

// clase people
public class People {
    public string nombre {get ; set;}

    public int edad { get; set;}

    // atributo de la clase

    public static int count = 0;



    // Cada que se invoque el constructor suma en uno al count
    public People(){
        count++; 
    }
    // metodo que le pertenece a la clase y retorna un string con interpolacion
    public static string GetCount(){
        // Realizamos la interpolacion
        return $"Numero de veces del {count} en la clase people";
    }
}
