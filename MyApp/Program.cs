// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!, Nico");

Cliente c1 = new Cliente();
Cliente c2 = new Cliente("Nicolas Magro", "La Arboleda", "3815791342", "Casita");

c1.listarCliente();
c2.listarCliente();

Pedido p1 = new Pedido(1, "Caja Rota", "Nicolas Magro", "La Arboleda", "3815791342", "Casita", "En viaje");

p1.ListarPedido();