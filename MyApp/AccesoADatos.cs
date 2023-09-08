using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;


public abstract class AccesoADatos
{
    public AccesoADatos()
    {
    }

    public abstract List<Cadete> leerCadete();

    public abstract Cadeteria leerCadeteria();
}

public class AccesoCSV : AccesoADatos
{
    public AccesoCSV() : base()
    {

    }

    public override Cadeteria leerCadeteria()
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
                    var cadeter = new Cadeteria();
                    while (!reader.EndOfStream)
                    {
                        var linea = reader.ReadLine();
                        var valores = linea.Split(',');
                        if (valores.Length == encabezados.Length)
                        {
                            var cadeteria = new Cadeteria(valores[0], valores[1]);


                            cadeter = cadeteria;

                            Console.WriteLine($"Cadeteria: {valores[0]}, Telefono: {valores[1]}");
                        }
                        else
                        {
                            Console.WriteLine("La línea no tiene el formato correcto.");
                        }
                    }
                    System.Console.WriteLine("Cadeteria cargada correctamente.");
                    return cadeter;
                }
                else
                {
                    System.Console.WriteLine("La cadeteria no se cargo correctamente.");
                    return new Cadeteria();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"El archivo CSV en la ruta '{"/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadeteria.csv"}' no fue encontrado.");
            return new Cadeteria();
        }
    }



    public override List<Cadete> leerCadete()
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
                    System.Console.WriteLine("Cadetes cargados correctamente.");
                    return listaCadetes;
                }
                else
                {
                    System.Console.WriteLine("Los cadetes no se cargaron correctamente.");
                    return new List<Cadete>();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"El archivo CSV en la ruta '{"/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadetes.csv"}' no fue encontrado.");
            return new List<Cadete>();
        }
    }
}

public class AccesoJSON : AccesoADatos
{
    public AccesoJSON() : base()
    {

    }

    public override Cadeteria leerCadeteria()
    {
        try
        {
            string json = File.ReadAllText("cadeteria.json");
            //Deserealizo el archivo
            Cadeteria cadeteria = JsonSerializer.Deserialize<Cadeteria>(json);

            Console.WriteLine("Datos desde JSON:");
            Console.WriteLine(json);

            System.Console.WriteLine("Cadeteria cargada correctamente.");
            return cadeteria;
        }
        catch (FileNotFoundException)
        {
            System.Console.WriteLine($"El archivo CSV en la ruta '{"/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadeteria.json"}' no fue encontrado.");
            return new Cadeteria();
        }
    }

    public override List<Cadete> leerCadete()
    {
        try
        {
            var json = File.ReadAllText("cadetes.json");
            //Deserealizo el archivo en una lista de cadetes
            List<Cadete> cadetes = JsonSerializer.Deserialize<List<Cadete>>(json);
            Console.WriteLine("Datos desde JSON:");
            Console.WriteLine(json);
            return cadetes;
        }
        catch (FileNotFoundException)
        {
            System.Console.WriteLine($"El archivo CSV en la ruta '{"/Users/angelnicolasmagro/Documents/GitHub/tl2-tp1-2023-NicoMagro/MyApp/cadetes.json"}' no fue encontrado.");
            return new List<Cadete>();
        }
    }
}