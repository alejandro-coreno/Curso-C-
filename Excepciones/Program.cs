
using System;
// Permite leer Archivos
using System.IO;
// Excepciones en C#
// Podemos controlar varios escenarios 
// Construccion base de un proyecto
// Control 

// Manejamos las excepciones con try catc, finally siempre se va ejecutar

namespace Excepciones 
{
    class Program {
        static void Main (string [] args)
        {   // Creacion de una tupla 
            //(int i, int b) valores = new (1, 2);

            // Manejamos la excepcion con el try catch
            try 
            {
                // Creamos una varible la cual leera el archivo en la ruta especificada
                string contenido = File.ReadAllText("/Users/alejandro/desktop/prueba.docx");
                Console.WriteLine(contenido);

                //Lanzamos una excepcion
                throw new Exception("Lanzamos una Excepcion directa");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe");
            }

            finally
            {
                Console.WriteLine("Siempre se va ejecutar pase lo que pase");
            }
            // Continua con la ejecucion
            Console.WriteLine("El programa sigue ejecutando");
        }
    }
}