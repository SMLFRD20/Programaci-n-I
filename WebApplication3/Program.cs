using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        Console.WriteLine("Ingrese 10 números enteros:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nSeleccione el ejercicio a ejecutar (1-5):");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Ejercicio1(numeros);
                break;
            case 2:
                Ejercicio2(numeros);
                break;
            case 3:
                Ejercicio3(numeros);
                break;
            case 4:
                Ejercicio4(numeros);
                break;
            case 5:
                Ejercicio5(numeros);
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    static void Ejercicio1(int[] numeros)
    {
        int mayor = numeros[0];
        int posicion = 0;

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
                posicion = i;
            }
        }

        Console.WriteLine($"El mayor número es {mayor} y está en la posición {posicion + 1}.");
    }

    static void Ejercicio2(int[] numeros)
    {
        int mayorPar = -1;
        int posicion = -1;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0 && numeros[i] > mayorPar)
            {
                mayorPar = numeros[i];
                posicion = i;
            }
        }

        if (posicion != -1)
            Console.WriteLine($"El mayor número par es {mayorPar} y está en la posición {posicion + 1}.");
        else
            Console.WriteLine("No se encontraron números pares.");
    }

    static void Ejercicio3(int[] numeros)
    {
        int mayorPrimo = -1;
        int posicion = -1;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (EsPrimo(numeros[i]) && numeros[i] > mayorPrimo)
            {
                mayorPrimo = numeros[i];
                posicion = i;
            }
        }

        if (posicion != -1)
            Console.WriteLine($"El mayor número primo es {mayorPrimo} y está en la posición {posicion + 1}.");
        else
            Console.WriteLine("No se encontraron números primos.");
    }

    static void Ejercicio4(int[] numeros)
    {
        int contador = 0;

        foreach (int num in numeros)
        {
            int primerDigito = ObtenerPrimerDigito(num);
            if (EsPrimo(primerDigito))
            {
                contador++;
            }
        }

        Console.WriteLine($"{contador} números comienzan con un dígito primo.");
    }

    static void Ejercicio5(int[] numeros)
    {
        int maxDigitosPares = -1;
        int posicion = -1;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (EsPrimo(numeros[i]))
            {
                int digitosPares = ContarDigitosPares(numeros[i]);
                if (digitosPares > maxDigitosPares)
                {
                    maxDigitosPares = digitosPares;
                    posicion = i;
                }
            }
        }

        if (posicion != -1)
            Console.WriteLine($"El número primo con más dígitos pares es {numeros[posicion]} y está en la posición {posicion + 1}.");
        else
            Console.WriteLine("No se encontraron números primos.");
    }

    static bool EsPrimo(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    static int ObtenerPrimerDigito(int num)
    {
        while (num >= 10)
        {
            num /= 10;
        }
        return num;
    }

    static int ContarDigitosPares(int num)
    {
        int contador = 0;
        while (num != 0)
        {
            int digito = num % 10;
            if (digito % 2 == 0) contador++;
            num /= 10;
        }
        return contador;
    }
}