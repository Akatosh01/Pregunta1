using System;
using System.Reflection.Metadata;
public class Estudiante : Persona
{
    public string Carrera { get; set; }
    public int Anio { get; set; }

    public Estudiante(string nombre, int edad, string identificacion, string carrera, int anio)
        : base(nombre, edad, identificacion)
    {
        Carrera = carrera;
        Anio = anio;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Estudiante: {Nombre}, Edad: {Edad}, ID: {Identificacion}, Carrera: {Carrera}, Año: {Anio}");
    }
}