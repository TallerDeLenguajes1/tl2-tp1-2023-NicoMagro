// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!, Nico");

Pedido p1 = new Pedido(1, "Caja Rota", "Nicolas Magro", "La Arboleda", "3815791342", "Casita", "En viaje");

Pedido p2 = new Pedido(2, "Pesado", "Pedro Pepito", "Recoleta", "3815791343", "Depto 4A", "Entregado");

Cadete c = new Cadete(1, "Angel", "FELE", "3815791342");

c.agregarPedido(p1);
c.agregarPedido(p2);

//c.listarPedidos();

System.Console.WriteLine("Jornal a cobrar: $" + c.jornalACobrar());

Cadeteria cadeteria1 = new Cadeteria("Cdetes buenos", "4750843");

cadeteria1.agregarCadete(c);

cadeteria1.informe();

cadeteria1.eliminarCadete(c);

cadeteria1.informe();

cadeteria1.agregarCadete(c);

cadeteria1.eliminarPedidoACadete(p1, c);