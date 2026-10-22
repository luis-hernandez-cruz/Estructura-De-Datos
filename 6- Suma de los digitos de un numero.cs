// Programa 6
// Sumar todos los digitos de un número entero positivo.
using System.Text;

class Program
{
    static int SumarDigitos(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else
        {
            return n % 10 + SumarDigitos(n / 10);
        }
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Ingrese un número positivo: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("El número no puede ser inferior a 0.");
            return;
        }

        Console.WriteLine("Resultado: " + SumarDigitos(n));
    }
}