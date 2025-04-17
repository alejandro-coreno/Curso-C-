// Sentencia Switch
// Permite  evaluar mas escenarios en caso


int op = 8;


switch( op )
{
    case 1: 
        Console.WriteLine("Seleccionaste el numero 1:");
        break;
    case 2: 
        Console.WriteLine("Seleccionaste el numero 2: ");
        break;

    case 3:
    case 4:
        Console.WriteLine("Caso 3 y 4");
        break;

    case < 0:
        Console.WriteLine("Fuera de rango");
        break;

    case > 0 and <10:
        Console.WriteLine("Opccion de rango mayor que 0 i menor que 10");
        break;
    default: 
        Console.WriteLine("Opcion por default");
        break;

}
