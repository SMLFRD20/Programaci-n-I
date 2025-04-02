using System;
using System.Collections.Generic;

class Llamada
{
    public string NumeroOrigen { get; set; }
    public string NumeroDestino { get; set; }
    public int Duracion { get; set; }
    public double Costo { get; set; }

    public Llamada(string numeroOrigen, string numeroDestino, int duracion, double costo)
    {
        NumeroOrigen = numeroOrigen;
        NumeroDestino = numeroDestino;
        Duracion = duracion;
        Costo = costo * 63;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Origen: {NumeroOrigen} - Destino: {NumeroDestino} - Duración: {Duracion} segundos - Costo: {Costo:N2} DOP");
    }
}

class Centralita
{
    private List<Llamada> registros = new List<Llamada>();

    public void RegistrarLlamada(string origen, string destino, int duracion, double costo)
    {
        registros.Add(new Llamada(origen, destino, duracion, costo));
        Console.WriteLine("Llamada registrada con éxito.");
    }

    public void MostrarRegistros()
    {
        Console.WriteLine("\nRegistros de llamadas:");
        foreach (var llamada in registros)
        {
            llamada.MostrarInfo();
        }
    }
}

class Programa
{
    static void Main()
    {
        Centralita centralita = new Centralita();
        centralita.RegistrarLlamada("809-555-1234", "829-555-5678", 120, 15.75);
        centralita.RegistrarLlamada("849-777-4321", "809-333-7890", 300, 45.50);
        centralita.MostrarRegistros();
    }
}