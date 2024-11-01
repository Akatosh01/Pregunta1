using System;

public class Docente : Persona
{
    public string Asignatura { get; set; }
    public int AniosExperiencia { get; set; }

    public Docente(string nombre, int edad, string identificacion, string asignatura, int aniosExperiencia)
        : base(nombre, edad, identificacion)
    {
        Asignatura = asignatura;
        AniosExperiencia = aniosExperiencia;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Docente: {Nombre}, Edad: {Edad}, ID: {Identificacion}, Asignatura: {Asignatura}, Años de Experiencia: {AniosExperiencia}");
    }
}