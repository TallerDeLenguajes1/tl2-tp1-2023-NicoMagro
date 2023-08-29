using System.Linq;

public class Cadeteria
{
    private string Nombre;
    private string Telefono;
    private List<Pedido> pedidos;
    private List<Cadete> Cadetes;

    public Cadeteria()
    {
        this.Nombre = "";
        this.Telefono = "";
        this.Cadetes = new List<Cadete>();
        this.pedidos = new List<Pedido>();
    }

    public Cadeteria(string Nombre, string Telefono)
    {
        this.Nombre = Nombre;
        this.Telefono = Telefono;
        this.Cadetes = new List<Cadete>();
        this.pedidos = new List<Pedido>();
    }

    public string getNombre()
    {
        return this.Nombre;
    }

    public string getTelefono()
    {
        return this.Telefono;
    }

    public void agregarCadete(Cadete c)
    {
        this.Cadetes.Add(c);
        System.Console.WriteLine("Cadete Agregado.");
    }

    public void eliminarCadete(Cadete c)
    {
        this.Cadetes.Remove(c);
        System.Console.WriteLine("Cadete eliminado");
    }

    public int verCantidadPedidosSinCadete()
    {
        return this.pedidos.Count;
    }

    public int verCantidadPedidosConCadete()
    {
        int cant = 0;
        foreach (Cadete cad in this.Cadetes)
        {
            cant = cant + cad.pedidos.Count;
        }

        return cant;
    }

    public void informe()
    {
        System.Console.WriteLine("Nombre de la cadeteria: " + this.Nombre);
        System.Console.WriteLine("Telefono: " + this.Telefono);
        System.Console.WriteLine("Datos de Cadetes con sus respectivos Pedidos y Clientes: \n");

        foreach (Cadete c in this.Cadetes)
        {
            c.listarPedidos();
        }
    }

    public void asignarPedidoACadete(Cadete c)
    {
        if (c.pedidos.Count == 0)
        {
            System.Console.WriteLine("No hay pedidos para asignarle al cadete");
        }
        else
        {
            c.agregarPedido(this.pedidos[0]);
            c.pedidos.RemoveAt(0);
        }
    }

    public void eliminarPedidoACadete(Pedido p, Cadete c)
    {
        if (this.Cadetes.Contains(c))
        {
            if (c.pedidos.Contains(p) && p.Observacion == "Entregado")
            {
                c.pedidos.Remove(p);
                System.Console.WriteLine("Pedido Eliminado");
            }
            else if (c.pedidos.Contains(p) && p.Observacion != "Entregado")
            {
                this.pedidos.Add(p);
                c.pedidos.Remove(p);
                System.Console.WriteLine("Pedido Eliminado");
            }
            else
            {
                System.Console.WriteLine("El pedido ingresado no se encuentra entre los pedidos del cadete");
            }
        }
        else
        {
            System.Console.WriteLine("El cadete no pertenece a esta cadeteria.");
        }
    }
}