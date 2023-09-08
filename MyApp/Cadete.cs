using System.Globalization;

public class Cadete
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }

    public Cadete()
    {
        this.Id = 0;
        this.Nombre = "";
        this.Direccion = "";
        this.Telefono = "";
    }

    public Cadete(int id, string nombre, string direccion, string telefono)
    {
        this.Id = id;
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.Telefono = telefono;
    }

    public string getNombre()
    {
        return this.Nombre;
    }

    public string getDireccion()
    {
        return this.Direccion;
    }

    public string getTelefono()
    {
        return this.Telefono;
    }

    public void listarCadete()
    {
        System.Console.WriteLine("------CADETE------");
        System.Console.WriteLine($"ID: {this.Id}");
        System.Console.WriteLine($"Nombre: {this.getNombre()}");
        System.Console.WriteLine($"Direccion: {this.getDireccion()}");
        System.Console.WriteLine($"Telefono: {this.getTelefono()}");
    }
}