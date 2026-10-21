// Programa 8
// Mostrar una cuenta regresiva desde un número hasta 0 utilizando dos métodos que se llaman entre sí.

class Program
{
    static void CuentaA(int n)
    {
        if (n < 0)
        {
            return;
        }
        else
        {
            Console.WriteLine("A: " +  n);
            CuentaB(n - 1);
        }
    }

    static void CuentaB(int n)
    {
        if (n < 0)
        {
            return;
        }
        else
        {
            Console.WriteLine("B: " + n);
            CuentaA(n - 1);
        }
    }

    static void Main()
    {
        Console.Write("Ingrese un número entero positivo: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 100)
        {
            Console.WriteLine("El numero debe estar entre 0 y 1000.");
            return;
        }

        CuentaA(n);
    }
}