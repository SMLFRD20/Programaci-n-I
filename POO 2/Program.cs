using System;

class Motor
{
    private int litros_de_aceite;
    private int potencia;

    public Motor(int potencia)
    {
        this.potencia = potencia;
        this.litros_de_aceite = 0;
    }

    public int GetLitrosDeAceite() => litros_de_aceite;
    public int GetPotencia() => potencia;

    public void SetLitrosDeAceite(int litros) => litros_de_aceite = litros;
    public void SetPotencia(int potencia) => this.potencia = potencia;
}

class Coche
{
    private Motor motor;
    private string marca;
    private string modelo;
    private double precioAverias;

    public Coche(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.motor = new Motor(100);
        this.precioAverias = 0;
    }

    public Motor GetMotor() => motor;
    public string GetMarca() => marca;
    public string GetModelo() => modelo;
    public double GetPrecioAverias() => precioAverias;

    public void AcumularAveria(double importe) => precioAverias += importe;
}

class Garaje
{
    private Coche coche;
    private string averia;
    private int cochesAtendidos;

    public Garaje()
    {
        cochesAtendidos = 0;
    }

    public bool AceptarCoche(Coche coche, string averia)
    {
        if (this.coche != null)
            return false;

        this.coche = coche;
        this.averia = averia;
        cochesAtendidos++;
        return true;
    }

    public void DevolverCoche()
    {
        if (averia == "aceite")
        {
            int litrosActuales = coche.GetMotor().GetLitrosDeAceite();
            coche.GetMotor().SetLitrosDeAceite(litrosActuales + 10);
        }

        double importeAveria = new Random().NextDouble() * 100;
        coche.AcumularAveria(importeAveria);

        coche = null;
        averia = null;
    }
}

class PracticaPOO
{
    static void Main(string[] args)
    {
        Garaje garaje = new Garaje();
        Coche coche1 = new Coche("Toyota", "Corolla");
        Coche coche2 = new Coche("Honda", "Civic");

        int opcion;
        do
        {
            Console.WriteLine("1. Atender coche 1");
            Console.WriteLine("2. Atender coche 2");
            Console.WriteLine("3. Mostrar información de los coches");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (garaje.AceptarCoche(coche1, "aceite"))
                    {
                        garaje.DevolverCoche();
                        Console.WriteLine("Coche 1 atendido.");
                    }
                    else
                    {
                        Console.WriteLine("El garaje está ocupado.");
                    }
                    break;
                case 2:
                    if (garaje.AceptarCoche(coche2, "frenos"))
                    {
                        garaje.DevolverCoche();
                        Console.WriteLine("Coche 2 atendido.");
                    }
                    else
                    {
                        Console.WriteLine("El garaje está ocupado.");
                    }
                    break;
                case 3:
                    Console.WriteLine($"Coche 1: Marca: {coche1.GetMarca()}, Modelo: {coche1.GetModelo()}, Precio averías: {coche1.GetPrecioAverias()}, Litros de aceite: {coche1.GetMotor().GetLitrosDeAceite()}");
                    Console.WriteLine($"Coche 2: Marca: {coche2.GetMarca()}, Modelo: {coche2.GetModelo()}, Precio averías: {coche2.GetPrecioAverias()}, Litros de aceite: {coche2.GetMotor().GetLitrosDeAceite()}");
                    break;
                case 4:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 4);
    }
}