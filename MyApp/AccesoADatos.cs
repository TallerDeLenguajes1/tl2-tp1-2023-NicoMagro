using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;


public class AccesoADatos
{
    public AccesoADatos()
    {
    }

    public virtual void leerCadete()
    {
        System.Console.WriteLine("Metodo por defecto de lectura.");
    }

    public virtual void leerCadeteria()
    {
        System.Console.WriteLine("Metodo por defecto de lectura.");
    }
}

public class AccesoCSV : AccesoADatos
{
    public AccesoCSV(string rutaArchivo) : base()
    {

    }

    public override void leerCadeteria()
    {
        try
        {
            using (var reader = new StreamReader("/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadeteria.csv"))
            {
                Console.WriteLine("Datos desde CSV:");

                // Leo la primera linea para saltear los datos de las columnas
                // y para establecer la cantidad maxima de datos que pueden haber.
                var encabezados = reader.ReadLine()?.Split(',');

                if (encabezados != null)
                {
                    while (!reader.EndOfStream)
                    {
                        var linea = reader.ReadLine();
                        var valores = linea.Split(',');
                        var listaCadeteria = new List<Cadeteria>();
                        if (valores.Length == encabezados.Length)
                        {
                            var cadeteria = new Cadeteria(valores[0], valores[1]);

                            listaCadeteria.Add(cadeteria);

                            Console.WriteLine($"Cadeteria: {valores[0]}, Telefono: {valores[1]}");
                        }
                        else
                        {
                            Console.WriteLine("La línea no tiene el formato correcto.");
                        }
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"El archivo CSV en la ruta '{"/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadeteria.csv"}' no fue encontrado.");
        }
    }



    public override void leerCadete()
    {
        try
        {
            using (var reader = new StreamReader("/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadetes.csv"))
            {
                Console.WriteLine("Datos desde CSV:");

                // Leo la primera linea para saltear los datos de las columnas
                // y para establecer la cantidad maxima de datos que pueden haber.
                var encabezados = reader.ReadLine()?.Split(',');

                if (encabezados != null)
                {
                    var listaCadetes = new List<Cadete>();
                    while (!reader.EndOfStream)
                    {
                        var linea = reader.ReadLine();
                        var valores = linea.Split(',');

                        if (valores.Length == encabezados.Length)
                        {
                            var cadete = new Cadete(int.Parse(valores[0]), valores[1], valores[2], valores[3]);
                            listaCadetes.Add(cadete);
                            Console.WriteLine($"ID: {int.Parse(valores[0])}, Nombre: {valores[1]}, Dirección: {valores[2]}, Teléfono: {valores[3]}");
                        }
                        else
                        {
                            Console.WriteLine("La línea no tiene el formato correcto.");
                        }
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"El archivo CSV en la ruta '{"/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadetes.csv"}' no fue encontrado.");
        }
    }
}

public class AccesoJSON : AccesoADatos
{
    public AccesoJSON(string rutaArchivo) : base()
    {

    }

    public override void leerCadeteria()
    {
        try
        {
            var json = File.ReadAllText("/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadeteria.json");
            //Deserealizo el archivo
            List<Cadeteria> cadeteria = JsonSerializer.Deserialize<List<Cadeteria>>(json);

            Console.WriteLine("Datos desde JSON:");
            Console.WriteLine(json);
        }
        catch (FileNotFoundException)
        {
            System.Console.WriteLine($"El archivo CSV en la ruta '{"/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadeteria.json"}' no fue encontrado.");
        }
    }

    public override void leerCadete()
    {
        try
        {
            var json = File.ReadAllText("/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadetes.json");
            //Deserealizo el archivo en una lista de cadetes
            List<Cadete> cadetes = JsonSerializer.Deserialize<List<Cadete>>(json);

            Console.WriteLine("Datos desde JSON:");
            Console.WriteLine(json);
        }
        catch (FileNotFoundException)
        {
            System.Console.WriteLine($"El archivo CSV en la ruta '{"/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadetes.json"}' no fue encontrado.");
        }
    }
}