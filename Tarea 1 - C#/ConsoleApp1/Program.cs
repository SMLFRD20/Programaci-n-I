using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el ejercicio a ejecutar (1-10):");
            int ejercicio = int.Parse(Console.ReadLine());

            switch (ejercicio)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Ejercicio4();
                    break;
                case 5:
                    Ejercicio5();
                    break;
                case 6:
                    Ejercicio6();
                    break;
                case 7:
                    Ejercicio7();
                    break;
                case 8:
                    Ejercicio8();
                    break;
                case 9:
                    Ejercicio9();
                    break;
                case 10:
                    Ejercicio10();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void Ejercicio1()
        {
            Console.WriteLine("Ingrese un número entero de dos dígitos:");
            int numero = int.Parse(Console.ReadLine());
            int suma = Math.Abs(numero / 10) + Math.Abs(numero % 10);
            Console.WriteLine($"La suma de los dígitos es: {suma}");
        }

        static void Ejercicio2()
        {
            Console.WriteLine("Ingrese un número entero de dos dígitos:");
            int numero = int.Parse(Console.ReadLine());
            bool esPrimo = EsPrimo(Math.Abs(numero));
            Console.WriteLine($"¿Es primo? {esPrimo}, ¿Es negativo? {numero < 0}");
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Ingrese un número entero de dos dígitos:");
            int numero = int.Parse(Console.ReadLine());
            int digito1 = Math.Abs(numero / 10);
            int digito2 = Math.Abs(numero % 10);
            bool ambosPrimos = EsPrimo(digito1) && EsPrimo(digito2);
            Console.WriteLine($"¿Ambos dígitos son primos? {ambosPrimos}");
        }

        static void Ejercicio4()
        {
            Console.WriteLine("Ingrese el primer número entero de dos dígitos:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número entero de dos dígitos:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"¿La suma es par? {(num1 + num2) % 2 == 0}");
        }

        static void Ejercicio5()
        {
            Console.WriteLine("Ingrese un número entero de tres dígitos:");
            int numero = int.Parse(Console.ReadLine());
            int[] digitos = { Math.Abs(numero / 100), Math.Abs((numero / 10) % 10), Math.Abs(numero % 10) };
            int mayor = Math.Max(digitos[0], Math.Max(digitos[1], digitos[2]));
            Console.WriteLine($"La posición del mayor dígito es: {Array.IndexOf(digitos, mayor) + 1}");
        }

        static void Ejercicio6()
        {
            Console.WriteLine("Ingrese un número entero de tres dígitos:");
            int numero = int.Parse(Console.ReadLine());
            int[] digitos = { Math.Abs(numero / 100), Math.Abs((numero / 10) % 10), Math.Abs(numero % 10) };
            bool algunMultiplo = digitos[0] % digitos[1] == 0 || digitos[0] % digitos[2] == 0 || digitos[1] % digitos[2] == 0;
            Console.WriteLine($"¿Algún dígito es múltiplo de otro? {algunMultiplo}");
        }

        static void Ejercicio7()
        {
            Console.WriteLine("Ingrese el primer número entero:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número entero:");
            int b = int.Parse(Console.ReadLine());
            a = Math.Max(a, b);
            Console.WriteLine($"El mayor número es: {a}");
        }

        static void Ejercicio8()
        {
            Console.WriteLine("Ingrese un número entero de cinco dígitos:");
            string numero = Console.ReadLine();
            string reverso = new string(numero.Reverse().ToArray());
            Console.WriteLine($"¿Es capicúa? {numero == reverso}");
        }

        static void Ejercicio9()
        {
            Console.WriteLine("Ingrese un número entero de cuatro dígitos:");
            string numero = Console.ReadLine();
            Console.WriteLine($"¿El segundo dígito es igual al penúltimo? {numero[1] == numero[2]}");
        }

        static void Ejercicio10()
        {
            Console.WriteLine("Ingrese el primer número entero:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número entero:");
            int num2 = int.Parse(Console.ReadLine());

            int menor = Math.Min(num1, num2);
            int mayor = Math.Max(num1, num2);

            if (mayor - menor <= 10)
            {
                for (int i = menor; i <= mayor; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("La diferencia es mayor a 10.");
            }
        }

        static bool EsPrimo(int numero)
        {
            if (numero < 2) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}
