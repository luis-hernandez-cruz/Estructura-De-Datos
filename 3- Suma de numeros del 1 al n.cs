// Programa 3
// Calcular la suma de todos los números desde el 1 hasta el n.
using System.Text;
class Program
{
    static int Suma(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else
        {
            return n + Suma(n - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Ingresa un número: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 10000)
        {
            Console.WriteLine("Ingresa un número entre 0 y 10000. ");
            return;
        }

        Console.WriteLine("La suma es " + Suma(n));
    }
}