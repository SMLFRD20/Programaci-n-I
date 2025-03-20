using System;

public class Ruta
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int AsientosDisponibles { get; set; }
    public int Ventas { get; set; }

    public Ruta(string nombre, double precio, int asientosDisponibles)
    {
        Nombre = nombre;
        Precio = precio;
        AsientosDisponibles = asientosDisponibles;
        Ventas = 0;
    }

    public void VenderPasajes(int cantidad)
    {
        if (cantidad <= AsientosDisponibles)
        {
            Ventas += (int)(cantidad * Precio);
            AsientosDisponibles -= cantidad;
        }
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"{Nombre} {Ventas / (int)Precio} Pasajeros Ventas {Ventas} quedan {AsientosDisponibles} asientos disponibles");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Ruta platinum = new Ruta("Auto Bus Plantinum", 1000, 22);
        Ruta gold = new Ruta("Auto Bus Gold", 800, 15);

        platinum.VenderPasajes(5);
        gold.VenderPasajes(5);

        platinum.MostrarEstado();
        gold.MostrarEstado();
    }
}