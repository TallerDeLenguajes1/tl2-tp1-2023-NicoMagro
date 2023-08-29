// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!, Nico");

string ubicacionCadeteria = "/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadeteria.csv";
System.IO.StreamReader archivo = new System.IO.StreamReader(ubicacionCadeteria);
string separador = ",";
string linea;
archivo.ReadLine();
linea = archivo.ReadLine();
string[] fila = linea.Split(separador);
string nombreCadeteria = fila[0];
string telefonoCadeteria = fila[1];
System.Console.WriteLine("Nombre {0}, Telefono {1}", nombreCadeteria, telefonoCadeteria);
Cadeteria cadeteria1 = new Cadeteria("Cdetes buenos", "4750843");

string ubicacionCadete = "/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadetes.csv";
System.IO.StreamReader archivo1 = new System.IO.StreamReader(ubicacionCadete);
archivo1.ReadLine();

Cadete c1 = new Cadete();
Cadete c2 = new Cadete();

int i = 1;

while ((linea = archivo1.ReadLine()) != null)
{
    fila = linea.Split(separador);
    var id = Convert.ToInt32(fila[0]);
    string nombre = fila[1];
    string direccion = fila[2];
    string telefono = fila[3];
    System.Console.WriteLine("{0} {1} {2} {3}", id, nombre, telefono, direccion);
    c1 = new Cadete(id, nombre, direccion, telefono);
    i++;
}


Pedido p1 = new Pedido(1, "Caja Rota", "Nicolas Magro", "La Arboleda", "3815791342", "Casita", "En viaje");

Pedido p2 = new Pedido(2, "Pesado", "Pedro Pepito", "Recoleta", "3815791343", "Depto 4A", "Entregado");

c1.agregarPedido(p1);
c1.agregarPedido(p2);

//c.listarPedidos();

System.Console.WriteLine("Jornal a cobrar: $" + c1.jornalACobrar());


cadeteria1.agregarCadete(c1);

cadeteria1.informe();

cadeteria1.eliminarCadete(c1);

cadeteria1.informe();

cadeteria1.agregarCadete(c2);

cadeteria1.eliminarPedidoACadete(p1, c1);