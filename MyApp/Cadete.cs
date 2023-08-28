using System.Globalization;

public class Cadete
{
    public int id;
    private string nombre;
    private string direccion;
    private string telefono;
    public List<Pedido> pedidos;

    public Cadete()
    {
        this.id = 0;
        this.nombre = "";
        this.direccion = "";
        this.telefono = "";
        this.pedidos = new List<Pedido>();
    }

    public Cadete(int id, string nombre, string direccion, string telefono)
    {
        this.id = id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        this.pedidos = new List<Pedido>();
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

    public float jornalACobrar()
    {
        float total = 0;
        foreach (Pedido p in pedidos)
        {
            total = total + 3000;
        }
        return total;
    }

    public void listarPedidos()
    {
        foreach (Pedido p in this.pedidos)
        {
            p.ListarPedido();
        }
    }

    public void agregarPedido(Pedido p)
    {
        this.pedidos.Add(p);
    }
}