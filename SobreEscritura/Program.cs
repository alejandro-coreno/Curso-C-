// Sobre Escritura de metodos en C#;
// Permite modificar un metodo de la clase o se puede ampliar 


// Virtual -> se agrega en el metodo donde se desea realizar una sobreEscritura
// overrade -> se agrega en el metodo hijo donde se realizara la modificacion
// base -> sirve para poder ampliar el metodo padre o llamarlo
// Nota: Para poder sobreEscribir un metodd de la clase padre debe llamarse igual el metodokf

B objetoB = new B();

Console.WriteLine(objetoB.hello());

Sale sale1 = new Sale(5);

sale1.add(12);
sale1.add(16);

Console.WriteLine(sale1.GetTotal());

SaleWithTax saleWithTax = new SaleWithTax(4, 1.16m);

saleWithTax.add(12);
saleWithTax.add(16);
Console.WriteLine(saleWithTax.GetTotal());

public class A 
{
    public virtual string hello() 
    {
        return "Hola soy A";
    }
}

// Clase B hereda de la clase padre A 
public class B : A
{
    // sobre  escribe un metodo
    public override string hello()
    {
        return "Hola soy el metodo B";
    }
}

// Ejemplo SobreEscritura

public class Sale { 
    // Creamos un atributo de tipo arreglo decimales
    private decimal []_amounts;

    private int n;

    private int _end;

    // N el limite de los arreglos, le asignamos cuantas posiciones tendra el arreglo
    public Sale (int n){
        this._amounts = new decimal[n];

        this.n = n;

        this._end = 0;
    } 

    // Metodo para agregar 
    public void add(decimal amount) {
        // Pregunta si la variable end es menor al limite de nuestro arreglo N
        // agrega el valor en esa posicion y aumenta la variable _end 
        if (_end < n)
        {
            this._amounts[_end] = amount;

            _end++;
        }
    }


    public virtual decimal GetTotal() {
        // inicializamos el contador que realizara la suma deñ arreglo de numeros
        decimal result = 0;

        int i = 0;


        // iteramos nuestro arreglo
        while ( i < this._amounts.Length)
        {
            // sumamos en cada vuelta el resultado actual mas la posicion del arreglo donde se encuentra y lo guardamos en result
            result += this._amounts[i];

            // incrementamos nuestra variable por cada vuelta;
            i++;
        }

        return result;
    }

}

public class SaleWithTax : Sale 
{   
    // atributo para el impuesto
    private decimal _tax;

    // Le pasamos al constructor del padre n
    public SaleWithTax(int n, decimal tax) : base( n )
    {
        _tax = tax;
    }
    // Sobre escribimos el metodo GetTotal() del padre para poder agregarle el impuesto 
    public override decimal GetTotal()
    {

        return base.GetTotal() * _tax;
    }
}