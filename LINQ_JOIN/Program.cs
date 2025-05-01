// LINQ -> Nos permite trabajar de forma imperativa con coleeciones
using System;
using System.Linq;
using System.Collections.Generic;

// JOIN-> Nos permite unir dos colleciones que tenga algo en comun


namespace LINQ_JOIN  
{
    class Program 
    {
        static void Main(string [] args )
        {
            // Lista de tipo beer
            List<Beer> beers = new List<Beer>() {

                new Beer () 
                {
                    Nombre = "Corona",
                    Pais = "Mexico"
                },

                new Beer () 
                {
                    Nombre = "Delirium",
                    Pais = "Belgica"
                },

                new Beer ()
                {
                    Nombre = "Erdinger",
                    Pais = "Alemania"
                }
            };

            // Lista de Paises
            List<Pais> countrys = new List<Pais>() 
            {
                new Pais () 
                {
                    PaisNombre = "Mexico", 
                    Continente = "America"
                },

                new Pais () 
                {
                    PaisNombre = "Belgica",
                    Continente = "Europa"
                },

                new Pais () 
                {
                    PaisNombre = "Alemania",
                    Continente = "Europa"
                }
            };

            // Realizamos las union de las listas

            var beerContinent =  from beer in beers  
                                 join country in countrys
                                 on beer.Pais equals country.PaisNombre
                                 select new {
                                    Nombre = beer.Nombre,
                                    country = beer.Pais,
                                    continent = country.Continente

                                 };

            foreach ( var becont in beerContinent )
                Console.WriteLine($"{ becont.Nombre}, {becont.country}, {becont.continent}");

        }
    }

    // clase beer con dos propiedades 
    public class Beer 
    {
        public string Nombre { get; set;}

        public string Pais { get; set;}
    }


    public class Pais 
    {
        public string PaisNombre { get; set;}

        public string Continente { get; set;}
    }

}
