
// Libreria para poder ocupar formato JSON 
using System.Text.Json;

// JSON en C#
// Formato de Texto
// Nos permite darle una representacion de clave valor 

// creamos un objeto de tipo Beer

Beer beer = new Beer(){
    Name = "Pikantus",
    Brand = "Erdinger"
};

// Equivalente a un JSON
//string json = "{Nombre : Pikantus, Brand: Erdinger}";


//Serializar un JSON nos regresa un valor
// Convertimos nuestro objeto a formato JSON
string json = JsonSerializer.Serialize(beer);
Console.WriteLine( json );


// Deserealizacion
Beer beer1 = JsonSerializer.Deserialize<Beer>(json);

// Creamos un arreglo con dos objetos dentro
Beer [] beers = new Beer[]{
    new Beer()
    {
        Name = "Pikantus",
        Brand = "Erdinger"
    },
    new Beer()
    {
        Name = "Corona",
        Brand = "Modelo"
    }  
};

string json2 = JsonSerializer.Serialize(beers);
Console.WriteLine(" ---- ");


Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);

// clase cerveza
public class Beer 
{
    public string Name {get; set;}

    public string Brand {get; set;}
}