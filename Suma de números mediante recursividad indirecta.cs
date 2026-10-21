// Programa 9
// Calcular la suma de los números desde 1 hasta n utilizando dos métodos que se llaman mutuamente.

class Program
{
    static int SumaA(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else
        {
            return n + SumaB(n - 1); 
        }
    }

    static int SumaB(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else
        {
            return SumaA(n - 1); // Si se agraga "n +" sale bien el resultado
        }
    }

    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 1000)
        {
            Console.WriteLine("El numero debe estar entre 0 y 1000.");
            return;
        }

        Console.WriteLine("La suma es: " + SumaA(n));
    }
}
