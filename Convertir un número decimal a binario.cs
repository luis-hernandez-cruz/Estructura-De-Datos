// Programa 10
// Convertir un número entero no negativo a si representación binaria usando dos métodos que se llaman mutuamente

class Program
{
    static void BinarioA(int n)
    {
        if (n < 2)
        {
            Console.Write(n);
            return;
        }
        else
        {
            BinarioB(n / 2);
            Console.Write(n % 2);
        }
    }

    static void BinarioB(int n)
    {
        if (n < 2)
        {
            Console.Write(n);
            return;
        }
        else
        {
            BinarioA(n / 2);
            Console.Write(n % 2);
        }
    }

    static void Main()
    {
        Console.Write("Ingrese un numero: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("El numero no puede ser negativo.");
            return;
        }

        if (n == 0)
        {
            Console.Write("0");
        }
        else
        {
            BinarioA(n);
        }

        Console.WriteLine();
    }
}