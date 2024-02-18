/*int numero = int.Parse("5");//el parse es para convertir int.Parse convierte a int//

    if (numero <0)
{
    Console.WriteLine("El numero es negativo");

}
else if (numero >0)
{
    Console.WriteLine("El numero es positivo ");
}
else
{
    Console.WriteLine("El numero es cero ");
}*/

/*int edad = int.Parse("18");
if (edad ==18)
{
    Console.WriteLine("Entre");

}
else
{
    Console.WriteLine("Puede entrar");
}*/

/*Console.WriteLine("Ingrese su año de nacimiento: ");
int año= int.Parse(Console.ReadLine());
switch(año) {
   case  >= 1928 and  <= 1945:
{
    Console.WriteLine("Usted pertenece a la feneracion silenciosa");
            break;
}
   case  >= 1946 and  <= 1964:
{
    Console.WriteLine("Usted pertenece a los baby boome");
            break;
        }
    case >= 1965 and  <= 1980:
{
    Console.WriteLine("Usted pertenece a la generacion X");
            break;
        }
    case  >= 1981 and  <= 1996:
{
    Console.WriteLine("Usted pertenece a la generacion de los millenial");
            break;
        }
    case  >= 1997 and  <= 2012:
{
    Console.WriteLine("Usted pertenece a la generacion Z");
        break;
}
    case  >= 2013:
    {
        Console.WriteLine("Usted pertenece a la generacion Alfa");
        break;
    }
    default: {
        Console.WriteLine("Año inválido");
            break;
    } }*/
string nombre, pais;
int edad;
char genero;

Console.WriteLine("Ingrese su nombre: ");
nombre = Console.ReadLine().ToUpper();
Console.WriteLine("Ingrese pais: ");
pais = Console.ReadLine();

Console.WriteLine("Ingrese su edad: ");
edad = Convert.ToInt32(Console.ReadLine().ToUpper());

Console.WriteLine("Ingrese su genero (m o f): ");
genero = char.Parse(Console.ReadLine().ToUpper());
if (!nombre.StartsWith("A") && (edad >= 18 || genero == 'F') && (pais == "GUATEMALA" || pais == "MEXICO"))
{
    Console.WriteLine("Ud. cumple con los requisitos  ");
}
else
{
    Console.WriteLine("No admitido");
}
