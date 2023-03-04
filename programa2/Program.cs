using System;

class Program
{
    static double Calculadora(string operacion, double num1, double num2)
    {
        try
        {
            switch (operacion.ToUpper())
            {
                case "SUMA":
                    return num1 + num2;
                case "RESTA":
                    return num1 - num2;
                case "MULTIPLICACION":
                    return num1 * num2;
                case "DIVISION":
                    return num2 == 0 ? -1 : num1 / num2;
                default:
                    throw new ArgumentException("Operación no válida.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            return double.NaN;
        }
    }

    static void Main()
    {
        Console.Write("Ingrese la operación a realizar (SUMA, RESTA, MULTIPLICACION, DIVISION): ");
        string operacion = Console.ReadLine();

        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = Calculadora(operacion, num1, num2);

        if (!double.IsNaN(resultado))
        {
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
