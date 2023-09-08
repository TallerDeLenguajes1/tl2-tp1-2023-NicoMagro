﻿// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!, Nico");

var accesoCSV = new AccesoCSV();
var accesoJSON = new AccesoJSON();

var listaCadeteria = new Cadeteria();
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
            PreguntaCargaArchivos();
            break;
    }

    InicioInterfaz();
}

void InicioInterfaz()
{
    Console.Clear();
    System.Console.WriteLine("HOLA :)");
    System.Console.WriteLine("Opciones para elegir: ");
    System.Console.WriteLine("1) Agregar un cadete a una cadeteria.");
    System.Console.WriteLine("2) Eliminar un cadete de una cadeteria.");
    System.Console.WriteLine("3) Asignar un cadete a un pedido.");
    System.Console.WriteLine("4) Reemplazar un cadete de un pedido.");
    System.Console.WriteLine("5) Listar Cadetes.");
    System.Console.WriteLine("6) Listar Pedidos.");
    System.Console.WriteLine("7) Crear Pedido.");
    System.Console.WriteLine("8) Crear Cadete.");
    System.Console.WriteLine("\n======= ELIJA UNA OPCION =======");
    var respuesta = Console.ReadLine();

    switch (respuesta)
    {
        case "1":
            agregarCadeteCadeteria();
            break;
        default:
            System.Console.WriteLine("Debe elegir una opcion valida.");
            break;
    }
}

void agregarCadeteCadeteria()
{
    System.Console.WriteLine("======== LISTADO DE CADETES ========\n");
    foreach (Cadete c in listaCadetes)
    {
        c.listarCadete();
        System.Console.WriteLine("\n");
    }

    System.Console.WriteLine("======== MOSTRANDO CADETERIA ========");

    listaCadeteria.listarCadeteria();

    System.Console.WriteLine("Elige el id de algun cadete para inscribirlo en la cadeteria: ");
    var id_cadete = int.Parse(Console.ReadLine());

    try
    {
        foreach (Cadete c in listaCadetes)
        {
            if (c.Id == id_cadete)
            {
                listaCadeteria.agregarCadete(c);
            }
        }
    }
    catch (System.Exception)
    {
        System.Console.WriteLine("No se encontraron datos que coincidan con los datos ingresados.");
        throw;
    }
    System.Console.WriteLine("Desea ingresar otro cadete a la cadeteria?\n 1 -> SI; 2 -> NO\n");
    string r = Console.ReadLine();
    if (r == "1")
    {
        agregarCadeteCadeteria();
    }
    else
    {
        InicioInterfaz();
    }
}