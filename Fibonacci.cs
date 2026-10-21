// Programa 2
// Programa que determine el valor de una posición (entre 0 y 40) de la serie de Fibonacci.
using System.Text;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Ingrese la posición (entre 0 y 40): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 40)
        {
            Console.WriteLine("El número debe estar entre 0 y 40.");
            return;
        }

        Console.WriteLine("Fibonacci: " + Fibonacci(n));
    }
}