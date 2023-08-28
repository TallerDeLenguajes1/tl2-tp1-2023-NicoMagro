using System.Reflection.Metadata;

public class Cliente
{
    private string Nombre;
    private string Direccion;
    private string Telefono;
    private string DatosReferenciaDireccion;


    public Cliente()
    {
        this.Nombre = "";
        this.Direccion = "";
        this.Telefono = "";
        this.DatosReferenciaDireccion = "";
    }

    public Cliente(string nombre, string direccion, string telefono, string datosreferenciadireccion)
    {
        this.Nombre = nombre;
        this.Direccion = direccion;
        this.Telefono = telefono;
        this.DatosReferenciaDireccion = datosreferenciadireccion;
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

    public string getDatosReferenciaDireccion()
    {
        return this.DatosReferenciaDireccion;
    }

    public void listarCliente()
    {
        System.Console.WriteLine(
            "Datos del Cliente: \n" +
            "Nombre del Cliente: " + this.Nombre + "\n" +
            "Direccion del Cliente: " + this.Direccion + "\n" +
            "Telefono del Cliente: " + this.Telefono + "\n" +
            "Datos Referencia Direccion: " + this.DatosReferenciaDireccion + "\n"
        );
    }
}