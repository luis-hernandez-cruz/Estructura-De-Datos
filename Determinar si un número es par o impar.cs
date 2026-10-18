// Programa 7
// Determinar si un número entero no negativo es par o impar.

using System;

class Program
{
    static bool EsPar(int n)
    {
        if (n == 0)
        {
            return true;
        }
        else
        {
            return EsImpar(n - 1);
        }
    }

    static bool EsImpar(int n)
    {
        if (n == 0)
        {
            return false;
        }
        else
        {
            return EsPar(n - 1);
        }
    }

    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingrese un numero entre 0 y 10000.");
            return;
        }
        
        if (EsPar(n))
        {
            Console.WriteLine("El numero es par.");
        }
        else
        {
            Console.WriteLine("El numero es impar.");
        }
    }
}
