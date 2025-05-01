// LINQ -> Nos permite trabajar con collecciones
// Nos permite trabajar de forma interaciva  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LINQ 
{
    // clase program
    class Program 
    {
        static void Main(string [] args )
        {
            // Creamos una lista de cervezas de tipo beer  con tres objetos diferentes 
            List<Beer> beers = new List<Beer>(){
                new Beer (){
                    Nombre = "Corona",
                    Pais = "Mexico"
                },

                new Beer (){
                    Nombre = "Victoria",
                    Pais = "Alemana"
                },

                new Beer()
                {
                    Nombre = "Pacifico",
                    Pais = "Rusa"
                }
            };

            // Iteramos nuestra lista
            foreach(var beer in beers)
                Console.WriteLine( beer );

            Console.WriteLine("---------------------------");

            // Select en LINQ
            // Permite seleeccionar valores en especificos de la lista 


            // creamos nuestra consulta la cual nos trae los valores de nombre de la lista
            // Ademas se crea un valor de tipo anonimo
            // Nos traemos una nueva lista con un atributo nuevo de letras
            var beersName = from b in beers
                            select new {
                                Nombre = b.Nombre,
                                Letras = b.Nombre.Length,
                                fid = 1
                            };


            foreach( var beer in beersName)
                Console.WriteLine( $"{beer.Nombre} {beer.Letras} {beer.fid}");


            // Nota las iterface creadas apartir de la lista no se pueden modificar, como la original

            Console.WriteLine("---------------------------");

            // Creamos otra lista apartir de la nueva para pode obtener los nombres solamente
            var beerName2 = from b in beersName 
                            select new
                            {
                                Nombre = b.Nombre
                            } ;

            //Iteramos la lista nueva de nombres
            foreach( var beer in beerName2)
                Console.WriteLine( beer.Nombre );
            
            Console.WriteLine("-------------------------");

            // where nos permite filtrar una lista, con los nombres de un valor
            var beerMexico = from b in beers 
                        where b.Nombre == "Mexico"
                        select b;

            foreach( var beer in beerMexico)
                Console.WriteLine( beer.ToString() );

            Console.WriteLine("--------------------------");

            //Ordenamos nuestra lista original de forma ascendente por el pais

            var orderBeers = from b in beers 
                        orderby b.Pais
                        select b ;

            // Iteramos nuesta nuva lista ordenada por paises
            foreach(var beer in orderBeers )
                Console.WriteLine(beer);
        }
    }

    // clase beer
    public class Beer 
    {
        // Propiedades de la clase 
        public string Nombre{ get; set;}

        public string Pais { get; set; }

        // SobreEscribimos el metodo ToString();:

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Pais: {Pais}";
        }
    }
}
