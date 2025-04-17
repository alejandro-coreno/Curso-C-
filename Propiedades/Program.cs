// Propiedades en C#


// Creamos el objeto

Sale mysale = new Sale(100, DateTime.Now);

mysale.Total = 111;

Console.WriteLine(mysale.Total);

// Clase Sale
class Sale {
    // Atributos de la clase para la clase
    // public 

    private int total;
    DateTime date;


    // Solo pueden acceder al valor de Date de modo lectura    
    public string Date{
        get{
            return date.ToLongDateString();
        }
    }

    // Creacion de propiedades, metodo get retorna el atributo total
    public int Total {
        get{
            return total;
        }

        // protegemos el valor cuando llegue menor que cero y lo asignamos al atributo total
        set{
            if ( value < 0)
                value = 0;
            total = value;
        }
    }

    public Sale(int total, DateTime date)
    {
        this.total = total;
        this.date = date;

    }
}
