using System;
using System.Collections.Generic;

public abstract class Llamada
{
    public string NumOrigen { get; set; }
    public string NumDestino { get; set; }
    public double Duracion { get; set; }

    public Llamada(string numOrigen, string numDestino, double duracion)
    {
        NumOrigen = numOrigen;
        NumDestino = numDestino;
        Duracion = duracion;
    }

    public abstract double CalcularPrecio();
}

public class LlamadaLocal : Llamada
{
    private const double PrecioPorSegundo = 0.15;

    public LlamadaLocal(string numOrigen, string numDestino, double duracion)
        : base(numOrigen, numDestino, duracion) { }

    public override double CalcularPrecio() => Duracion * PrecioPorSegundo;
}

public class LlamadaProvincial : Llamada
{
    private static readonly double[] PreciosPorFranja = { 0.20, 0.25, 0.30 };
    public int Franja { get; set; }

    public LlamadaProvincial(string numOrigen, string numDestino, double duracion, int franja)
        : base(numOrigen, numDestino, duracion)
    {
        Franja = franja;
    }

    public override double CalcularPrecio() => Duracion * PreciosPorFranja[Franja - 1];
}

public class Centralita
{
    private List<Llamada> llamadas = new List<Llamada>();

    public void RegistrarLlamada(Llamada llamada) => llamadas.Add(llamada);

    public int GetTotalLlamadas() => llamadas.Count;

    public double GetTotalFacturacion()
    {
        double total = 0;
        foreach (var llamada in llamadas)
            total += llamada.CalcularPrecio();
        return total;
    }
}

public class Practica2
{
    public static void Main(string[] args)
    {
        Centralita centralita = new Centralita();

        centralita.RegistrarLlamada(new LlamadaLocal("8091234567", "8299876543", 120));
        centralita.RegistrarLlamada(new LlamadaProvincial("8491234567", "8099876543", 60, 1));
        centralita.RegistrarLlamada(new LlamadaProvincial("8291234567", "8499876543", 90, 2));

        Console.WriteLine($"Total de llamadas: {centralita.GetTotalLlamadas()}");
        Console.WriteLine($"Facturación total: {centralita.GetTotalFacturacion():C2}");
    }
}