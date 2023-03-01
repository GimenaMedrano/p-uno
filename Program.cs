int N;//almacena el numero para  calcular su !
int factorial = 1;//tipo de dato de enteros positivos 

try
{
    Console.WriteLine("inrese un numero entero mayor a 0");
    N = Convert.ToInt32(Console.ReadLine());
    if (N > 0)
    {
        for (int i = 1; i <= N; i++)
        {
            factorial *= i; //calcula el factorial de un numero 

        }

        Console.WriteLine($"los valores menores o iguales y divisibles en 3 del numero ingresado son");
        for (int m = 1; m <= N; m++)
        {
            if ((m <= N) && (m % 3 == 0))
            {
                Console.WriteLine(m);
            }
        }

        Console.WriteLine($"los valores menores o iguales y divisibles en 5 del numero ingresado son");
        for (int j = 1; j <= N; j++)
        {
            if ((j <= N) && (j % 5 == 0))
            {
                Console.WriteLine(j);
            }
        }

        Console.WriteLine(" números enteros positivos que comienzan en 1 y se incrementan en 2 hasta que se alcance un valor mayor que N es ");
        for (int r=1; r <= N; r+=2)
        {
            
            Console.WriteLine(r);
        }
        Console.WriteLine($"El  {N}! del numero  es {factorial}");
    }
    else
    { Console.WriteLine("ingrese un valor mayor a 0"); }
}
catch (Exception e)
{
    Console.WriteLine("ERROR, Ingrese un numero entero mayor a 0");
    Console.WriteLine("la exepcion es: " + e.Message);
}
