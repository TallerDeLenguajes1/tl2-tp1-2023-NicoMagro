public class Pedido
{
    public int Numero;
    public string Observacion;
    private Cliente cliente;
    public string Estado;
    private Cadete cadete;

    public Pedido()
    {
        this.Numero = 0;
        this.Observacion = "";
        this.cliente = new Cliente();
        this.Estado = "";
        this.cadete = new Cadete();
    }

    public Pedido(int nro, string Observacion, string nombre, string direccion, string telefono, string datosReferenciaDireccion, string estado)
    {
        this.Numero = nro;
        this.Observacion = Observacion;
        this.cliente = new Cliente(nombre, direccion, telefono, datosReferenciaDireccion);
        this.Estado = estado;
        this.cadete = new Cadete();
    }

    public string VerDireccionCliente()
    {
        return this.cliente.getDireccion();
    }

    public void VerDatosCliente()
    {
        this.cliente.listarCliente();
    }

    public void asignarCadete(Cadete cad)
    {
        this.cadete = cad;
        System.Console.WriteLine("se agrego un cadete al pedido.");
    }

    public int getIdCadete()
    {
        return this.cadete.Id;
    }

    public void ListarPedido()
    {
        System.Console.WriteLine(
            "Datos del Pedido \n" +
            "Numero: " + this.Numero + "\n" +
            "Observacion: " + this.Observacion + "\n" +
            "Estado: " + this.Estado + "\n" +
            "Datos del cliente: \n" +
            "Nombre:" + this.cliente.getNombre() + "\n" +
            "Direccion: " + this.cliente.getDireccion() + "\n" +
            "Telefono: " + this.cliente.getTelefono() + "\n" +
            "Datos Referencia Direccion: " + this.cliente.getDatosReferenciaDireccion() + "\n"
        );
    }
}