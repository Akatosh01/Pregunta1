using System;

public class Administrativo : Persona
{
    public string Departamento { get; set; }
    public string Puesto { get; set; }

    public Administrativo(string nombre, int edad, string identificacion, string departamento, string puesto)
        : base(nombre, edad, identificacion)
    {
        Departamento = departamento;
        Puesto = puesto;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"Administrativo: {Nombre}, Edad: {Edad}, ID: {Identificacion}, Departamento: {Departamento}, Puesto: {Puesto}");
    }
}