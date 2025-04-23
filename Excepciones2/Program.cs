// Excepeciones personalizadas en C#
using System;

// Creamos nuestra clase para poder sobreEscribir y personalizar nuestras excepciones

namespace  Excepciones2
{
    class Program {
        static void Main (string [] args) {
            // Manejamos la excepcion con el try catch
            try 
            {
                Beer beer = new Beer(){
                    Name = "Corona",
                    Brand = "Modelo"
                };
                Console.WriteLine(beer);

            }
            catch(InValidBeer ex)
            {
                Console.WriteLine( ex.Message );
            }
        }

        // Clase personalizada para manejar las propias excepciones
        public class InValidBeer : Exception 
        {
            // Constructor
            public InValidBeer() : base("La cerveza no tien nombre o marca")
            {

            }
        }

        // Clase que tiene dos propiedades
        public class Beer 
        {
            public string Name {get; set;}

            public string Brand {get; set;}

            // Metodo para sobreEscribir el metodo ToString()];
            public override string ToString()
            {
                if (Name == null ){
                    throw new InValidBeer();
                }
                return $"Cerveza: {Name} , Brand: {Brand}";
            }
        }
    }
}
