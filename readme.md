Taller de Lenguajes II
Trabajo Practico 1

**¿Cuál de estas relaciones considera que se realiza por composición y cuál por agregación?**

A partir del diseño de clases se pueden encontrar 3 relaciones:

- Cadeteria - Cadete: Agregacion
- Cadete - Pedidos: Agregacion
- Pedidos - Cliente: Composicion

La relacion Cadeteria - Cadete es una relacion de Agregacion ya que la cadeteria puede ir rotando de cadetes Agregando o eliminando los que ya tiene, pero la existencia de estos ultimos no se ve afectada por la existencia de la cadeteria.

La relacion Cadete - Pedidos es una relacion de Agregacion porque la entrega de un pedido puede pasar de un cadete a otro segun se necesite. Su existencia no depende del cadete.

La relacion Pedidos - Cliente es una relacion de Composicion debido a que un cliente no puede ser cliente de la cadeteria si es que no realizo un pedido. Por lo tanto una vez se realiza el pedido se crea una instancia del cliente ligada a ese pedido.

**¿Qué métodos considera que debería tener la clase Cadetería y la clase Cadete?**

_Metodos de la clase Cadeteria:_

AgregarCadete(Cadete c);
EliminarCadete(Cadete c);
CrearPedido(int nroPedido, string obs, datosCliente, string estado);
VerCantPedidos();
ListarPedidos();

_Metodos de la clase Cadetes_

JornalACobrar();
ListarPedidos();

**Teniendo en cuenta los principios de abstracción y ocultamiento, que atributos,**
**propiedades y métodos deberían ser públicos y cuáles privados.**

Atributos de los clientes: Todo Privado

Atributos de los pedidos:

- Nro, Obs, Estado: Publicos
- Cliente: Privado

Atributos de los cadetes:

- ID, ListadoPedidos: Publicos
- Nombre, Direccion, Telefono: Privado

Atributos de la cadeteria: Todo Privado

Propiedades para todos los atributos Privados

Metodos todos publicos

**¿Cómo diseñaría los constructores de cada una de las clases?**

Diseñaría un constructor vacio y otro sobrecargado para caada una de las clases.

**¿Se le ocurre otra forma que podría haberse realizado el diseño de clases?**
