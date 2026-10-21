// Programa 1
// Calcular el factorial de un número entero no negativo.
class Program
{
    static long Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese un numero entre 1 y 20: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0 || n > 20)
        {
            Console.WriteLine("El numero debe estar entre 1 y 20.");
            return;
        }

        Console.WriteLine("Factorial: " + Factorial(n));
    }
}