// Programa 4
// Calcular una potencia entera no negativa utilizando recursividad.

class Program
{
    static long Potencia(int baseNum, int exponente)
    {
        if (exponente == 0)
        {
            return 1;
        }
        else
        {
            return baseNum * Potencia(baseNum, exponente - 1);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese la base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el exponente (0 a 30): ");
        int exponente = int.Parse(Console.ReadLine());

        if (exponente < 0 || exponente > 30)
        {
            Console.WriteLine("Exponente fuera de rango.");
            return;
        }

        Console.Write("Resultado: " + Potencia(baseNum, exponente));
    }
}
