// Paradigma Programacion Orientada Objetos

// Las clases son plantillas para crear objetos.
// Un objeto es una instancia de una clase.
// Una clase puede contener:
// - Campos (variables)
// - Propiedades (variables con acceso controlado)
// - Métodos (funciones)
// - Constructores (funciones que se llaman al crear un objeto)


// Instanciamos un objeto de la clase Sale para acceder a sus metodos
Sale usuario = new Sale(100, DateTime.Now);

// Invocamos el metodo venta desde la clase principal
usuario.venta1();

// Invocamos el metodo getInfo
Console.WriteLine( usuario.getInfo());

// Creacion de una clase

class Sale 
{
    // atributos de la clase 
    int total;
    DateTime date;

    // Creamos el constructor de la clase para asignar los valores a los atributos de la clase
    // Permite inicializar las variables de la clase 
    public Sale(int total, DateTime date){
        this.total = total;
        this.date = date;
    }


    // creamos un metodo publico de la clase
    public void venta1 (){
        Console.WriteLine("Metodo venta activado desde la clase Sale");
    }

    // metodo para regresar la info de la clase con metodo
    public string getInfo(){
        return total + " " + date.ToLongTimeString();
    }

}