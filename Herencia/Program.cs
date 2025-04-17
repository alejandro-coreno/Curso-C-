// Herencia en C#endregion
// Permite que una clase pueda heredar los metodos y caracteristicas de otra clase.

Doctor doctor1 = new Doctor("Alejandro", 23, "Desarollador web"); 


Console.WriteLine(doctor1.getInfo());
Console.WriteLine(doctor1.getData());


Dev dev1 = new Dev("Alejandro", 24, "C");
Console.WriteLine(dev1.getData());

class People 
{
    private string nombre;
    private int edad;

    // metodo constructor
    public People(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;

    }


    // metodo que retorn un string
    public string getInfo ()
    {
        return nombre + " " + edad;
    }

}

// Clase Doctor que hereda sus metodos y atributos de la clase People
class Doctor : People 
{
    private string especialidad;

    public Doctor(string nombre, int edad, string especialidad) : base(nombre, edad)
    {
        this.especialidad = especialidad;
    }

    // metodo que retorna un string de la clase people concatenado con el atributo especialidad
    public string getData () 
    {
        return getInfo() + " " + this.especialidad;
    }
}


// Clase desarollador que hereda de la clase people
class Dev : People
{   
    private string lenguage;

    public Dev(string nombre, int edad, string lenguaje ) : base(nombre, edad) {
        this.lenguage = lenguaje;
    }

    public string getData() {
        return getInfo() + " " + this.lenguage;
    }
}