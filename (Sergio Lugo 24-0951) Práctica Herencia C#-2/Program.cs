using System;
using System.Collections.Generic;

class Hamburguesa
{
    protected string tipoPan;
    protected string carne;
    protected double precioBase;
    protected List<(string, double)> ingredientes = new List<(string, double)>();
    protected int maxIngredientes = 4;

    public Hamburguesa(string tipoPan, string carne, double precioBase)
    {
        this.tipoPan = tipoPan;
        this.carne = carne;
        this.precioBase = precioBase * 63;
    }

    public virtual void AgregarIngrediente(string nombre, double precio)
    {
        if (ingredientes.Count < maxIngredientes)
        {
            ingredientes.Add((nombre, precio * 63));
        }
        else
        {
            Console.WriteLine("No se pueden agregar más ingredientes a esta hamburguesa.");
        }
    }

    public virtual void MostrarPrecio()
    {
        double precioTotal = precioBase;
        Console.WriteLine($"Hamburguesa con {carne} en pan {tipoPan}");
        Console.WriteLine($"Precio base: {precioBase:N2} DOP");
        foreach (var ing in ingredientes)
        {
            Console.WriteLine($"Ingrediente: {ing.Item1} - Precio: {ing.Item2:N2} DOP");
            precioTotal += ing.Item2;
        }
        Console.WriteLine($"Precio total: {precioTotal:N2} DOP\n");
    }
}

class HamburguesaSaludable : Hamburguesa
{
    public HamburguesaSaludable(string carne, double precioBase)
        : base("Integral", carne, precioBase)
    {
        maxIngredientes = 6;
    }
}

class HamburguesaPremium : Hamburguesa
{
    public HamburguesaPremium(string carne, double precioBase)
        : base("Pan de agua", carne, precioBase)
    {
        ingredientes.Add(("Tostones", 2.50 * 63)); //
        ingredientes.Add(("Jugo de chinola", 1.50 * 63)); //
    }

    public override void AgregarIngrediente(string nombre, double precio)
    {
        Console.WriteLine("No se pueden agregar ingredientes adicionales a la hamburguesa premium.");
    }
}

class Programa
{
    static void Main()
    {
        Hamburguesa clasica = new Hamburguesa("Pan de agua", "Res", 5.00);
        clasica.AgregarIngrediente("Lechuga", 0.50);
        clasica.AgregarIngrediente("Tomate", 0.75);
        clasica.MostrarPrecio();

        HamburguesaSaludable saludable = new HamburguesaSaludable("Salchicha", 6.00);
        saludable.AgregarIngrediente("Aguacate", 1.00);
        saludable.AgregarIngrediente("Repollo", 0.75);
        saludable.MostrarPrecio();

        HamburguesaPremium premium = new HamburguesaPremium("Salami", 8.00);
        premium.AgregarIngrediente("Bacon", 1.50);
        premium.MostrarPrecio();
    }
}
