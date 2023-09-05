// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!, Nico");

var accesoCSV = new AccesoCSV();
var accesoJSON = new AccesoJSON();

var listaCadeteria = new List<Cadeteria>();
var listaCadetes = new List<Cadete>();

PreguntaCargaArchivos();

void PreguntaCargaArchivos()
{
    Console.WriteLine("Como desea realizar la carga de los archivos?");
    Console.WriteLine("1) archivo CSV");
    Console.WriteLine("2) archivo JSON");
    string respuesta = Console.ReadLine();
    switch (respuesta)
    {
        case "1":
            listaCadeteria = accesoCSV.leerCadeteria();
            listaCadetes = accesoCSV.leerCadete();
            break;
        case "2":
            listaCadeteria = accesoJSON.leerCadeteria();
            listaCadetes = accesoJSON.leerCadete();
            break;

        default:
            Console.WriteLine("Ingresa un numero valido.");
            break;
    }

    InicioInterfaz();
}

void InicioInterfaz()
{
    Console.WriteLine("HOLA :)");
}