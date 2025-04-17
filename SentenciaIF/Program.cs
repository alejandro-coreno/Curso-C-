// Sentencia IF y ElSE IF
// Funciona para valorar condiciones

bool activo = true;

bool permiso = true;


if (activo && permiso && entramosComer("Restaurante 24 hrs"))
{ 
    Console.WriteLine("Entramos");
}

else 
{
    Console.WriteLine("No Entramos");
}

// Funciones para validar una condicion
static bool entramosComer(string nombre, int hora = 0) {
    if(nombre == "Restaurante" && hora > 8 && hora < 23)
        return true;

    else if (nombre == "Restaurante 24 hrs")
        return true;

    else
        return false;
}


// Invocamos la funcion 
