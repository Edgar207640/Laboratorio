
using System;

class Program
{
    static void Main()
    {
        // *Parte 1: Declaración y Uso de Variables*
        Console.WriteLine("----- PARTE 1: Declaración y Uso de Variables -----");

        // Declaración de variables
        int numeroEntero;
        double numeroDecimal;
        string texto;
        bool valorBooleano;

        // Entrada de datos
        Console.Write("Ingresa un número entero: ");
        numeroEntero = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa un número decimal: ");
        numeroDecimal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa un texto: ");
        texto = Console.ReadLine();

        Console.Write("Ingresa un valor verdadero o falso (true/false): ");
        valorBooleano = Convert.ToBoolean(Console.ReadLine());

        // Salida de datos
        Console.WriteLine("\n--- Valores Ingresados ---");
        Console.WriteLine($"Número entero: {numeroEntero}");
        Console.WriteLine($"Número decimal: {numeroDecimal}");
        Console.WriteLine($"Texto: {texto}");
        Console.WriteLine($"Valor booleano: {valorBooleano}");

        // *Parte 2: Operaciones Matemáticas*
        Console.WriteLine("\n----- PARTE 2: Operaciones Matemáticas -----");

        // Entrada de datos
        Console.Write("Ingresa el primer número entero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número entero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Operaciones matemáticas
        Console.WriteLine($"\nSuma: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"División: {num1} / {num2} = {(num2 != 0 ? (num1 / (double)num2).ToString() : "No se puede dividir entre 0")}");

        // Otras operaciones con diferentes tipos de datos
        float numFloat = 5.5f, numFloat2 = 2.3f;
        decimal numDecimal1 = 10.25m, numDecimal2 = 3.75m;
        Int16 numShort1 = 1000, numShort2 = 500;
        byte numByte1 = 200, numByte2 = 50;

        Console.WriteLine($"\nSuma con float: {numFloat} + {numFloat2} = {numFloat + numFloat2}");
        Console.WriteLine($"Suma con decimal: {numDecimal1} + {numDecimal2} = {numDecimal1 + numDecimal2}");
        Console.WriteLine($"Suma con Int16: {numShort1} + {numShort2} = {numShort1 + numShort2}");
        Console.WriteLine($"Suma con byte: {numByte1} + {numByte2} = {numByte1 + numByte2}");

        // *Parte 3: Operaciones Lógicas*
        Console.WriteLine("\n----- PARTE 3: Operaciones Lógicas -----");

        // Entrada de datos
        Console.Write("Ingresa el primer número para comparar: ");
        int valor1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número para comparar: ");
        int valor2 = Convert.ToInt32(Console.ReadLine());

        // Comparaciones
        Console.WriteLine($"\n¿{valor1} es mayor que {valor2}? {valor1 > valor2}");
        Console.WriteLine($"¿{valor1} es menor que {valor2}? {valor1 < valor2}");
        Console.WriteLine($"¿{valor1} es igual a {valor2}? {valor1 == valor2}");

        // Operadores lógicos
        Console.WriteLine($"\nUso de AND (&&): ({valor1} > 0) && ({valor2} > 0) = {(valor1 > 0 && valor2 > 0)}");
        Console.WriteLine($"Uso de OR (||): ({valor1} < 0) || ({valor2} < 0) = {(valor1 < 0 || valor2 < 0)}");

        // Evita que la consola se cierre
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}