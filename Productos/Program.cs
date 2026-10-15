using System;

class Producto
{
    public string nombre;
    public double precio;

    public virtual void Mostrar()
    {
        Console.WriteLine("Producto: " + nombre);
        Console.WriteLine("Precio: " + precio);
    }
}

class Papel : Producto
{
    public int hojas;

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine("Hojas: " + hojas);
    }
}

class Utensilio : Producto
{
    public string material;

    public override void Mostrar()
    {
        base.Mostrar();
        Console.WriteLine("Material: " + material);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Papel p = new Papel();

        Console.WriteLine("Ingrese los Datos del Cuaderno");

        Console.Write("Nombre: ");
        p.nombre = Console.ReadLine();

        Console.Write("Precio: ");
        p.precio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Cantidad de hojas: ");
        p.hojas = Convert.ToInt32(Console.ReadLine());

        Utensilio u = new Utensilio();

        Console.WriteLine("\nDatos del utensilio");

        Console.Write("Nombre: ");
        u.nombre = Console.ReadLine();

        Console.Write("Precio: ");
        u.precio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Material: ");
        u.material = Console.ReadLine();

        Console.WriteLine("\n=== DATOS INGRESADOS ===");

        p.Mostrar();

        Console.WriteLine();

        u.Mostrar();

        Console.ReadKey();
    }
}
