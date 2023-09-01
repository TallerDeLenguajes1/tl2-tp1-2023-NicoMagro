using System.Globalization;

public class Cadete
{
    public int id;
    private string nombre;
    private string direccion;
    private string telefono;

    public Cadete()
    {
        this.id = 0;
        this.nombre = "";
        this.direccion = "";
        this.telefono = "";
    }

    public Cadete(int id, string nombre, string direccion, string telefono)
    {
        this.id = id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
    }

    public string getNombre()
    {
        return this.nombre;
    }

    public string getDireccion()
    {
        return this.direccion;
    }

    public string getTelefono()
    {
        return this.telefono;
    }
}