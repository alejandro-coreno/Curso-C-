// Interfaces en C#;
// Permite que las clases sigan reglas o un contrato 
// termino abstracto
// Debe respetar y cumplir con un contrato la clase 


// Nota: En las interfaces solo se declaran los metodos y propiedades que deseamos tener si se quiere implementar en la clases

Shark [] sharks = new Shark[]{
    new Shark("Tiburin", 22),
    new Shark("Jaws", 24)
};



public class Progra 
{
    public static ShowFish(IFish[] fishs)
    {
        Console.WriteLine("-- Mostramos los peces -- ");
        int i = 0;

        while (i < fishs.Length) {
            Console.WriteLine(fishs[i].Swim());
            i++;
        }
    }
}

// para poder implmentar de la inteface IAnimal, Ifish debo cumplir lo que solicitan en la inteface
public class Shark: IAnimal, IFish
{
    public string Nombre { get; set; }

    public int Speed { get; set; }

    public Shark (string Nombre, int Speed )
    {
        this.Nombre = Nombre;
        this.Speed = Speed;
    }

    public string Swim()
    {
        return $"{ Nombre } nada { Speed } Km/h";
    }
}



// interface animal
public interface IAnimal  
{
    // propiedad 
    public string Nombre {get; set;}

}
// Interface pescado
public interface IFish {
    public int Speed { get; set; }

    // metodo nadar
    public string Swim();
}