using System;

class Ave
{
    public virtual void Volar()
    {
        Console.WriteLine("El ave está volando.");
    }

    public virtual void Comer()
    {
        Console.WriteLine("El ave está comiendo.");
    }
}

class Pato : Ave
{
    public override void Volar()
    {
        Console.WriteLine("El pato está volando sobre el lago.");
    }

    public override void Comer()
    {
        Console.WriteLine("El pato está comiendo pan en el agua.");
    }
}

class Aguila : Ave
{
    public override void Volar()
    {
        Console.WriteLine("El águila está volando a gran altura.");
    }

    public override void Comer()
    {
        Console.WriteLine("El águila está cazando para comer.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ave miPato = new Pato();
        Ave miAguila = new Aguila();

        miPato.Volar();
        miPato.Comer();

        miAguila.Volar();
        miAguila.Comer();
    }
}