using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json.Serialization;


public class AccesoADatos
{
    protected string Ruta;

    public AccesoADatos(string rutaArchivo)
    {
        this.Ruta = rutaArchivo;
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
    public AccesoCSV(string rutaArchivo) : base(rutaArchivo)
    {

    }

    public override void leerCadete()
    {
        try
        {
            using (var reader = new StreamReader(this.Ruta))
            {
                Console.WriteLine("Datos desde CSV:");

                // Leer la primera línea para obtener los nombres de las columnas
                var encabezados = reader.ReadLine()?.Split(',');

                if (encabezados != null)
                {
                    while (!reader.EndOfStream)
                    {
                        var linea = reader.ReadLine();
                        var valores = linea.Split(',');

                        if (valores.Length == encabezados.Length)
                        {
                            var cadete = new Cadete(int.Parse(valores[0]), valores[1], valores[2], valores[3]);

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
            Console.WriteLine($"El archivo CSV en la ruta '{this.Ruta}' no fue encontrado.");
        }
    }
}

public class AccesoJSON : AccesoADatos
{
    public AccesoJSON(string rutaArchivo) : base(rutaArchivo)
    {

    }

    public override void leerCadete()
    {
        try
        {
            var json = File.ReadAllText(this.Ruta);
            Console.WriteLine("Datos desde JSON:");
            Console.WriteLine(json);
        }
        catch (FileNotFoundException)
        {
            System.Console.WriteLine($"El archivo CSV en la ruta '{this.Ruta}' no fue encontrado.");
        }
    }
}