ushort N;//almacena el numero para  calcular su !
ushort factorial = 1, m = 1;//tipo de dato de enteros positivos 

try
{

    Console.WriteLine("inrese un numero entero mayor a 0");
    N = Convert.ToUInt16(Console.ReadLine());
    if (N > 0)
    {
        for (ushort i = 1; i <= N; i++)
        {
            factorial *= i; //calcula el factorial de un numero 

            if ((i <= N) && (i % 3 == 0))
            {
                Console.WriteLine($"los valores menores o iguales y divisibles en 3 del numero ingresado es {i}");

            }
            if ((i <= N) && (i % 5 == 0))
            {

                Console.WriteLine($"los valores menores o iguales y divisibles en 5 del numero ingresado es {i}");

            }
            if (m <= N)
            {
                m += 2;//incremento en 2
                Console.WriteLine(" números enteros positivos que comienzan en 1 y se incrementan en 2 hasta que se alcance un valor mayor que N es " + m);
            }

        }

        Console.WriteLine($"el  {N}! es {factorial}");
    }
    else
    { Console.WriteLine("ingrese un valor mayor a 0");}
}
catch (Exception e)
{
    Console.WriteLine("ERROR, Ingrese un numero entero mayor a 0");
    Console.WriteLine("la exepcion es: " + e.Message);
}
