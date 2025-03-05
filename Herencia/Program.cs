using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Selecciona un ejemplo para ejecutar:");
            Console.WriteLine("1. Herencia básica");
            Console.WriteLine("2. Sobrescritura de métodos");
            Console.WriteLine("3. Herencia con constructores");
            Console.WriteLine("4. Herencia múltiple con interfaces");
            Console.WriteLine("5. Clase abstracta y herencia");
            Console.WriteLine("6. Salir");
            Console.Write("Opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        EjemploHerenciaBasica();
                        break;
                    case 2:
                        EjemploSobrescrituraMetodos();
                        break;
                    case 3:
                        EjemploHerenciaConstructores();
                        break;
                    case 4:
                        EjemploHerenciaInterfaces();
                        break;
                    case 5:
                        EjemploClaseAbstracta();
                        break;
                    case 6:
                        return; // Salir del programa
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Entrada no válida. Inténtalo de nuevo.");
            }
        }
    }

    // Ejemplo 1: Herencia básica
    static void EjemploHerenciaBasica()
    {
        Console.WriteLine("=== Ejemplo 1: Herencia básica ===");
        Coche miCoche = new Coche { Marca = "Toyota" };
        miCoche.Arrancar();
        miCoche.Acelerar();
    }

    class Vehiculo
    {
        public string Marca { get; set; }
        public void Arrancar() => Console.WriteLine("El vehículo está arrancando.");
    }

    class Coche : Vehiculo
    {
        public void Acelerar() => Console.WriteLine("El coche está acelerando.");
    }

    // Ejemplo 2: Sobrescritura de métodos
    static void EjemploSobrescrituraMetodos()
    {
        Console.WriteLine("=== Ejemplo 2: Sobrescritura de métodos ===");
        Animal miAnimal = new Perro();
        miAnimal.Sonido();
    }

    class Animal
    {
        public virtual void Sonido() => Console.WriteLine("El animal hace un sonido.");
    }

    class Perro : Animal
    {
        public override void Sonido() => Console.WriteLine("El perro ladra.");
    }

    // Ejemplo 3: Herencia con constructores
    static void EjemploHerenciaConstructores()
    {
        Console.WriteLine("=== Ejemplo 3: Herencia con constructores ===");
        Estudiante estudiante = new Estudiante("Juan", "Matemáticas");
        estudiante.Presentarse();
        estudiante.Estudiar();
    }

    class Persona
    {
        public string Nombre { get; set; }
        public Persona(string nombre) => Nombre = nombre;
        public void Presentarse() => Console.WriteLine($"Hola, mi nombre es {Nombre}.");
    }

    class Estudiante : Persona
    {
        public string Curso { get; set; }
        public Estudiante(string nombre, string curso) : base(nombre) => Curso = curso;
        public void Estudiar() => Console.WriteLine($"{Nombre} está estudiando {Curso}.");
    }

    // Ejemplo 4: Herencia múltiple con interfaces
    static void EjemploHerenciaInterfaces()
    {
        Console.WriteLine("=== Ejemplo 4: Herencia múltiple con interfaces ===");
        Pato pato = new Pato();
        pato.Volar();
        pato.Nadar();
    }

    interface IVolador
    {
        void Volar();
    }

    interface INadador
    {
        void Nadar();
    }

    class Pato : IVolador, INadador
    {
        public void Volar() => Console.WriteLine("El pato está volando.");
        public void Nadar() => Console.WriteLine("El pato está nadando.");
    }

    // Ejemplo 5: Clase abstracta y herencia
    static void EjemploClaseAbstracta()
    {
        Console.WriteLine("=== Ejemplo 5: Clase abstracta y herencia ===");
        Circulo circulo = new Circulo(5);
        Console.WriteLine($"El área del círculo es: {circulo.Area()}");
    }

    abstract class Figura
    {
        public abstract double Area();
    }

    class Circulo : Figura
    {
        public double Radio { get; set; }
        public Circulo(double radio) => Radio = radio;
        public override double Area() => Math.PI * Radio * Radio;
    }
}