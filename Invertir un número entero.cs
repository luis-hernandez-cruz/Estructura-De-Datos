// Programa 5
// Invertir el orden de los digitos de un número entero positivo mediante llamadas recursivas.
using System.Text;

class Program
{
    static long Invertir(long n, long resultado = 0)
    {
        if (n == 0)
        {
            return resultado;
        }
        else
        {
            return Invertir(n / 10, resultado * 10 + n % 10);
        }
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Ingrese un número positivo: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("El número no puede ser menor a 0.");
            return;
        }

        Console.WriteLine("Número invertido: " + Invertir(n));
    }
}
